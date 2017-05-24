using System;

namespace CPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive Number:");
            int aNumber = Convert.ToInt32(Console.ReadLine());
            int ans;
            for (int i = 2; i < aNumber / 2; i++)
            {
                ans = aNumber % i;
                if (ans == 0)
                {
                    Console.WriteLine(aNumber + " Isn't a Prime Number ");

                }
                else
                {
                    Console.WriteLine(aNumber + " Is a Prime Number");
                }
            }

            Console.ReadKey();
        }
    }
}
