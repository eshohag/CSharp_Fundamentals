using System;

namespace PatternOne
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 16; i >= 1; i--)
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
