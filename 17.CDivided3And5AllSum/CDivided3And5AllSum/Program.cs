using System;

namespace CDivided3And5AllSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            for (; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Your Total Ans: " + sum);
            Console.ReadKey();
        }
    }
}
