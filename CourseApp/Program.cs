using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Summator plus = new Summator(3, 5);
            Console.WriteLine(plus.Summ());
        }
    }
}
