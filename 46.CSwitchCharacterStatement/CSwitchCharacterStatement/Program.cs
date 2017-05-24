using System;

namespace CSwitchCharacterStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char latter = 'A'; latter <= 'E'; latter++)
            {
                switch (latter)
                {
                    case 'A':
                        Console.WriteLine("Latter is " + latter);
                        break;
                    case 'B':
                        Console.WriteLine("Latter is " + latter);
                        break;
                    case 'C':
                        Console.WriteLine("Latter is " + latter);
                        break;
                    case 'D':
                        Console.WriteLine("Latter is " + latter);
                        break;
                    case 'E':
                        Console.WriteLine("Latter is " + latter);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
