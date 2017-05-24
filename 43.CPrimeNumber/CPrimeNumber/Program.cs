using System;

namespace CPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime;
            // int factor;
            for (int i = 2; i < 20; i++)
            {
                isPrime = true;
                // factor = 0;
                for (int j = 2; j < i / 2; j++)
                {
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                        // factor = i;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i + " is a Prime Number");
                }
            }

            Console.ReadKey();
        }
    }
}
