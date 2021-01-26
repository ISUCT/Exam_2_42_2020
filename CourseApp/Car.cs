using System;

namespace CourseApp
{
    public class Car
    {
            public string Start() => "машина запускается";

            public string Stop() => "машина останавливается";

            public int Drive(int howlong)
            {
                    return howlong * 60;
            }
    }
}