using System;

namespace CIfElseCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 7;
            if (firstNumber > secondNumber)    //Wrong Condition
            {
                Console.WriteLine("First Number is greater then Second Number");
            }
            else                                //True Condition
            {
                Console.WriteLine("Second Number is greatter than First Number");
            }
            Console.ReadKey();
        }
    }
}
