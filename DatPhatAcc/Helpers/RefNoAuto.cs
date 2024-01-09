using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Helpers
{
    public static class RefNoAuto
    {
        private const int LEADING_ZERO_NUMS = 8;

        public static string GetNewPurchaseRefNo()
        {
            DatPhatAcc.Properties.Settings.Default.PurchaseRefNo = DatPhatAcc.Properties.Settings.Default.PurchaseRefNo + 1;
            DatPhatAcc.Properties.Settings.Default.Save();
            DatPhatAcc.Properties.Settings.Default.Reload();

            int refNo = DatPhatAcc.Properties.Settings.Default.PurchaseRefNo;
            string refNoString = refNo.ToString("00000000");

            return refNoString;
        }

        public static string GetNewSaleRefNo()
        {
            DatPhatAcc.Properties.Settings.Default.SaleRefNo = DatPhatAcc.Properties.Settings.Default.SaleRefNo + 1;
            DatPhatAcc.Properties.Settings.Default.Save();
            DatPhatAcc.Properties.Settings.Default.Reload();

            int refNo = DatPhatAcc.Properties.Settings.Default.SaleRefNo;
            string refNoString = refNo.ToString("00000000");

            return refNoString;
        }
    }
}
