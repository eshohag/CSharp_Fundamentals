using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterationCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("That is the EVEN Number is {0}",i);
                  
                }
                else
                {
                    Console.WriteLine("That is the Odd Number is {0}", i);
                 
                }
                
            }
            Console.Write("Input Your Number: ");

            int inputNumber=Int32.Parse(Console.ReadLine());
            Console.Write("Reverse String is :");
            for (;inputNumber>=0;inputNumber--)
            {
                Console.Write("  "+inputNumber);
            }
        

            Console.ReadKey();
        }
    }
}
