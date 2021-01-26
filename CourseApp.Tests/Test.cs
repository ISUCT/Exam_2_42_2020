using System;
using Xunit;

namespace CourseApp.Tests
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void AllZero()
        {
            int[] array = { 0, 0, 0 };
            var actualResult = Program.MaximumElement(array, 3);
            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void IdenticalValues()
        {
            int[] array = { 10, 10, 10 };
            var actualResult = Program.MaximumElement(array, 3);
            Assert.Equal(10, actualResult);
        }

        [Fact]
        public void NegativeValues()
        {
            int[] array = { -30, -20, -10 };
            var actualResult = Program.MaximumElement(array, 3);
            Assert.Equal(-10, actualResult);
        }
    }
}