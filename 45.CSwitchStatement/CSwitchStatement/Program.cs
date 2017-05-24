using System;

namespace CSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Value is Zero");
                        break;
                    case 1:
                        Console.WriteLine("Value is One");
                        break;
                    case 2:
                        Console.WriteLine("Value is Two");
                        break;
                    case 3:
                        Console.WriteLine("Value is Three");
                        break;

                }

            }
            Console.ReadKey();
        }
    }
}
