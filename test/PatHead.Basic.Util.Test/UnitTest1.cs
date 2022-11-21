using System;
using System.Collections.Generic;
using System.IO;
using PatHead.Basic.Util.TypeExtensions;
using Xunit;

namespace PatHead.Basic.Util.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var dateTime = DateTime.Now.ToTimeStamp().ToDateTime();
            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));


            var timeZoneInfo = TimeZoneInfo.Local;

            var findSystemTimeZoneById = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            var china = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");

            var utcTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("UTC");

            var timeOffset = new DateTimeOffset(DateTime.Now);

            var utcConvertTime = TimeZoneInfo.ConvertTime(timeOffset, utcTimeZoneInfo);

            var convertTime = TimeZoneInfo.ConvertTime(utcConvertTime, findSystemTimeZoneById);

            var convertTime1 = TimeZoneInfo.ConvertTime(convertTime, china);


            var dt = Convert.ToDateTime("2022-09-30 13:37:42");

            var dateTimeOffset = new DateTimeOffset(dt);

            var unixTimeMilliseconds = dateTimeOffset.ToUnixTimeMilliseconds();

            // var dateTime = DateTime.Now;
            //
            // var dateTimeOffset = new DateTimeOffset(dateTime);
            //
            // var unixTimeMilliseconds = dateTimeOffset.ToUnixTimeMilliseconds();
        }


        [Fact]
        public void TestFile()
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("我试试看这个好用不好用");
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin);

            FileHelper.CreateFile("", stream);
        }
    }
}