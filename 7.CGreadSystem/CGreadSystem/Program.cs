using System;

namespace CGreadSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Inpout Your mark");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark >= 0 && mark <= 39)
            {
                Console.WriteLine("Your Grade is F");
            }
            else if (mark >= 40 && mark <= 49)
            {
                Console.WriteLine("Your Grade is D");
            }
            else if (mark >= 50 && mark <= 59)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (mark >= 60 && mark <= 69)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (mark >= 70 && mark <= 79)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("Your Grade is A+");
            }
            else
            {
                Console.WriteLine("Invalid Marks");
            }
            Console.ReadKey();
        }
    }
}
