using System;

namespace PatHead.Basic.Util.TypeExtensions
{
    /// <summary>
    /// dateTime extensions
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// ToTimeStamp
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="millisecond"></param>
        /// <returns></returns>
        public static long ToTimeStamp(this DateTime dateTime, bool millisecond = true)
        {
            var dateTimeOffset = new DateTimeOffset(dateTime);
            return millisecond ? dateTimeOffset.ToUnixTimeMilliseconds() : dateTimeOffset.ToUnixTimeSeconds();
        }

        /// <summary>
        /// ToDateTime
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <param name="timeZone">default Local</param>
        /// <param name="millisecond"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static DateTime ToDateTime(this long timeStamp, TimeZoneInfo timeZone = null, bool millisecond = true)
        {
            DateTime ConvertTimeZoneInfo(DateTimeOffset offset, TimeZoneInfo sideTimeZone)
            {
                if (sideTimeZone == null)
                {
                    sideTimeZone = TimeZoneInfo.Local;
                }

                return TimeZoneInfo.ConvertTime(offset, sideTimeZone).DateTime;
            }

            if (millisecond)
            {
                var dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(timeStamp);
                return ConvertTimeZoneInfo(dateTimeOffset, timeZone);
            }
            else
            {
                var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(timeStamp);
                return ConvertTimeZoneInfo(dateTimeOffset, timeZone);
            }
        }
    }
}