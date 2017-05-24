using System;

namespace CPosNegZero
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -5; i <= 5; i++)
            {
                if (i < 0)
                {
                    Console.WriteLine("Testing " + i + ": Negative");
                }
                else
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Testing " + i + ": No Sign");
                    }
                    else
                    {
                        Console.WriteLine("Testing " + i + ": Positive");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
