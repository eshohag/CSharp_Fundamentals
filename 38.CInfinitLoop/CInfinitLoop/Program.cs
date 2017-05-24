using System;

namespace CInfinitLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Shohag");
                while (i == 1000)
                {
                    Console.WriteLine("Completed Task write Name 1000 times");
                    goto EndWhile;
                }
            }
        EndWhile: ;
            Console.ReadKey();
        }
    }
}
