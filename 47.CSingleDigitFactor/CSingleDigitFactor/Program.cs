using System;

namespace CSingleDigitFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 12; i < 50; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine("Smallest factor of " + i + " is 2");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Smallest factor of " + i + " is 3");
                }
                else if ((i % 4) == 0)
                {
                    Console.WriteLine("Smallest factor of " + i + " is 4");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Smallest factor of " + i + " is 5");
                }
                else if ((i % 6) == 0)
                {
                    Console.WriteLine("Smallest factor of " + i + " is 6");
                }
                else if ((i % 7) == 0)
                {
                    Console.WriteLine("Smallest factor of " + i + " is 7");
                }
                else
                {
                    Console.WriteLine(i + " Is not Divisiable by 2,3,4,5,6,7 ");
                }
            }
            Console.ReadKey();
        }
    }
}
