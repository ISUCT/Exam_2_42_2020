using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(0, 0, 0, 1)]
        [InlineData(3, 2, 0, -5)]
        [InlineData(3, 2, 1, -2)]
        [InlineData(3, 2, 5, 10)]
        public void TestCalcAllZeros(double a, double b, double x, double exp)
        {
            var actualResult = Program.Calc(a, b, x);
            Assert.Equal(exp, actualResult, 3);
        }
    }
}
