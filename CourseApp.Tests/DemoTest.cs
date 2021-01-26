using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(-10.8, 12.56, 'F')]
        [InlineData(0, 32, 'F')]
        [InlineData(100.4, 38, 'C')]
        [InlineData(0, -17.78, 'C')]

        public void TestOfTemperatureConverter(double temperature, double exp, char convertTo)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            Assert.Equal(exp, temperatureConverter.ConvertTemp(temperature, convertTo));
        }
    }
}
