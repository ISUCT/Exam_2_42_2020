using System;

namespace CourseApp
{
    public class LengthConverter
    {
        public double TransferKilometrov(double kilometr)
        {
            if (kilometr < 0)
            {
            Console.WriteLine("0");
             return 0;
            }

            return kilometr / 1.609;
        }

        public double TransferMil(double mil)
        {
            if (mil < 0)
            {
            Console.WriteLine("0");
             return 0;
            }

            return mil * 1.609;
        }
    }
}