using System;

namespace COddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Your Number Check odd or Even number");
            int aNumber = Convert.ToInt32(Console.ReadLine());
            if (aNumber % 2 == 0)
            {
                Console.WriteLine("Even Number " + aNumber);
            }
            else
            {
                Console.WriteLine("Odd Number " + aNumber);
            }
            Console.ReadKey();
        }
    }
}
