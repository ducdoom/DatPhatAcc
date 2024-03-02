using DatPhatAcc.Converters;
using DatPhatAcc.MisaDbContext;
using DatPhatAcc.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DatPhatAcc.Services
{
    public class MisaService
    {
        private const string OPENING = "Số dư đầu kỳ";
        private const string INWARD = "Mua hàng nhập kho";
        private const string OUTWARD = "Xuất kho";
        public MisaService()
        {
        }

        private Dictionary<string, string> refTypeDictionary = new();
        public async Task<Dictionary<string, string>> GetRefTypeDictionary()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            if (refTypeDictionary.Count > 0)
            {
                return refTypeDictionary;
            }

            MisaDbContext.AAMisaDbContext context = new();
            Debug.WriteLine($"{DateTime.Now} GetSearchRefTypes");
            var searchRefTypes = await context.SearchRefTypes.ToArrayAsync().ConfigureAwait(false);
            Debug.WriteLine($"{DateTime.Now} Done GetSearchRefTypes");

            foreach (var item in searchRefTypes)
            {
                string[] array = item.RefType.Split(',');
                foreach (string type in array)
                {
                    refTypeDictionary[type] = item.RefTypeName ?? string.Empty;
                    Debug.WriteLine($"{DateTime.Now} RefTypeDictionary: {type} - {item.RefTypeName}");
                }
            }

            stopwatch.Stop();
            Debug.WriteLine($"GetRefTypeDictionary: {stopwatch.ElapsedMilliseconds} ms");

            return refTypeDictionary;
        }

        public async Task<List<InventoryItemSummary>> GetInventoryItemSummaryBalance(DateTime fromDate, DateTime toDate)
        {
            Task getRefTypeDictionaryTask = GetRefTypeDictionary();

            //DateTime.Now trả về 01/01/2024 16:44:23 (bao gồm cả thời gian)
            //nên nếu giữ nguyên thì giá trị 01/01/2024 15:44:23 vẫn ăn vào
            fromDate = fromDate.ToStartOfDate();
            toDate = toDate.ToEndOfDate();

            MisaDbContext.AAMisaDbContext context = new();

            //lấy dữ liệu số dư đầu kỳ với điều kiện PostedDate < fromDate
            var opening = await context.InventoryLedgers
                .AsNoTracking()
                .Where(x => x.PostedDate < fromDate)
                .GroupBy(x => new { x.InventoryItemCode, x.StockCode })
                .Select(group => new InventoryItemSummary
                {
                    InventoryItemCode = group.Key.InventoryItemCode ?? string.Empty,
                    StockCode = group.Key.StockCode ?? string.Empty,
                    OpeningQuantity = group.Sum(x => x.InwardQuantity ?? decimal.Zero) - group.Sum(x => x.OutwardQuantity ?? decimal.Zero),
                    OpeningAmount = group.Sum(x => x.InwardAmount) - group.Sum(x => x.OutwardAmount)
                })
                .ToListAsync().ConfigureAwait(false);

            await getRefTypeDictionaryTask.ConfigureAwait(false);

            var inventoryLedger = await context.InventoryLedgers.AsNoTracking().ToListAsync().ConfigureAwait(false);

            //lấy dữ liệu nhập xuất kho trong khoảng thời gian fromDate - toDate
            var inOutWard = inventoryLedger
                //vì sử dụng hàm riêng GetRefTypeName nên không thể cho vào linq được
                .Where(x => GetRefTypeName(x.RefType).Equals(INWARD) || GetRefTypeName(x.RefType).Equals(OUTWARD))
                .Where(x => x.PostedDate >= fromDate && x.PostedDate <= toDate)
                .GroupBy(x => new { x.InventoryItemCode, x.StockCode })
                .Select(group => new InventoryItemSummary
                {
                    InventoryItemCode = group.Key.InventoryItemCode ?? string.Empty,
                    StockCode = group.Key.StockCode ?? string.Empty,
                    InQuantity = group.Sum(x => x.InwardQuantity ?? decimal.Zero),
                    InAmount = group.Sum(x => x.InwardAmount),
                    OutQuantity = group.Sum(x => x.OutwardQuantity ?? decimal.Zero),
                    OutAmount = group.Sum(x => x.OutwardAmount)
                })
                .ToList();

            List<InventoryItemSummary> inventoryItemSummaries = new();
            try
            {
                inventoryItemSummaries = opening
                    .Union(inOutWard)
                    .GroupBy(x => new { x.InventoryItemCode, x.StockCode })
                    .Select(group => new InventoryItemSummary
                    {
                        InventoryItemCode = group.Key.InventoryItemCode,
                        StockCode = group.Key.StockCode ?? string.Empty,
                        OpeningQuantity = group.Sum(x => x.OpeningQuantity),
                        OpeningAmount = group.Sum(x => x.OpeningAmount),
                        InQuantity = group.Sum(x => x.InQuantity),
                        InAmount = group.Sum(x => x.InAmount),
                        OutQuantity = group.Sum(x => x.OutQuantity),
                        OutAmount = group.Sum(x => x.OutAmount)
                    })
                    .Join(context.InventoryItems.AsNoTracking(), x => x.InventoryItemCode, y => y.InventoryItemCode, (x, y) => new InventoryItemSummary
                    {
                        InventoryItemCode = x.InventoryItemCode,
                        InventoryItemName = y.InventoryItemName ?? string.Empty,
                        StockCode = x.StockCode,
                        UnitId = y.UnitId ?? new Guid(),
                        OpeningQuantity = x.OpeningQuantity,
                        OpeningAmount = x.OpeningAmount,
                        InQuantity = x.InQuantity,
                        InAmount = x.InAmount,
                        OutQuantity = x.OutQuantity,
                        OutAmount = x.OutAmount
                    })
                    .Join(context.Units.AsNoTracking(), x => x.UnitId, unit => unit.UnitId, (inventoryItem, unit) => new InventoryItemSummary
                    {
                        InventoryItemCode = inventoryItem.InventoryItemCode,
                        InventoryItemName = inventoryItem.InventoryItemName,
                        StockCode = inventoryItem.StockCode,
                        UnitName = unit.UnitName,
                        OpeningQuantity = inventoryItem.OpeningQuantity,
                        OpeningAmount = inventoryItem.OpeningAmount,
                        InQuantity = inventoryItem.InQuantity,
                        InAmount = inventoryItem.InAmount,
                        OutQuantity = inventoryItem.OutQuantity,
                        OutAmount = inventoryItem.OutAmount
                    })
                    .OrderBy(x => x.InventoryItemCode)
                    .ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return inventoryItemSummaries;
        }

        public async Task<decimal> GetInventoryItemClosingQuantityByItemCode(string inventoryItemCode)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            IEnumerable<InventoryItemSummary> inventoryItemSummaries = await GetInventoryItemSummaryBalance(fromDate, toDate).ConfigureAwait(false);
            if (!inventoryItemSummaries.Any())
            {
                return decimal.Zero;
            }

            var item = inventoryItemSummaries.FirstOrDefault(x => x.InventoryItemCode.Equals(inventoryItemCode));
            if (item is null)
            {
                return decimal.Zero;
            }

            return item.ClosingQuantity;
        }

        public string GetRefTypeName(int refType)
        {
            _ = refTypeDictionary.TryGetValue(refType.ToString(), out string refTypeName);
            if (refTypeName is null)
            {
                return "Not Found";
            }

            return refTypeName;
        }

        public async Task<IEnumerable<MisaDbContext.SaleLedger>> GetSaleLedgersSummary(DateTime fromDate, DateTime toDate)
        {
            DateTime fromDateStart = fromDate.ToStartOfDate();
            DateTime toDateEnd = toDate.ToEndOfDate();

            MisaDbContext.AAMisaDbContext context = new();
            var saleLedgers = await context.SaleLedgers.AsNoTracking()
                 .OrderByDescending(x => x.InvNo)
                 .Where(x => x.PostedDate >= fromDateStart && x.PostedDate <= toDateEnd)
                 .GroupBy(group => group.InvNo)
                 .Select(x => new SaleLedger
                 {
                     InvNo = x.Key,
                     RefId = x.First().RefId,
                     PostedDate = x.First().PostedDate,
                     AccountObjectName = x.First().AccountObjectName,
                     SaleAmount = x.Sum(x => x.SaleAmount)
                 }).ToArrayAsync().ConfigureAwait(false);

            return saleLedgers;
        }

        public async Task<IEnumerable<Models.SaleLedgerDetail>> GetSaleLedgersDetail(Guid refId)
        {
            MisaDbContext.AAMisaDbContext context = new();
            IEnumerable<SaleLedgerDetail> saleLedgerDetails = await context.SaleLedgers.AsNoTracking()
                .Where(x => x.RefId.Equals(refId))
                .Join(context.Units, sl => sl.UnitId, unit => unit.UnitId, (sld, unit) => new Models.SaleLedgerDetail
                {
                    InvNo = sld.InvNo,
                    InventoryItemCode = sld.InventoryItemCode,
                    InventoryItemName = sld.InventoryItemName,
                    UnitId = sld.UnitId,
                    UnitName = unit.UnitName,
                    UnitPrice = sld.UnitPrice,
                    SaleQuantity = sld.SaleQuantity,
                    SaleAmount = sld.SaleAmount,
                    Vatrate = sld.Vatrate,
                    Vatamount = sld.Vatamount
                }).ToListAsync().ConfigureAwait(false);

            return saleLedgerDetails;
        }

        public async Task CheckInvoice(Invoice invoice)
        {
            MisaDbContext.AAMisaDbContext context = new();
            var invoiceFound = await context.PurchaseLedgers
                .AsNoTracking()
                .Where(x => (x.InvSeries ?? string.Empty).Equals(invoice.InvoiceSeries)
                        && (x.InvNo ?? string.Empty).Equals(invoice.InvoiceNumber)
                        && x.InvDate.Equals(invoice.InvoiceDate)
                        && (x.AccountObjectTaxCode ?? string.Empty).Equals(invoice.SellerTaxCode)
                        )
                .GroupBy(x => x.RefId)
                .Select(x => new Invoice
                {
                    InvoiceTemplateCode = invoice.InvoiceTemplateCode,
                    InvoiceCode = invoice.InvoiceCode,
                    InvoiceNumber = x.First().InvNo ?? string.Empty,
                    InvoiceDateString = x.First().InvDate.GetValueOrDefault().ToString("dd/MM/yyyy") ?? DateTime.MinValue.ToString("dd/MM/yyyy"),
                    SellerTaxCode = x.First().AccountObjectTaxCode ?? string.Empty,
                    SellerName = x.First().AccountObjectName ?? string.Empty,
                    TotalAmountVAT = (double)x.Sum(x => x.PurchaseAmount + x.Vatamount),
                    TotalTaxAmount = (double)x.Sum(x => x.Vatamount)
                })
                .ToListAsync().ConfigureAwait(false);

            if (invoiceFound.Count == 1
                && invoiceFound.First().TotalAmountWithoutTax == invoice.TotalAmountWithoutTax
                && invoiceFound.First().TotalTaxAmount == invoice.TotalTaxAmount
                && invoiceFound.First().TotalAmountVAT == invoice.TotalAmountVAT
                )
            {
                invoice.Checked = true;
            }

            invoice.InvoiceCount = invoiceFound.Count;

            Debug.WriteLine($"Invoice {invoice.InvoiceSeries} {invoice.InvoiceNumber}");
        }

        internal async Task AddMoreInvoiceThatDoesNotExistInTCT(List<Invoice> invoices, DateTime fromDate, DateTime toDate)
        {
            MisaDbContext.AAMisaDbContext context = new();
            var purchaseLedgers = await context.PurchaseLedgers
                .AsNoTracking()
                .Where(x => x.PostedDate >= fromDate && x.PostedDate <= toDate)
                .GroupBy(x => x.RefId)
                .Select(x => new Invoice
                {
                    InvoiceSeriesManual = x.First().InvSeries ?? string.Empty,
                    InvoiceNumber = x.First().InvNo ?? string.Empty,                    
                    InvoiceDateString = x.First().InvDate.GetValueOrDefault().ToString("dd/MM/yyyy") ?? DateTime.MinValue.ToString("dd/MM/yyyy"),
                    SellerTaxCode = x.First().AccountObjectTaxCode ?? string.Empty,
                    SellerName = x.First().AccountObjectName ?? string.Empty,
                    TotalAmountVAT = (double)x.Sum(x => x.PurchaseAmount + x.Vatamount),
                    TotalTaxAmount = (double)x.Sum(x => x.Vatamount),
                    InvoiceCheckResult = "Có trên Misa, Không có trên TCT"
                })
                .ToListAsync().ConfigureAwait(false);

            var result = purchaseLedgers
                .Where(purchaseLedger => !invoices.Any(invoice => 
                    purchaseLedger.InvoiceSeriesManual.Equals(invoice.InvoiceSeries)
                    && purchaseLedger.InvoiceNumber.Equals(invoice.InvoiceNumber)
                    && purchaseLedger.SellerTaxCode.Equals(invoice.SellerTaxCode)
                    )).ToList();

            invoices.AddRange(result);
        }
    }
}
