namespace DatPhatAcc.Models.DTO
{
    public class TransactionOverview
    {
        public string TransactionId { get; set; } = string.Empty;
        public string TransCode { get; set; } = string.Empty;
        public string TranDate { get; set; } = string.Empty;
        public DateTime TransactionDate => DateTime.ParseExact(TranDate, "yyyyMMdd", null);

        public decimal? TotalPriceVat { get; set; } = 0;
    }
}
