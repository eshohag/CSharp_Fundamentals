using System;

namespace CImplicationOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p = false, q = true;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i == 0)
                    {
                        p = true;
                    }
                    if (i == 1)
                    {
                        p = false;
                    }
                    if (j == 0)
                    {
                        q = true;
                    }
                    if (j == 1)
                    {
                        q = false;
                    }
                    Console.WriteLine("P is " + p + " , Q is " + q);
                    if (!p | q)
                    {
                        Console.WriteLine(p + " Implies " + q + " is " + true);
                    }
                    Console.WriteLine();

                }
            }
            Console.ReadKey();
        }
    }
}
