using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseStatementCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Integer Number: ");
            //int j = Int32.Parse(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < j; i++)
            {
                switch (i)
                {
                    case 2:
                        Console.WriteLine("This the number Of Exact {0} & binary number is {1}", 2, 10);
                        break;
                    case 4:
                        Console.WriteLine("This the number Of Exact {0} & binary number is {1}", 4, 100);
                        break;
                    case 8:
                        Console.WriteLine("This the number Of Exact {0} & binary number is {1}", 8, 1000);
                        break;
                    default:
                        count += 1;
                        break;
                }
            }
            Console.WriteLine("The Total number of Default case Count is {0} only", count);
            Console.ReadKey();
        }
    }
}
