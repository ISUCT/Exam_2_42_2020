using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void TestZeroMassive()
        {
            int[] massive = { 0, 0, 0 };
            var actualResult = Program.CalcMax(massive);
            var exp = 0;
            Assert.Equal(exp, actualResult);
        }

        [Fact]
        public void TestNormalMassive()
        {
            int[] massive = { 1, 8, 4, 9, 0, 18 };
            var actualResult = Program.CalcMax(massive);
            var exp = 18;
            Assert.Equal(exp, actualResult);
        }

        [Fact]
        public void TestNegativeMassive()
        {
            int[] massive = { -5, -8, -8, -14 };
            var actualResult = Program.CalcMax(massive);
            var exp = -5;
            Assert.Equal(exp, actualResult);
        }
    }
}
