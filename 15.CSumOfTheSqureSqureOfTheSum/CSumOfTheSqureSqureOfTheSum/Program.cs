using System;

namespace CSumOfTheSqureSqureOfTheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumSqure = 0;
            int squreSum = 0;
            int sum = 0;

            for (int i = 0; i <= 100; i++)
            {
                sumSqure += i * i;
                sum = sum + i;
                squreSum = sum * sum;
            }
            int difference = squreSum - sumSqure;
            Console.WriteLine("The Sum Squre is : " + sumSqure);
            Console.WriteLine("The Squre Sum  is : " + squreSum);
            Console.WriteLine("The Difference is : " + difference);
            Console.ReadKey();
        }
    }
}
