
using System;

namespace CMakeEven
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort num, i;
            for (i = 1; i <= 10; i++)
            {
                num = i;
                Console.WriteLine("Number is: " + num);
                num = (ushort)(num & 0xFFFE);
                Console.WriteLine("Number after Turning off bit zero:" + num);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
