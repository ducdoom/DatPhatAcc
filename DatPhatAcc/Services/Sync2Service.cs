using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DatPhatAcc.Services
{
    public class Sync2Service
    {
        private readonly AccountingService accountingService;
        private readonly MisaService misaService;

        public Sync2Service(AccountingService accountingService, MisaService misaService)
        {
            this.accountingService = accountingService;
            this.misaService = misaService;
        }

        public AccountingService AccountingService => accountingService;
        public MisaService MisaService => misaService;

        public async Task<IEnumerable<TranDetail2>> GetSyncExportInnerTransactions(AccountingDbContext.Customer customer, DateTime fromDate, DateTime toDate, ListVat listVat)
        {
            Task<List<InventoryItemSummary>> inventoryItemSummariesTask = misaService.GetInventoryItemSummaryBalance(DateTime.Now, DateTime.Now);
            Task<IEnumerable<TranDetailInfo>> transDetailsTask = accountingService.GetTransDetaiExportInnerAsync(customer, fromDate, toDate);


            var tranDetalInfos = await transDetailsTask.ConfigureAwait(false);

            var inventoryItemSummaries = await inventoryItemSummariesTask.ConfigureAwait(false);
            inventoryItemSummaries = inventoryItemSummaries
                .OrderBy(item => item.InventoryItemCode)
                .ThenByDescending(item => item.StockCode.StartsWith("BAN"))
                .ToList();

            foreach (TranDetailInfo tranDetal in tranDetalInfos)
            {
                if (!inventoryItemSummaries.Any(item => item.InventoryItemCode.Equals(tranDetal.GoodId)))
                {
                    InventoryItemSummary inventoryItemSummary = new()
                    {
                        InventoryItemCode = tranDetal.GoodId,
                        InventoryItemName = tranDetal.ShortName,
                        UnitName = tranDetal.UnitName,
                        StockCode = tranDetal.StockCode,
                    };
                    inventoryItemSummaries.Add(inventoryItemSummary);
                }
            }

            List<TranDetail2> tranDetail2s = new();
            foreach (TranDetailInfo t in tranDetalInfos)
            {
                TranDetail2 tranDetail2 = new()
                {
                    InventoryItems = new(inventoryItemSummaries),
                    SelectedInventoryItem = inventoryItemSummaries.First(item => item.InventoryItemCode.Equals(t.GoodId)),
                    Quantity = t.Quantity,
                    VatRate = listVat.VatValue,
                    TotalAmountVat = t.TotalAmountVat,
                };
                tranDetail2s.Add(tranDetail2);
            }

            return tranDetail2s;
        }

        public async Task<IEnumerable<TranDetail2>> GetRetailTranDetail(DateTime fromDate, DateTime toDate, ListVat selectedListVat, string transactionIds = "")
        {
            Task<List<InventoryItemSummary>> getInventoryItemSummaryBalanceTask = misaService.GetInventoryItemSummaryBalance(DateTime.Now, DateTime.Now);

            string fromDateString = fromDate.ToString("yyyyMMdd");
            string toDateString = toDate.ToString("yyyyMMdd");
            List<string> tranIdList = transactionIds.Split(',').ToList();

            Accounting_LTTDbContext.ACCOUNTING_LTTContext accounting_LTTContext = new();
            ACCOUNTINGContext accountingDbContext = new();

            // Query for retail transactions with AsNoTracking for better performance
            var retailTransQuery = accounting_LTTContext.RetailTranDetails
                .AsNoTracking()
                .Where(x => (string.IsNullOrEmpty(transactionIds) || tranIdList.Contains(x.TransactionId))
                    && x.Status.Equals("1")
                    && string.Compare(x.TransDate, fromDateString) >= 0
                    && string.Compare(x.TransDate, toDateString) <= 0)
                .Select(x => new TranDetailInfo
                {
                    GoodId = x.GoodId,
                    Quantity = (decimal)(x.OrginalQty ?? 0),
                    TotalAmountVat = (decimal)(x.TotalPriceVatorg ?? 0)
                });

            Debug.WriteLine("retailTransQuery Count: " + retailTransQuery.Count());

            // Query for discounts with AsNoTracking
            var discountsQuery = accounting_LTTContext.TransactionDiscountDetails
                .AsNoTracking()
                .Where(x => tranIdList.Contains(x.TransactionId))
                .GroupBy(x => x.FullGoodId)
                .Select(group => new
                {
                    GoodId = group.Key,
                    DiscountAmount = group.Sum(x => x.DiscountAmount)
                });

            Debug.WriteLine("discountsQuery Count: " + discountsQuery.Count());

            // Execute the queries asynchronously
            var retailTransResults = await retailTransQuery.ToListAsync().ConfigureAwait(false);
            var discounts = await discountsQuery.ToListAsync().ConfigureAwait(false);

            List<InventoryItemSummary> inventoryItemSummaries = await getInventoryItemSummaryBalanceTask.ConfigureAwait(false);

            // Combine and process the results
            var tranDetailInfoSum = retailTransResults
                .GroupBy(x => x.GoodId)
                .Select(group =>
                {
                    var discount = discounts.FirstOrDefault(d => d.GoodId == group.Key)?.DiscountAmount ?? decimal.Zero;
                    return new TranDetailInfo
                    {
                        GoodId = group.Key,
                        Quantity = group.Sum(x => x.Quantity),
                        TotalAmountVat = group.Sum(x => x.TotalAmountVat) - discount
                    };
                });

            Debug.WriteLine("tranDetailInfoSum Count: " + tranDetailInfoSum.Count());

            var tranDetailInfoWithShortName = tranDetailInfoSum
                .Join(accountingDbContext.Goods.AsNoTracking(), t => t.GoodId, g => g.GoodId, (tranDetail, good) => new TranDetailInfo
                {
                    GoodId = tranDetail.GoodId,
                    ShortName = good.ShortName,
                    UnitId = good.UnitId,
                    Quantity = tranDetail.Quantity,
                    TotalAmountVat = tranDetail.TotalAmountVat
                });

            Debug.WriteLine("tranDetailInfoWithShortName Count: " + tranDetailInfoWithShortName.Count());

            var tranDetailInfoWithUnitName = tranDetailInfoWithShortName
                .Join(accountingDbContext.Units.AsNoTracking(), td => td.UnitId, u => u.UnitId, (tranDetail, unit) => new TranDetailInfo
                {
                    GoodId = tranDetail.GoodId,
                    ShortName = tranDetail.ShortName,
                    UnitId = tranDetail.UnitId,
                    UnitName = unit.UnitName,
                    Quantity = tranDetail.Quantity,
                    TotalAmountVat = tranDetail.TotalAmountVat,
                    VatRate = selectedListVat.VatValue
                });

            Debug.WriteLine("tranDetailInfoWithUnitName Count: " + tranDetailInfoWithUnitName.Count());

            //add closing quantity
            IEnumerable<TranDetail2> tranDetail2s = ConvertToTranDetail2(tranDetailInfoWithUnitName.ToList(), inventoryItemSummaries);

            return tranDetail2s;
        }

        public async Task<IEnumerable<TranDetail2>> GetRetailTranDetailv2(DateTime fromDate, DateTime toDate, ListVat selectedListVat, string transactionIds = "")
        {
            Task<List<InventoryItemSummary>> getInventoryItemSummaryBalanceTask = misaService.GetInventoryItemSummaryBalance(DateTime.Now, DateTime.Now);

            string fromDateString = fromDate.ToString("yyyyMMdd");
            string toDateString = toDate.ToString("yyyyMMdd");
            List<string> tranIdList = transactionIds.Split(',').ToList();

            Accounting_LTTDbContext.ACCOUNTING_LTTContext accounting_LTTContext = new();
            ACCOUNTINGContext accountingDbContext = new();

            // Query for retail transactions with AsNoTracking for better performance
            var retailTransQuery = accounting_LTTContext.RetailTranDetails
                .AsNoTracking()
                .Where(x => (string.IsNullOrEmpty(transactionIds) || tranIdList.Contains(x.TransactionId))
                    && x.Status.Equals("1")
                    && string.Compare(x.TransDate, fromDateString) >= 0
                    && string.Compare(x.TransDate, toDateString) <= 0)

                // Left join with TransactionDiscountDetails
                .GroupJoin(
                    accounting_LTTContext.TransactionDiscountDetails.AsNoTracking(), // The second dataset
                    rtd => rtd.TransDetailId, // Key from the first dataset
                    tdd => tdd.TransDetailId, // Key from the second dataset
                    (rtd, tddGroup) => new { rtd, tddGroup } // Result selector
                )
                .SelectMany(
                    x => x.tddGroup.DefaultIfEmpty(), // This creates a left join effect
                    (x, tdd) => new TranDetailInfo
                    {
                        GoodId = x.rtd.GoodId,
                        Quantity = (decimal)(x.rtd.OrginalQty ?? 0),
                        TotalAmountVat = (decimal)(x.rtd.TotalPriceVatorg ?? 0) - (tdd != null ? tdd.DiscountAmount : 0)
                    })

                //group by goodid
                .GroupBy(x => x.GoodId)
                .Select(tran => new TranDetailInfo
                {
                    GoodId = tran.Key,
                    Quantity = tran.Sum(x => x.Quantity),
                    TotalAmountVat = tran.Sum(x => x.TotalAmountVat)
                }).ToArray();

            var tranDetailInfoWithGoodName = retailTransQuery
            //join good
            .Join(accountingDbContext.Goods.AsNoTracking(), t => t.GoodId, g => g.GoodId, (tranDetail, good) => new TranDetailInfo
            {
                GoodId = tranDetail.GoodId,
                ShortName = good.ShortName,
                UnitId = good.UnitId,
                Quantity = tranDetail.Quantity,
                TotalAmountVat = tranDetail.TotalAmountVat
            })

            //join unit
            .Join(accountingDbContext.Units.AsNoTracking(), td => td.UnitId, u => u.UnitId, (tranDetail, unit) => new TranDetailInfo
            {
                GoodId = tranDetail.GoodId,
                ShortName = tranDetail.ShortName,
                UnitId = tranDetail.UnitId,
                UnitName = unit.UnitName,
                Quantity = tranDetail.Quantity,
                TotalAmountVat = tranDetail.TotalAmountVat,
                VatRate = selectedListVat.VatValue
            });

            List<InventoryItemSummary> inventoryItemSummaries = await getInventoryItemSummaryBalanceTask.ConfigureAwait(false);
            inventoryItemSummaries = inventoryItemSummaries
                .OrderBy(item => item.InventoryItemCode)
                .ThenByDescending(item => item.StockCode.StartsWith("KHANG"))
                .ToList();
            //add closing quantity
            IEnumerable<TranDetail2> tranDetail2s = ConvertToTranDetail2(tranDetailInfoWithGoodName.ToList(), inventoryItemSummaries);

            return tranDetail2s;
        }

        private IEnumerable<TranDetail2> ConvertToTranDetail2(List<TranDetailInfo> tranDetailInfos, List<InventoryItemSummary> inventoryItemSummaries)
        {
            foreach (TranDetailInfo tranDetailInfo in tranDetailInfos)
            {
                if (!inventoryItemSummaries.Any(item => item.InventoryItemCode.Equals(tranDetailInfo.GoodId)))
                {
                    InventoryItemSummary inventoryItemSummary = new()
                    {
                        InventoryItemCode = tranDetailInfo.GoodId,
                        InventoryItemName = tranDetailInfo.ShortName,
                        UnitName = tranDetailInfo.UnitName,
                    };
                    inventoryItemSummaries.Add(inventoryItemSummary);
                }
            }
            Debug.WriteLine("inventoryItemSummaries Count: " + inventoryItemSummaries.Count());
            Debug.WriteLine("tranDetailInfos Count: " + tranDetailInfos.Count());

            List<TranDetail2> tranDetail2s = new();
            foreach (TranDetailInfo t in tranDetailInfos)
            {
                TranDetail2 tranDetail2 = new()
                {
                    InventoryItems = new(inventoryItemSummaries),
                    SelectedInventoryItem = inventoryItemSummaries.First(item => item.InventoryItemCode.Equals(t.GoodId)),
                    Quantity = t.Quantity,
                    TotalAmountVat = t.TotalAmountVat,
                    VatRate = t.VatRate
                };
                tranDetail2s.Add(tranDetail2);
            }

            return tranDetail2s;
        }
    }
}
