using System;
using Xunit;

namespace PatHead.Basic.Util.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
        }
    }
}