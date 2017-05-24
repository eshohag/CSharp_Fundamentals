using System;

namespace PatternTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 16; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
