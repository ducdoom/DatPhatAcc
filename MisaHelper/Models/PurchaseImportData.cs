namespace MisaHelper.Models
{
    public class PurchaseImportData
    {
        private DateTime MISA_START_DATE = new(2024, 1, 1);
        public DateTime TransactionDate => DateTime.Now > MISA_START_DATE ? DateTime.Now : MISA_START_DATE;
        public string TransactionNumber => $"NK{DateTime.Now:yyyyMMddHHmmss}";
        public string InvoiceNumber { get; set; } = "0";
        public string TKKho = "1561";
        public string TKCongNo = "331";
        public string TKThueGTGT = "1331";
        public IList<ImportProduct> ImportProducts { get; set; } = new List<ImportProduct>();
    }
}
