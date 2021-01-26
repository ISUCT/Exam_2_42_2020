using System;

namespace CourseApp
{
    public class Program
    {
        public static string Fight(int ninjas)
        {
            if (ninjas <= 0)
            {
                return "Куда делись ниндзя";
            }
            else if (ninjas < 10)
            {
                return "Я одолею этих ниндзя!";
            }
            else if (ninjas < 30)
            {
                return "Будет непросто, но я с ними разделаюсь";
            }
            else if (ninjas < 50)
            {
                return "Их слишком много";
            }

            return "Я погиб";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Fight(60));
            Console.WriteLine(Fight(49));
            Console.WriteLine(Fight(29));
            Console.WriteLine(Fight(9));
            Console.WriteLine(Fight(5));
            Console.ReadLine();
        }
    }
}
