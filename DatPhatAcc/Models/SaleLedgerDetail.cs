using DatPhatAcc.MisaDbContext;

namespace DatPhatAcc.Models
{
    public class SaleLedgerDetail
    {
        public string ? InvNo { get; set; }
        public string? InventoryItemCode { get; set; }
        public string? InventoryItemName { get; set; }
        public Guid? UnitId { get; set; }
        public string UnitName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public decimal SaleQuantity { get; set; }
        public decimal SaleAmount { get; set; }
        public decimal? Vatrate { get; set; }
        public string VatName => Vatrate switch
        {
            0 => "0%",
            5 => "5%",
            8 => "8%",
            10 => "10%",
            _ => "Không chịu thuế"
        };
        public decimal Vatamount { get; set; }
    }
}
