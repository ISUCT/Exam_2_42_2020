using System;

namespace CourseApp
{
    public class LengthConverter
    {
        public double TransferKilometrov(double kilometr)
        {
            return kilometr / 1.609;
        }

        public double TransferMil(double mil)
        {
            return mil * 1.609;
        }
    }
}