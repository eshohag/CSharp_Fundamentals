using System;

namespace CSummationAllNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your intger Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Your total Summation is " + sum);
            Console.ReadKey();
        }
    }
}
