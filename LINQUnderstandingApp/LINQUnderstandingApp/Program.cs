using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQUnderstandingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database Data Start here..
            List<Car> allCars = new List<Car>()
            {
                new Car(){Name = "BMW",Model = "B-001",Price = 12000,Color = "Red"},
                new Car(){Name = "Nishan",Model = "N-001",Price = 11000,Color = "yello"},
                new Car(){Name = "BMW",Model = "BMW-002",Price = 15000,Color = "Black"},
                new Car(){Name = "Lamborghini ",Model = "L-001",Price = 19000,Color = "Red"},
                new Car(){Name = "Toyota",Model = "T-001",Price = 12000,Color = "Gray"},
                new Car(){Name = "BMW",Model = "BMW-003",Price = 12500,Color = "Red"},
            };
            //Database Data End here..

            //LINQ Query Start here...
            /* var MyAllCars = from aCar in allCars
                             where (
                                     aCar.Name == "BMW"
                                     ||                                      //OR Operator
                                     aCar.Price == 12000.00

                                     )

                                     &&

                                     (
                                         aCar.Price == 12000.00
                                         &&                                  //AND Operator
                                         aCar.Name == "Toyota"
                                     )
                             select aCar;                     
              foreach (var car in MyAllCars)
              {
                  Console.WriteLine("Care Brand Name {0}, Mode {1}, Price {2} && Color {3}", car.Name, car.Model, car.Price, car.Color);
              }

            */
            var MyAllCars = from aCar in allCars
                            where (aCar.Name == "BMW" || aCar.Price == 12000.00) && (aCar.Price == 12000.00 && aCar.Name == "Toyota")
                            //new feature added here
                            select new { aCar.Name, aCar.Price };  //return kortese matro two propertiy
            foreach (var car in MyAllCars)
            {
                Console.WriteLine("Care Brand-{0}----Price-{1}", car.Name, car.Price);
            }


            /*
              var orderCars = from car in allCars
                              orderby car.Price descending
                              // orderby car.Price descending
                              select car;

              foreach (var myCar in orderCars)
              {
                  Console.WriteLine(myCar.Name + " " + myCar.Price + " " + myCar.Model + " " + myCar.Color);
              }

           */









            //LINQ Methods Start Here...
            //var MyCars = allCars.Where(p => p.Name == "BMW" && p.Color == "Red");
            //foreach (var myCar in MyCars)
            //{
            //    Console.WriteLine(myCar.Name + " " + myCar.Price + " " + myCar.Model + " " + myCar.Color);
            //}


            /*
            var orederCars = allCars.OrderBy(p => p.Price);
            var orederCars = allCars.OrderByDescending(p => p.Price);

            foreach (var orderCar in orederCars)
            {
                Console.WriteLine(orderCar.Name + "-----" + orderCar.Price);
            }
            */


            /*
            var orderCars = allCars.OrderByDescending(p => p.Price).First(car => car.Name == "Toyota");
            Console.WriteLine(orderCars.Name + "---" + orderCars.Price);
            */


            /*
            allCars.ForEach(p => p.Price -= 1000);
            allCars.ForEach(p => Console.WriteLine("Car Name {0} & Model {1}----Price-{2:C}", p.Name, p.Model, p.Price));
            */

            /*
            var aCar = allCars.Exists(a => a.Price == 12000 && a.Color=="Red");
            Console.WriteLine(aCar);
            */


            // Console.WriteLine(allCars.Sum(p => p.Price));



            Console.ReadKey();
        }
    }
}
