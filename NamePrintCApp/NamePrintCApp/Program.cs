using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePrintCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            Console.Write("Type your First Name: ");
            string firstName;
            firstName = Console.ReadLine();
            Console.Write("Type your Last Name: ");
            string lastName;
            lastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}",firstName,lastName);
            //Console.ReadKey();
            Console.ReadLine();
        }
    }
}
