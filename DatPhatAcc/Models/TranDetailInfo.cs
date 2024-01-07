namespace DatPhatAcc.Models
{
    public class TranDetailInfo
    {
        public string GoodId { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string StockCode { get; set; } = string.Empty;
        public string UnitId { get; set; } = string.Empty;
        public string UnitName { get; set; } = string.Empty;
         public decimal Quantity { get; set; } = 0;
        public decimal Price { get; set; } = 0;
        public decimal TotalAmount { get; set; } = 0;
        public decimal VatRate { get; set; } = 0;
        public decimal VatAmount { get; set; } = 0;
        public decimal TotalAmountVat { get; set; } = 0;
    }
}
