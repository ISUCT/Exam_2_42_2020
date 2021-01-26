using System;

namespace CourseApp
{
    public class Car
    {
        public Car(string name)
        {
            this.Name = name;
            EngineState = false;
        }

        public string Name { get; set; }

        public bool EngineState { get; set; }

        public void Start()
        {
            if (EngineState == false)
            {
                Console.WriteLine($"Двигатель {Name} успешно запущен");
                EngineState = true;
                return;
            }
            else
            {
                Console.WriteLine($"~ Двигатель {Name} уже запущен!");
                return;
            }
        }

        public void Stop()
        {
            if (EngineState == true)
            {
                Console.WriteLine($"Двигатель {Name} успешно остановлен");
                EngineState = false;
                return;
            }
            else
            {
                Console.WriteLine($"~ Двигатель {Name} сейчас не запущен!");
                return;
            }
        }

        public int Drive(int howlong)
        {
            if (EngineState == true)
            {
                int distance = howlong * 60;
                Console.WriteLine($"Автомобиль {Name} проехал {distance.ToString()} км. за {howlong.ToString()} единиц времени");

                // this.Stop();
                return distance;
            }
            else
            {
                Console.WriteLine($"~ Автомобиль {Name} не был запущен и остался на месте!");
                return 0;
            }
        }
    }
}