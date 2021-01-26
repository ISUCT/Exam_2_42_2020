using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Program
    {
        public static void Main()
        {
            Game game = new Game();
            Console.WriteLine(Game.Play(1, 1));
            Console.WriteLine(Game.Play(1, 2));
            Console.WriteLine(Game.Play(1, 3));
            Console.WriteLine(Game.Play(5, 5));
        }
    }
}
