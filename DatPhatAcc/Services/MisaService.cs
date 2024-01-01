using DatPhatAcc.Converters;
using DatPhatAcc.MisaDbContext;
using DatPhatAcc.Models;
using DevExpress.Utils.Text;
using Microsoft.EntityFrameworkCore;

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
                return new();
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

            MisaDbContext.AAMisaDbContext context = new();
            var inventoryLedgers = await context.InventoryLedgers.AsNoTracking().ToArrayAsync().ConfigureAwait(false);

            //DateTime.Now trả về 01/01/2024 16:44:23 (bao gồm cả thời gian)
            //nên nếu giữ nguyên thì giá trị 01/01/2024 15:44:23 vẫn ăn vào
            fromDate = fromDate.ToStartOfDate();
            toDate = toDate.ToEndOfDate();

            //lấy dữ liệu số dư đầu kỳ với điều kiện PostedDate < fromDate
            List<InventoryItemSummary> opening = inventoryLedgers
                .Where(x => x.PostedDate < fromDate)
                .GroupBy(x => x.InventoryItemCode)
                .Select(group => new InventoryItemSummary
                {
                    InventoryItemCode = group.Key,
                    InQuantity = group.Sum(x => x.InwardQuantity ?? decimal.Zero),
                    InAmount = group.Sum(x => x.InwardAmount),
                    OutQuantity = group.Sum(x => x.OutwardQuantity ?? decimal.Zero),
                    OutAmount = group.Sum(x => x.OutwardAmount)
                })
                .ToList();

            await getRefTypeDictionaryTask.ConfigureAwait(false);

            //lấy dữ liệu nhập xuất kho trong khoảng thời gian fromDate - toDate
            List<InventoryItemSummary> inOutWard = inventoryLedgers
                .Where(x => GetRefTypeName(x.RefType).Equals(INWARD) || GetRefTypeName(x.RefType).Equals(OUTWARD))
                .Where(x => x.PostedDate >= fromDate && x.PostedDate <= toDate)
                .GroupBy(x => x.InventoryItemCode)
                .Select(group => new InventoryItemSummary
                {
                    InventoryItemCode = group.Key,
                    InQuantity = group.Sum(x => x.InwardQuantity ?? decimal.Zero),
                    InAmount = group.Sum(x => x.InwardAmount),
                    OutQuantity = group.Sum(x => x.OutwardQuantity ?? decimal.Zero),
                    OutAmount = group.Sum(x => x.OutwardAmount)
                })
                .ToList();

            //tính số dư đầu kỳ vào list inventoryItemSummaries
            List<InventoryItemSummary> inventoryItemSummaries = new();
            foreach (InventoryItemSummary itemOpn in opening)
            {
                InventoryItemSummary newItem = new()
                {
                    InventoryItemCode = itemOpn.InventoryItemCode,
                    OpeningQuantity = itemOpn.ClosingQuantity,
                    OpeningAmount = itemOpn.ClosingAmount
                };
                inventoryItemSummaries.Add(newItem);
            }

            //add thêm nhập xuất vào list inventoryItemSummaries
            foreach (InventoryItemSummary item in inOutWard)
            {
                InventoryItemSummary? inItem = inventoryItemSummaries.FirstOrDefault(x => x.InventoryItemCode.Equals(item.InventoryItemCode));
                if (inItem is not null)
                {
                    inItem.InQuantity += item.InQuantity;
                    inItem.InAmount += item.InAmount;
                    inItem.OutQuantity += item.OutQuantity;
                    inItem.OutAmount += item.OutAmount;
                }
                else
                {
                    inventoryItemSummaries.Add(item);
                }
            }

            //add tên hàng hóa vào list inventoryItemSummaries
            foreach (InventoryItemSummary item in inventoryItemSummaries)
            {
                InventoryItem? inventoryItem = InventoryItems().FirstOrDefault(x => x.InventoryItemCode.Equals(item.InventoryItemCode));
                if (inventoryItem is not null)
                {
                    item.InventoryItemName = inventoryItem.InventoryItemName;
                }
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
