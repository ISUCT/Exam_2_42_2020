using System;

namespace CourseApp
{
    public class Program
    {
        public static int CalcMax(int[] mass)
        {
            Array.Sort(mass);
            int max = mass[mass.Length - 1];
            return max;
        }

        public static void Main(string[] args)
        {
            int[] array = { 5, 10, 6, 4, 20, 1, 2, 7, 100, -999 };
            Console.WriteLine(CalcMax(array));
            Console.ReadLine();
        }
    }
}
