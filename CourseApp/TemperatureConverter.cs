using System;

namespace CourseApp
{
    public class TemperatureConverter
    {
        public double ConvertTemp (double temperature, char convertTo)
        {
            double answer = 0;
            switch (convertTo)
            {
                case 'F':
                answer = Math.Round(((9.0 / 5) * temperature) + 32, 2);
                break;
                case 'C':
                answer = Math.Round((temperature - 32) * (5.0 / 9), 2);
                break;
            }

            return answer;
        }
    }
}