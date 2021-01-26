using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Search search = new Search();
            double[] array = new double[10] { 10, 2, 4, 6, 8, 1, 3, 9, 1, 5 };
            Console.WriteLine(search.Searching(array));
            Console.Read();
        }
    }
}
