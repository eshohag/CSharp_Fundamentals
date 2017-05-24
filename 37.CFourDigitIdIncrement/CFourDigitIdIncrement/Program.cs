using System;

namespace CFourDigitIdIncrement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your 4 Digit Id :");
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("                 " + i.ToString("0000"));        //Which is the 4 digit Id Increment with for loop
            }
            Console.ReadKey();
        }
    }
}
