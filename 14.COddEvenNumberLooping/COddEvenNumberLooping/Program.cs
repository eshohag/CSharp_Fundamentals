using System;

namespace COddEvenNumberLooping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Number");
            int aNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Only Even Number Show between 1 to " + aNumber + ":");
            for (int i = 1; i <= aNumber; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Only Odd Number Show between 1 " + aNumber + ":");
            for (int i = 1; i <= aNumber; i++)
            {
                if (i % 2 == 0)
                {

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
