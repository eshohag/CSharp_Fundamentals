using System;

namespace CCastsExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            for (i = 1.0; i < 10; i++)
            {
                Console.WriteLine("The Squre root of {0} is {1}", i, Math.Sqrt(i));
                Console.WriteLine("The Whole number part: {0}", (int)Math.Sqrt(i));
                Console.WriteLine("The Fractional Number Part: {0}", Math.Sqrt(i) - (int)Math.Sqrt(i));
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
