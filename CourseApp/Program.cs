using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
          LengthConverter izmerenie = new LengthConverter();
          Console.WriteLine(izmerenie.TransferKilometrov(4));
        }
    }
}
