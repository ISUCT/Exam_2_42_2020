using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory;
            Console.WriteLine(TextReader.ReadLog(path));
        }
    }
}