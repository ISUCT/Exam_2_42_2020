using System;

namespace CourseApp
{
    public class Summator
    {
            public Summator()
            : this(0)
            {
            }

            public Summator(int x)
            : this(x, 0)
            {
            }

            public Summator(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get; set; }

            public int Y { get; set; }

            public int Summ()
            {
                return X + Y;
            } 
    }
}