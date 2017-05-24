using System;

namespace CWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            double aNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your Looping Result:");
            while (aNumber <= 30)
            {
                Console.WriteLine(aNumber);
                aNumber++;
            }
            Console.ReadKey();
        }
    }
}
