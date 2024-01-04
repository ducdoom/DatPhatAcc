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
            if (refTypeDictionary.Count > 0)
            {
                return refTypeDictionary;
            }

            MisaDbContext.AAMisaDbContext context = new();
            var searchRefTypes = await context.SearchRefTypes.ToArrayAsync().ConfigureAwait(false);

            foreach (var item in searchRefTypes)
            {
                string[] array = item.RefType.Split(',');
                foreach (string type in array)
                {
                    refTypeDictionary[type] = item.RefTypeName;
                }
            }

            return refTypeDictionary;
        }

        private List<InventoryItem> inventoryItems = new();
        private List<InventoryItem> InventoryItems()
        {
            MisaDbContext.AAMisaDbContext context = new();
            var newInventoryItems = context.InventoryItems.AsNoTracking().ToList();
            if (inventoryItems.Count.Equals(newInventoryItems.Count))
            {
                return inventoryItems;
            }
            else
            {
                inventoryItems = newInventoryItems;
                return inventoryItems;
            }
        }

        public async Task<List<InventoryItemSummary>> GetInventoryItemSummaryBalance(DateTime fromDate, DateTime toDate)
        {
            Task getRefTypeDictionaryTask = GetRefTypeDictionary();

            //DateTime.Now trả về 01/01/2024 16:44:23 (bao gồm cả thời gian)
            //nên nếu giữ nguyên thì giá trị 01/01/2024 15:44:23 vẫn ăn vào
            fromDate = fromDate.ToStartOfDate();
            toDate = toDate.ToEndOfDate();

            MisaDbContext.AAMisaDbContext context = new();
            var inventoryLedger = context.InventoryLedgers.AsNoTracking();

            //lấy dữ liệu số dư đầu kỳ với điều kiện PostedDate < fromDate
            var opening = context.InventoryLedgers
                .AsNoTracking()
                .Where(x => x.PostedDate < fromDate)
                .GroupBy(x => new { x.InventoryItemCode, x.StockCode })
                .Select(group => new InventoryItemSummary
                {
                    InventoryItemCode = group.Key.InventoryItemCode,
                    StockCode = group.Key.StockCode ?? string.Empty,
                    OpeningQuantity = group.Sum(x => x.InwardQuantity ?? decimal.Zero) - group.Sum(x => x.OutwardQuantity ?? decimal.Zero),
                    OpeningAmount = group.Sum(x => x.InwardAmount) - group.Sum(x => x.OutwardAmount)
                }).AsEnumerable();
            //.ToList();

            await getRefTypeDictionaryTask.ConfigureAwait(false);

            //lấy dữ liệu nhập xuất kho trong khoảng thời gian fromDate - toDate
            var inOutWard = inventoryLedger.ToArray()
                .Where(x => GetRefTypeName(x.RefType).Equals(INWARD) || GetRefTypeName(x.RefType).Equals(OUTWARD))
                .Where(x => x.PostedDate >= fromDate && x.PostedDate <= toDate)
                .GroupBy(x => new { x.InventoryItemCode , x.StockCode})
                .Select(group => new InventoryItemSummary
                {
                    InventoryItemCode = group.Key.InventoryItemCode,
                    StockCode = group.Key.StockCode ?? string.Empty,
                    InQuantity = group.Sum(x => x.InwardQuantity ?? decimal.Zero),
                    InAmount = group.Sum(x => x.InwardAmount),
                    OutQuantity = group.Sum(x => x.OutwardQuantity ?? decimal.Zero),
                    OutAmount = group.Sum(x => x.OutwardAmount)
                });

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
                        UnitId = (Guid)y.UnitId,
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


    }
}
