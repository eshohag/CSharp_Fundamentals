using System;

namespace CDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Result:");
            do
            {
                Console.WriteLine(number);
                number++;
                //number+=2;                number=number+2;
                ////number++;               number=number+1;
            }
            while (number < 30);

            Console.ReadKey();
        }
    }
}
