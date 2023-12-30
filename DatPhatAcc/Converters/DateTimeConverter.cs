using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatPhatAcc.Converters
{
    public static class DateTimeConverter
    {
        public static string ToTranDate(this DateTime dateTime)
        {
            return dateTime.ToString("yyyyMMdd");
        }

        public static DateTime ToStartOfDate(this DateTime dateTime)
        {
            return dateTime.Date;
        }

        public static DateTime ToEndOfDate(this DateTime dateTime)
        {
            return dateTime.Date.AddDays(1).AddSeconds(-1);
        }
    }

    
}
