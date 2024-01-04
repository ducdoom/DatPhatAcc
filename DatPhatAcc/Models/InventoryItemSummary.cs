namespace DatPhatAcc.Models
{
    public record InventoryItemSummary
    {
        public string InventoryItemCode { get; set; } = string.Empty;
        public string InventoryItemName { get; set; } = string.Empty;
        public Guid UnitId { get; set; }
        public string UnitName { get; set; } = string.Empty;
        public string StockCode { get; set; } = string.Empty;
        public decimal OpeningQuantity { get; set; } = 0;
        public decimal OpeningAmount { get; set; } = 0;
        public decimal InQuantity { get; set; } = 0;
        public decimal InAmount { get; set; } = 0;
        public decimal OutQuantity { get; set; } = 0;
        public decimal OutAmount { get; set; } = 0;
        public decimal ClosingQuantity => OpeningQuantity + InQuantity - OutQuantity;
        public decimal ClosingAmount => OpeningAmount + InAmount - OutAmount;
        public decimal CostPriceUnit => ClosingQuantity == 0 ? 0 : ClosingAmount / ClosingQuantity;

    }
}
