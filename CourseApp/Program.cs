using System;

namespace CourseApp
{
    public class Program
    {
        public static string[] ReadTextFromFile() {
            string[] lines = System.IO.File.ReadAllLines("test.txt");
            string[] result = new string[lines.Length];

            int i = 0;
            foreach (var line in lines)
            {
                result[i] = $"{++i} - {line}";
                Console.WriteLine($"{i} - {line}");
            }

            return result;
        }
        public static void Main(string[] args)
        {
            ReadTextFromFile();
        }
    }
}
