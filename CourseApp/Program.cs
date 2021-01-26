using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car mch = new Car();
            Console.WriteLine(mch.Start());
            Console.WriteLine(mch.Drive(7));
            Console.WriteLine(mch.Stop());
        }
    }
}
