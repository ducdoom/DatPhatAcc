using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisaHelper.Models
{
    public class MisaVTHH
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;

        public string Unit { get; set; } = string.Empty;

        public string TK_KHO { get; set; } = "1561";
        public string TK_DOANHTHU { get; set; } = "5111";
        public string TK_CHIETKHAU { get; set; } = "5211";
        public string TK_GIAM_GIA { get; set; } = "5213";
        public string TK_TRA_LAI { get; set; } = "5212";
        public string TK_CHI_PHI { get; set; } = "632";
    }
}
