using System;

namespace CFunctionWithGreadSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Integer Marks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GreadMarks(marks));
            Console.ReadKey();
        }
        static String GreadMarks(int marks)
        {
            if (marks >= 0 && marks < 50)
            {
                return "Your Gread is: F (" + marks + ")";
            }
            else if (marks >= 50 && marks < 60)
            {
                return "Your Gread is: C+(" + marks + ")";
            }
            else if (marks >= 60 && marks < 70)
            {
                return "Your Gread is: B+(" + marks + ")";
            }
            else if (marks >= 70 && marks < 80)
            {
                return "Your Gread is: A-(" + marks + ")";
            }
            else if (marks >= 80 && marks < 90)
            {
                return "Your Gread is: A(" + marks + ")";
            }
            else if (marks >= 90 && marks < 100)
            {
                return "Your Gread is: A+(" + marks + ")";
            }
            else
            {
                return "Your input value is Invalid \n Please Enter Integer value between 1 to 100";
            }

        }

    }
}
