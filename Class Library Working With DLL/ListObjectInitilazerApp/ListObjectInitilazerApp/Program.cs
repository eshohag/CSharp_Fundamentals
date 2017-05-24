using System;
using System.Collections.Generic;

namespace ListObjectInitilazerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> CarList = new List<Car>()
            {
                new Car(){Name = "Nishan",Model = "A1-001",VIN = "V1"},
                new Car(){Name = "BMW",Model = "A1-002",VIN = "V2"},
                new Car(){Name = "Lambergini",Model = "A1-003",VIN = "V3"},
            };
            foreach (var Car in CarList)
            {
                Console.WriteLine(Car.Name + " " + Car.Model + " " + Car.VIN);
            }
            Console.ReadKey();
        }
    }

    class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }

    }
}
