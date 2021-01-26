using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            string[] carList = { "Toyota", "Lexus", "BMW", "Nissan", "Skoda", "Bentley", "Audi", "Renault", "Kia", "Chevrolet", "Cadillac", "Jeep", "Hyundai", "Mazda", "Jaguar" };
            Car veh = new Car(carList[random.Next(0, carList.Length)]);
            veh.Start();
            veh.Drive(5);
            veh.Drive(7);
            veh.Stop();
            veh.Stop();
            veh.Drive(1);
        }
    }
}
