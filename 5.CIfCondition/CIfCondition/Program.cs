
using System;

namespace CIfCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 6;
            if (firstNumber > secondNumber)   //Condition is true
            {
                Console.WriteLine("First Number is gretter than Second Number");
            }
            if (firstNumber < secondNumber)    //Condition is false
            {
                Console.WriteLine("First Number is less than Second Number");
            }
            Console.ReadKey();
        }
    }
}
