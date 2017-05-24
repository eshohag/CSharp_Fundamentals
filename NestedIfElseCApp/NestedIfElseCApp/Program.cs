using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfElseCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chose the number between 1 to 4: ");
            int userValue=Int32.Parse(Console.ReadLine());
            //if (userValue==1)
            //{
            //    string message = "You won a Lamborghini car!";
            //    Console.WriteLine(message);
            //}
            //else if (userValue==2)
            //{
            //    string message = "You won a Toyota car!";
            //    Console.WriteLine(message);
            //}
            //else if (userValue == 3)
            //{
            //    string message = "You won a Bicycle!";
            //    Console.WriteLine(message);
            //}
            //else
            //{
            //    string message = "You Lost Everything!";
            //    Console.WriteLine(message);
            //}




            string message;
            //message = (userValue == 1) ? "Lamborghini" : "Lost";
            if (userValue == 4)
            {
                message = "You won a Lamborghini car!";
            }
            else if (userValue == 2)
            {
                message = "You won a Toyota car!";
            }
            else if (userValue == 3)
            {
                message = "You won a Bicycle!";
            }
            else
            {
                message = "You Lost Everything!";
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
