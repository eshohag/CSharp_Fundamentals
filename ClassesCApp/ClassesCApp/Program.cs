using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car aCar = new Car();                                //This is the Class 
            //aCar.Name = "Toyota Camry";
            //aCar.Model = "L-005";
            //aCar.Color = "Pink";
            //aCar.Year = "2013";

            //Console.WriteLine("Brand Name {0}, Model No {1}, Color {2},  Maufacturing Year {3} & Market Value {4:C}", aCar.Name, aCar.Model, aCar.Color, aCar.Year, aCar.DeterminMarketValue());









            //Data initialization step 1:
            Car oneCare = new Car() { Name = "Lamborghini Aventador", Model = "L-001", Color = "Red", Year = "2015" };
            Car twoCare = new Car() { Name = " Acura", Model = "L-002", Color = "Yello", Year = "2014" };
            Car threeCare = new Car() { Name = "BMW", Model = "L-003", Color = "Black", Year = "2013" };
            Car fourCar = new Car() { Name = "Audi", Model = "L-004", Color = "Silver", Year = "2012" };

            //Data initialization step 2:
            Car fiveCar = new Car();
            fiveCar.Name = "Toyota Camry";
            fiveCar.Model = "L-005";
            fiveCar.Color = "Pink";
            fiveCar.Year = "2011";

            //Add to list Items into CarList
            List<Car> carList = new List<Car>();
            carList.Add(oneCare);
            carList.Add(threeCare);
            carList.Add(twoCare);
            carList.Add(fourCar);
            carList.Add(fiveCar);

            //Display Data by foreach loop:
            //foreach (var car in carList)
            //{
            //    Console.WriteLine("Brand Name {0}, Model No {1}, Color {2},  Maufacturing Year {3} & Market Value {4:C}", car.Name, car.Model, car.Color, car.Year,car.DeterminMarketValue());

            //}

            for (int i = 0; i < carList.Count; i++)
            {
                //Console.WriteLine(carList[i].Name);
                Console.WriteLine("Brand Name {0}, Model No {1}, Color {2},  Maufacturing Year {3} & Market Value {4:C}", carList[i].Name, carList[i].Model, carList[i].Color, carList[i].Year, carList[i].DeterminMarketValue());
            }


            //Caught the black screen display
            Console.ReadKey();
        }      
    }
}
