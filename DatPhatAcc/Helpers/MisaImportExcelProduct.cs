using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Helpers
{
    public class MisaImportExcelProduct
    {
        public string ProductId { get; set; } = string.Empty;
        public double Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;
        public double TotalPrice { get; set; } = 0;
        public double VatRate { get; set; } = 0;
        public double VatAmount { get; set; } = 0;
    }
}
