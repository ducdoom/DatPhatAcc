using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Models
{
    public record InventoryItemSummary
    {
        public string InventoryItemCode { get; set; } = string.Empty;
        public string InventoryItemName { get; set; } = string.Empty;
        public string UnitName { get; set; } = string.Empty;
        public decimal OpeningQuantity { get; set; } = 0;
        public decimal OpeningAmount { get; set; } = 0;
        public decimal InQuantity { get; set; } = 0;
        public decimal InAmount { get; set; } = 0;
        public decimal OutQuantity { get; set; } = 0;   
        public decimal OutAmount { get; set; } = 0;
        public decimal ClosingQuantity => OpeningQuantity + InQuantity - OutQuantity;
        public decimal ClosingAmount => OpeningAmount + InAmount - OutAmount;

    }
}
