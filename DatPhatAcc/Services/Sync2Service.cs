using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Models;

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
    }
}
