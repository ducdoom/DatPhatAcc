namespace DatPhatAcc.Models
{
    public class BranchInterestRate
    {
        public BranchInterestRate()
        {
                
        }
        public BranchInterestRate(string branchId, string branchName, decimal retailInterestRate, decimal wholeSaleInterestRate)
        {
            BranchId = branchId;
            BranchName = branchName;
            RetailInterestRate = retailInterestRate;
            WholeSaleInterestRate = wholeSaleInterestRate;
        }

        public string BranchId { get; set; } = string.Empty;

        public string BranchName { get; set; } = string.Empty;

        public decimal RetailInterestRate { get; set; } = 0;
        public decimal WholeSaleInterestRate { get; set; } = 0;
    }
}
