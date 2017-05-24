using System;

namespace CScopeWithIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Input Your Amount ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount == 1)
            {
                Console.WriteLine("Girl");
            }
            else if (amount == 2)
            {
                Console.WriteLine("She is a Pretty Girl");
            }

            else
            {
                Console.WriteLine("Not Found");
            }

            Console.ReadKey();
        }
    }
}
