using System;

namespace CModulasOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter two number (Not String or Latter):");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            double remnder = 0;
            if (a > b)
            {
                result = a / b;
                remnder = a % b;
                Console.WriteLine("Result and Remainder of " + a + "/" + b + "\nResult-" + result + " Remainder-" + remnder);
            }
            else
            {
                result = b / a;
                remnder = b % a;
                Console.WriteLine("Result and Remainder of " + b + "/" + a + "\nResult-" + result + " Remainder-" + remnder);
            }
            Console.ReadKey();
        }
    }
}
