using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisaHelper.Models
{
    public class PurchaseImportData
    {
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        public string TransactionNumber => $"NK{DateTime.Now:yyyyMMddHHmmss}";

        public string InvoiceNumber { get; set; } = "0";

        public string TKKho = "1561";
        public string TKCongNo = "331";
        public string TKThueGTGT = "1331";

        public IList<ImportProduct> ImportProducts { get; set; } = new List<ImportProduct>();
    }
}
