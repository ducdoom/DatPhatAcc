using DatPhatAcc.Converters;
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

        public void InitRefTypeDictionary()
        {
            if (refTypeDictionary.Count > 0)
            {
                return;
            }

            MisaDbContext.AAMisaDbContext context = new();
            var searchRefTypes = context.SearchRefTypes.ToArray();

            foreach (var item in searchRefTypes)
            {
                foreach (string type in item.RefType.Split(','))
                {
                    refTypeDictionary[type] = item.RefTypeName;
                }
            }
        }

        private Dictionary<string, string> refTypeDictionary = new();

        public async Task<List<InventoryItemSummary>> GetInventoryItemSummaryBalance(DateTime fromDate, DateTime toDate)
        {
            InitRefTypeDictionary();

            MisaDbContext.AAMisaDbContext context = new();
            var inventoryLedgers = await context.InventoryLedgers.ToArrayAsync().ConfigureAwait(false);

            //DateTime.Now trả về 01/01/2024 16:44:23 (bao gồm cả thời gian)
            //nên nếu giữ nguyên thì giá trị 01/01/2024 15:44:23 vẫn ăn vào
            fromDate =  fromDate.ToStartOfDate();
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
                    OpeningQuantity = itemOpn.EndingQuantity,
                    OpeningAmount = itemOpn.EndingAmount
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

            return inventoryItemSummaries;
        }


        public string GetRefTypeName(int refType)
        {
            string refTypeName = string.Empty;
            _ = refTypeDictionary.TryGetValue(refType.ToString(), out refTypeName);
            if (refTypeName is null)
            {
                return "Not Found";
            }

            return refTypeName;
        }


    }
}
