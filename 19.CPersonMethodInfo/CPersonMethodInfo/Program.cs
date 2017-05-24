using System;

namespace CPersonMethodInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(helloWorld() + " " + name + " & Age is " + age);
            Console.WriteLine(myAge(age));

            Console.ReadKey();
        }
        static string helloWorld()
        {
            return "Hello World";
        }

        static string myAge(int age)
        {
            if (age >= 18 && age <= 39)
            {
                return "Your are Adult person ";
            }
            else if (age >= 40 && age <= 100)
            {
                return "You are a old person";
            }
            else if (age >= 0 && age <= 17)
            {
                return "You are a Young man";
            }
            else
            {
                return "Invalid Your Age";
            }
        }

    }
}
