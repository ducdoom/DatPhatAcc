using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Converters;
using DatPhatAcc.Models;
using DatPhatAcc.Models.DTO;
using DevExpress.Mvvm.Native;
using Microsoft.EntityFrameworkCore;

namespace DatPhatAcc.Services
{
    public class AccountingService
    {
        private MisaService misaService;
        public AccountingService(MisaService misaService)
        {
            this.misaService = misaService;
        }

        public async Task<IEnumerable<CustomerDTO>> GetCustomers()
        {
            using ACCOUNTINGContext accountingContext = new();
            var customerList = await accountingContext.Customers
                .Select(x => new CustomerDTO
                {
                    CustomerId = x.CustomerId,
                    CustomerName = x.CustomerName,
                    TaxCode = x.Taxcode
                })
                .ToArrayAsync();

            return customerList;
        }

        public async Task<IEnumerable<TransactionOverview>> SearchTransactionOverview(DateTime fromDate, DateTime toDate, IEnumerable<CustomerDTO> customerDTOs, AccountingDbContext.TransType transType)
        {
            int fromTranDate = Convert.ToInt32(fromDate.ToTranDate());
            int toTranDate = Convert.ToInt32(toDate.ToTranDate());

            using ACCOUNTINGContext accountingContext = new();
            var transactionOverviews = await accountingContext.Transactions.Where(
                 x => Convert.ToInt32(x.TransDate) >= fromTranDate
                 && Convert.ToInt32(x.TransDate) <= toTranDate
                 && (customerDTOs.Select(x => x.CustomerId).Contains(x.ImportId) || customerDTOs.Select(x => x.CustomerId).Contains(x.ExportId))
                 && x.TransCode.Equals(transType.TransCode)
                 && x.Status.Equals("1")
                 )
                 .Select(x => new TransactionOverview
                 {
                     TransactionId = x.TransactionId,
                     TransCode = x.TransCode,
                     TranDate = x.TransDate,
                     TotalPriceVat = x.TotalPriceVat
                 })
                 .OrderBy(x => x.TranDate)
                 .ToArrayAsync();

            return transactionOverviews;
        }

        public async Task<IEnumerable<AccountingDbContext.TransType>> GetTransTypesAsync()
        {
            using ACCOUNTINGContext accountingContext = new();
            return await accountingContext.TransTypes.ToArrayAsync();
        }

        //public async Task<IEnumerable<ListVat>> GetListVatsAsync()
        //{
        //    using ACCOUNTINGContext accountingContext = new();
        //    return await accountingContext.ListVats.ToArrayAsync();
        //}

        public async Task<IEnumerable<TransDetailDTO>> GetTransDetailDTOsAsync(IEnumerable<TransactionOverview> transactionOverviews, AccountingDbContext.ListVat selectedlistVat)
        {
            using ACCOUNTINGContext accountingContext = new();
            TransactionOverview transaction = transactionOverviews.First();

            var transDetails = await accountingContext.TransDetails
                .Where(x => transactionOverviews.Select(x => x.TransactionId).Contains(x.TransactionId))
                .Join(accountingContext.Goods, transDetail => transDetail.GoodId, good => good.GoodId,
                (transDetail, good) => new TransDetailDTO()
                {
                    GoodId = transDetail.GoodId,
                    ShortName = good.ShortName,
                    Quantity = transDetail.Quantity ?? 0,
                    TotalPriceVat = (transaction.TransCode.Equals("01") ? transDetail.TotalImpPriceVat : transDetail.TotalExpPriceVat) ?? 0
                })
                .GroupBy(x => new { x.GoodId, x.ShortName })
                .Select(group => new TransDetailDTO
                {
                    GoodId = group.Key.GoodId,
                    ShortName = group.Key.ShortName,
                    Quantity = group.Sum(x => x.Quantity),
                    VatValue = selectedlistVat.VatValue,
                    TotalPriceVat = group.Sum(x => x.TotalPriceVat)
                })
                .ToArrayAsync();

            return transDetails;
        }

        public static string GetUnitNameByGoodId(string goodId)
        {
            ACCOUNTINGContext aCCOUNTINGContext = new();
            AccountingDbContext.Good? good = aCCOUNTINGContext.Goods.FirstOrDefault(x => x.GoodId.Equals(goodId));
            if (good is null)
            {
                return string.Empty;
            }

            string? unitName = aCCOUNTINGContext.Units.FirstOrDefault(x => x.UnitId.Equals(good.UnitId))?.UnitName;
            if (unitName is null)
            {
                return string.Empty;
            }

            return unitName;
        }

