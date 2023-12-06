using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Models.DTO
{
   public class TransactionOverview
    {
        public string TransactionId { get; set; } = string.Empty;
        public string TranDate { get; set; } = string.Empty;
        public DateTime TransactionDate => DateTime.ParseExact(TranDate, "yyyyMMdd", null);

        public decimal? TotalPriceVat { get; set; } = 0;
    }
}
