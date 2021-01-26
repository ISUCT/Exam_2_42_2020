using System;

namespace CourseApp
{
    public class Program
    {
        public static int MaximumElement(int[] a, int n)
        {
            int max = -101;
            for (int j = 0; j < n; j++)
            {
                if (a[j] > max)
                {
                    max = a[j];
                }
            }

            Console.WriteLine($"Максимальный элемент последовательности из {n} равен = {max}");
            return max;
        }

        public static void Main(string[] args)
        {
            int n = 10;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                a[i] = random.Next(-100, 100);
                Console.WriteLine(a[i]);
            }

            MaximumElement(a, n);
        }
    }
}
