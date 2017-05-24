using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCalculationCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber;   //Variable Declare
            int twoNumber;
            aNumber = 5;   //Variable Initialization  
            twoNumber = aNumber + 10;
            Console.WriteLine("This is The Result of {0} + 10 = {1}", aNumber,twoNumber);
            Console.ReadKey();

        }
    }
}
