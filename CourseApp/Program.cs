using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car machine = new Car("model");
            Console.WriteLine(machine.Start());
            Console.WriteLine(machine.Drive(9));
            Console.WriteLine(machine.Stop());
            Console.WriteLine(machine.Drive(9));
        }
    }
}
