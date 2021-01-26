using System;
using Xunit;

namespace CourseApp.Tests
{
    public class Test
    {
        [Fact]
        public void Drive()
        {
            Car newvehicle = new Car("carname");
            int testdistance = 5 * 60; // 300
            newvehicle.Start();
            int result = newvehicle.Drive(5);
            Assert.Equal(testdistance, result); // 300 == the distance driven or not
        }

        [Fact]
        public void Start()
        {
            Car newvehicle = new Car("carname");
            newvehicle.Start();
            bool tocheck = true;
            Assert.Equal(tocheck, newvehicle.EngineState);
        }

        [Fact]
        public void Stop()
        {
            Car newvehicle = new Car("carname");
            newvehicle.Stop();
            bool tocheck = false;
            Assert.Equal(tocheck, newvehicle.EngineState);
        }
    }
}