using System;

namespace PatternThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number of Star:");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = number - 1;
            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            count = 1;

            for (int s = 1; s <= number - 1; s++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count++;
                for (int i = 1; i <= 2 * (number - s) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
