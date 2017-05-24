using System;

namespace CDisplayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value\tSquared\tCubed\tPower-4");
            int i = 1;
            for (; i < 10; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", i, i * i, i * i * i, i * i * i * i);
            }
            for (int j = 10; j <= 20; j++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", j, j * j, j * j * j, j * j * j * j);
            }
            Console.ReadKey();
        }
    }
}
