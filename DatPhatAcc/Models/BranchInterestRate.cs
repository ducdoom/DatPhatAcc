namespace DatPhatAcc.Models
{
    public class BranchInterestRate
    {
        public string BranchId { get; set; } = string.Empty;

        public string BranchName { get; set; } = string.Empty;

        public decimal RetailInterestRate { get; set; } = 0;
        public decimal WholeSaleInterestRate { get; set; } = 0;
    }
}
