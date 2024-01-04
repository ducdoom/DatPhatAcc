using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Helpers
{
    public static class ThanhCongAccountingHelper
    {
        public static string GetBranchFromGoodId(string goodId)
        {
            return goodId.Substring(0, 2);
        }
    }
}
