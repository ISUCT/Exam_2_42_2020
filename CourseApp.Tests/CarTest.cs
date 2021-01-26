using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CarTest
    {
        [Fact]
        public void TestModel()
        {
            string s = "model";
            Car actualResult = new Car(s);
            string exp = s;
            Assert.Equal(exp, actualResult.Model);
        }

        [Fact]
        public void TestStart()
        {
            Car actualResult = new Car("m");
            actualResult.Start();
            bool exp = true;
            Assert.Equal(exp, actualResult.Engine);
        }

        [Fact]
        public void TestStop()
        {
            Car actualResult = new Car("m");
            actualResult.Stop();
            bool exp = false;
            Assert.Equal(exp, actualResult.Engine);
        }
    }
}
