using System;

namespace PatHead.Basic.Util.TypeExtensions
{
    public static class DateTimeExtensions
    {
        public static long ToTimeStamp(this DateTime dateTime, bool millisecond = true)
        {
            var dateTimeOffset = new DateTimeOffset(dateTime);
            return millisecond ? dateTimeOffset.ToUnixTimeMilliseconds() : dateTimeOffset.ToUnixTimeSeconds();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <param name="timeZone">default Local</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static DateTime ToDateTime(this long timeStamp, TimeZoneInfo timeZone = null)
        {
            DateTime ConvertTimeZoneInfo(DateTimeOffset offset, TimeZoneInfo sideTimeZone)
            {
                if (sideTimeZone == null)
                {
                    sideTimeZone = TimeZoneInfo.Local;
                }

                return TimeZoneInfo.ConvertTime(offset, sideTimeZone).DateTime;
            }

            var s = timeStamp.ToString();
            switch (s.Length)
            {
                case 13:
                {
                    var dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(timeStamp);
                    return ConvertTimeZoneInfo(dateTimeOffset, timeZone);
                }
                case 10:
                {
                    var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(timeStamp);
                    return ConvertTimeZoneInfo(dateTimeOffset, timeZone);
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(timeStamp));
            }
        }
    }
}