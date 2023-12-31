namespace DatPhatAcc.Models.DTO
{
    public class RetailTranDetailDTO
    {
        public string GoodId { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public decimal ClosingQuantity { get; set; } = 0;

        public decimal Quantity { get; set; } = 0;

        public decimal Price { get; set; } = 0;

        public decimal TotalPrice { get; set; } = 0;

        public decimal DiscountAmount { get; set; } = 0;

        public decimal VatValue { get; set; } = 0;

        public decimal VatAmount { get; set; } = 0;

        public decimal TotalPriceVat { get; set; } = 0;
    }
}
