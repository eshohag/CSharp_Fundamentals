using System;

namespace CMthodFunctionCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Your Second Name:");
            string lName = Console.ReadLine();
            Console.WriteLine(FullName(fName, lName));

            Console.WriteLine("Enter Your First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Your Second Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(FullName(firstName, lastName));
            Console.ReadKey();

        }

        static string FullName(string fName, string lName)
        {
            return fName + " " + lName;
        }
    }
}
