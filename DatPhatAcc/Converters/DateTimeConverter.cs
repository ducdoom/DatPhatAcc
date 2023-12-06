using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Converters
{
    public static class DateTimeConverter
    {
        public static string ToTranDate(this DateTime dateTime)
        {
            return dateTime.ToString("yyyyMMdd");
        }
    }
}
