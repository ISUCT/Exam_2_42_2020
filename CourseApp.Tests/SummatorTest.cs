using System;
using Xunit;

namespace CourseApp.Tests
{
    public class SummatorTest
    {
        [Fact]
        public void TestX()
        {
            int x = 10;
            Summator actualResult = new Summator(x);
            int exp = x;
            Assert.Equal(exp, actualResult.X);
        }

        [Fact]
        public void TestY()
        {
            int y = 31;
            Summator actualResult = new Summator(y);
            int exp = y;
            Assert.Equal(exp, actualResult.Y);
        }

        [Theory]
        [InlineData(10, 31, 41)]
        [InlineData(50, 90, 140)]
        public void TestSumm(int x, int y, int z)
        {
            Summator actualResult = new Summator(x, y);
            int exp = z;
            Assert.Equal(exp, actualResult.Summ());
        }
    }
}