        public async Task<IEnumerable<TransDetailDTO>> GetRetailTrans(string tranIds)
        {
            List<string> tranIdList = tranIds.Split(',').ToList();

            using Accounting_LTTDbContext.ACCOUNTING_LTTContext accounting_LTTContext = new();
            var retailTrans = await accounting_LTTContext.RetailTranDetails
                .Where(x => tranIds.Contains(x.TransactionId))
                .Join(accounting_LTTContext.Goods, retailTran => retailTran.GoodId, good => good.GoodId, (retailTran, good) => new TransDetailDTO
                {
                    GoodId = retailTran.GoodId,
                    ShortName = good.ShortName,
                    Quantity = retailTran.Quantity ?? 0,
                    TotalPriceVat = retailTran.TotalExpPriceVat ?? decimal.Zero
                })
                .GroupBy(x => x.GoodId)
                .Select(group => new Models.DTO.TransDetailDTO
                {
                    GoodId = group.Key,
                    ShortName = group.First().ShortName,
                    Quantity = group.Sum(x => x.Quantity),
                    TotalPriceVat = group.Sum(x => x.TotalPriceVat)
                })
                .ToArrayAsync().ConfigureAwait(false);

            using Accounting_LTTDbContext.ACCOUNTING_LTTContext accounting_LTTContext2 = new();
            var discounts = await accounting_LTTContext2.TransactionDiscountDetails
                .Where(x => tranIds.Contains(x.TransactionId))
                .GroupBy(x => x.FullGoodId)
                .Select(group => new RetailTranDetailDTO
                {
                    GoodId = group.Key,
                    DiscountAmount = group.Sum(x => x.DiscountAmount)
                })
                .ToArrayAsync().ConfigureAwait(false);

            foreach (var discount in discounts)
            {
                TransDetailDTO? retailTranDetailDTO = retailTrans.FirstOrDefault(x => x.GoodId.Equals(discount.GoodId));
                if (retailTranDetailDTO is not null)
                {
                    retailTranDetailDTO.TotalPriceVat -= discount.DiscountAmount;
                }
            }

            return retailTrans;
        }

        public async Task<List<TransDetailDTO>> GetRetailTransByTransactionId(string tranIds)
        {
            Task<List<InventoryItemSummary>> getInventoryItemSummaryBalanceTask = misaService.GetInventoryItemSummaryBalance(DateTime.Now, DateTime.Now);

            List<string> tranIdList = tranIds.Split(',').ToList();
            using Accounting_LTTDbContext.ACCOUNTING_LTTContext accounting_LTTContext = new();

            // Query for retail transactions with AsNoTracking for better performance
            var retailTransQuery = accounting_LTTContext.RetailTranDetails
                .AsNoTracking()
                .Where(x => tranIdList.Contains(x.TransactionId))
                .Join(accounting_LTTContext.Goods.AsNoTracking(), retailTran => retailTran.GoodId, good => good.GoodId, (retailTran, good) => new
                {
                    retailTran.GoodId,
                    good.ShortName,
                    retailTran.OrginalQty,
                    retailTran.TotalPriceVatorg
                });

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

            // Execute the queries asynchronously
            var retailTransResults = await retailTransQuery.ToListAsync().ConfigureAwait(false);
            var discounts = await discountsQuery.ToListAsync().ConfigureAwait(false);

            // Combine and process the results
            var finalResults = retailTransResults
                .GroupBy(x => x.GoodId)
                .Select(group =>
                {
                    var discount = discounts.FirstOrDefault(d => d.GoodId == group.Key)?.DiscountAmount ?? decimal.Zero;
                    return new TransDetailDTO
                    {
                        GoodId = group.Key,
                        ShortName = group.First().ShortName,
                        Quantity = group.Sum(x => x.OrginalQty ?? 0),
                        TotalPriceVat = group.Sum(x => x.TotalPriceVatorg ?? decimal.Zero) - discount
                    };
                }).ToList();

            List<InventoryItemSummary> inventoryItemSummaries = await getInventoryItemSummaryBalanceTask.ConfigureAwait(false);
            //add closing quantity
            await AddClosingQuantityAndCostPriceUnit(finalResults, inventoryItemSummaries).ConfigureAwait(false);

            return finalResults;
        }

