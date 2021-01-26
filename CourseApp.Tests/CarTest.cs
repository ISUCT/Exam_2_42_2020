using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CarTest
    {
        [Fact]
        public void TestStart()
        {
            Car actualResult = new Car();
            string exp = "машина запускается";
            Assert.Equal(exp, actualResult.Start());
        }

       [Fact]
        public void TestStop()
        {
            Car actualResult = new Car();
            string exp = "машина останавливается";
            Assert.Equal(exp, actualResult.Stop());
        }

        [Fact]
        public void TestDrive()
        {
            Car actualResult = new Car();
            int exp = 420;
            Assert.Equal(exp, actualResult.Drive(7));
        }
    }
}
