using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseConditionalStatmentCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Even Number: ");
            int aNumber=Int32.Parse(Console.ReadLine());
            if (aNumber==10)
            {
                Console.WriteLine("This Number is Exact {0}",aNumber);
            }
            else
            {
                Console.WriteLine("This Number is:"+aNumber);
            }
            Console.ReadKey();
        }
    }
}