        public async Task<List<TransDetailDTO>> GetRetailTransByDate(DateTime fromDate, DateTime toDate)
        {
            Task<List<InventoryItemSummary>> getInventoryItemSummaryBalanceTask = misaService.GetInventoryItemSummaryBalance(DateTime.Now, DateTime.Now);

            using Accounting_LTTDbContext.ACCOUNTING_LTTContext accounting_LTTContext = new();
            string fromDateString = fromDate.ToString("yyyyMMdd");
            string toDateString = toDate.ToString("yyyyMMdd");

            // Get list of retail transactionsId
            var retailTranIds = accounting_LTTContext.RetailTrans
                .AsNoTracking()
                .Where(rt => string.Compare(rt.TransDate, fromDateString) >= 0
                    && string.Compare(rt.TransDate, toDateString) <= 0
                    && rt.Status.Equals("1")
                    && rt.TransCode.Equals("03"))

                .Select(rt => rt.TransactionId)
                .ToArray();

            // Query for retail transactions with AsNoTracking for better performance
            var retailTransQuery = accounting_LTTContext.RetailTranDetails
                .AsNoTracking()
                .Where(rtd => retailTranIds.Contains(rtd.TransactionId))
                .Join(accounting_LTTContext.Goods.AsNoTracking(), retailTran => retailTran.GoodId, good => good.GoodId, (retailTran, good) => new
                {
                    retailTran.GoodId,
                    good.ShortName,
                    retailTran.OrginalQty,
                    retailTran.TotalPriceVatorg
                });

            // Query for discounts with AsNoTracking
            var discountsQuery = accounting_LTTContext.TransactionDiscountDetails
                .AsNoTracking()
                .Where(rtd => retailTranIds.Contains(rtd.TransactionId))
                .GroupBy(x => x.FullGoodId)
                .Select(group => new
                {
                    GoodId = group.Key,
                    DiscountAmount = group.Sum(x => x.DiscountAmount)
                });

            // Execute the queries asynchronously
            var retailTransResults = await retailTransQuery.ToListAsync().ConfigureAwait(false);
            var discounts = await discountsQuery.ToListAsync().ConfigureAwait(false);

            // Combine and process the results
            var finalResults = retailTransResults
                .GroupBy(x => x.GoodId)
                .Select(group =>
                {
                    var discount = discounts.FirstOrDefault(d => d.GoodId == group.Key)?.DiscountAmount ?? decimal.Zero;
                    return new TransDetailDTO
                    {
                        GoodId = group.Key,
                        ShortName = group.First().ShortName,
                        Quantity = group.Sum(x => x.OrginalQty ?? 0),
                        TotalPriceVat = group.Sum(x => x.TotalPriceVatorg ?? decimal.Zero) - discount
                    };
                });

            List<InventoryItemSummary> inventoryItemSummaries = await getInventoryItemSummaryBalanceTask.ConfigureAwait(false);
            List<TransDetailDTO> transDetailDTOs = finalResults.ToList();
            //add closing quantity
            await AddClosingQuantityAndCostPriceUnit(transDetailDTOs, inventoryItemSummaries).ConfigureAwait(false);

            return transDetailDTOs;
        }

        public async Task AddClosingQuantityAndCostPriceUnit(List<TransDetailDTO> transDetailDTOs, List<InventoryItemSummary> inventoryItemSummaries)
        {
            await Task.Delay(0).ConfigureAwait(false);
            var sortedSummary = inventoryItemSummaries.OrderByDescending(stock => stock.StockCode.StartsWith("KHANG"));

            foreach (var item in transDetailDTOs)
            {
                item.ClosingQuantity = sortedSummary.FirstOrDefault(x => x.InventoryItemCode.Equals(item.GoodId))?.ClosingQuantity ?? 0;
                item.CostPriceUnit = sortedSummary.FirstOrDefault(x => x.InventoryItemCode.Equals(item.GoodId))?.CostPriceUnit ?? 0;
                item.StockCode = sortedSummary.FirstOrDefault(x => x.InventoryItemCode.Equals(item.GoodId))?.StockCode ?? string.Empty;
            }
        }

        public async Task<IEnumerable<Branch>> GetBranchesAsync()
        {
            ACCOUNTINGContext context = new();
            return await context.Branches.ToArrayAsync().ConfigureAwait(false);
        }
    }
}
