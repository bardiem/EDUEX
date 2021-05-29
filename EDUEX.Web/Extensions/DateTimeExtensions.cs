using System;

namespace EDUEX.Web.Extensions
{

    public static class DateTimeExtensions
    { 

        public static DateTime AddMinutesInInt(this DateTime source, int duration)
        {
            return source.Add(new TimeSpan(0, duration, 0));
        }
        public static int GetDuration(this DateTime date1, DateTime date2)
        {
            TimeSpan ts = date2 - date1;
            return Convert.ToInt32(ts.TotalMinutes);
            
        }
    }
}
