using System;

namespace CMethodWithCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Two integer Value:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Total Addition=" + Addition(firstNumber, secondNumber) + " ");
            Console.WriteLine("Your Total Multipilication=" + Multiplication(firstNumber, secondNumber));
            Console.WriteLine("Your Total Substractor=" + Substractor(firstNumber, secondNumber));
            Console.WriteLine("Your Total  Divition=" + Divition(firstNumber, secondNumber));
            Console.ReadKey();
        }
        static int Addition(int firstNumber, int secondNumber)
        {
            int totalResult = firstNumber + secondNumber;
            return totalResult;
        }
        static int Multiplication(int firstNumber, int secondNumber)
        {
            int totalResult = firstNumber * secondNumber;
            return totalResult;
        }
        static int Substractor(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                int totalResult = firstNumber - secondNumber;
                return totalResult;

            }
            else
            {
                int totalResult = secondNumber - firstNumber;
                return totalResult;
            }
        }
        static double Divition(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                double totalResult = firstNumber / secondNumber;
                return totalResult;
            }
            else
            {
                double totalResult = secondNumber / firstNumber;
                return totalResult;
            }
        }
    }
}
