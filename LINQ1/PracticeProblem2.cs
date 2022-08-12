using System.Linq;
using System;

namespace LINQ1
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }
    class PracticeProblem2
    {
        public static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
                new Car(){Cost = 56, MaxSpeed = 120},
                new Car(){Cost = 70, MaxSpeed = 150},
                new Car(){Cost = 45, MaxSpeed = 180},
                new Car(){Cost = 32, MaxSpeed = 200},
                new Car(){Cost = 82, MaxSpeed = 280},
            };

            var selected = from car in cars
                           where car.Cost < 60
                           orderby car.Cost ascending
                           select new { car.Cost, car.MaxSpeed};

            foreach(var i in selected)
            {
                Console.WriteLine($"{i.Cost}, {i.MaxSpeed}");
            }

        }
    }
}
