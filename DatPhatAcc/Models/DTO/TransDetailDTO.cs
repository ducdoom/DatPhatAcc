namespace DatPhatAcc.Models.DTO
{
    public class TransDetailDTO
    {
        public string TransactionId { get; set; } = string.Empty;
        public string GoodId { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public decimal Price => TotalPrice / Quantity;
        public decimal TotalPrice => TotalPriceVat / (1 + VatValue / 100);
        public int VatValue { get; set; } = 0;
        public decimal TotalPriceVat { get; set; } = decimal.Zero;
    }
}
