using System;

namespace CourseApp
{
    public class Car
    {
            public Car()
            : this("Неизвестна")
            {
            }

            public Car(string model)
            {
                this.Model = model;
                Engine = false;
            }

            public string Model { get; set; }

            public bool Engine { get; set; }

            public string Start()
            {
                Engine = true;
                return $"{Model} заводится";
            }

            public string Stop()
            {
                Engine = false;
                return $"{Model} останавливается";
            }

            public int Drive(int howlong)
            {
                if (Engine)
                {
                    return howlong * 60;
                }
                else
                {
                    return 0;
                }
            }
    }
}