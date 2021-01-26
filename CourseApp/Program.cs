using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            double temperature = -2.7;
            char convertTo = 'F';
            Console.WriteLine(temperatureConverter.ConvertTemp(temperature, convertTo));
        }
    }
}
