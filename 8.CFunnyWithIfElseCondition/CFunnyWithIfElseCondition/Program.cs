using System;

namespace CFunnyWithIfElseCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Name?");
            String Name1 = Console.ReadLine();
            Console.WriteLine("Please Enter your Age:");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            if (yourAge < 18)
            {
                Console.WriteLine("\n\n You are a Junior Chaild, Not Adult \n We are So Sorry " + Name1);
            }
            else
            {
                Console.WriteLine("You are adult");
                Console.WriteLine("  Do you Like Sex? \n  Please Your Ans 1 or 0");
                int aggre = Convert.ToInt32(Console.ReadLine());

                if (aggre == 1)
                {
                    Console.WriteLine("You are a Bad Boy " + Name1);
                    Console.WriteLine("I am suggest Porn Star Name \n 1.SunnyLeon \n 2.Mia-Kholifa");

                    Console.WriteLine("Sunnyleon Details press 1 Or Mia-Khalifa Details press 0");
                    int detailsSunny = Convert.ToInt32(Console.ReadLine());
                    if (detailsSunny == 1)
                    {
                        Console.WriteLine("Detais of Sunny Leon\nAge=33\nHeight=6fet\nContact:0192635436789");
                    }
                    else
                    {
                        Console.WriteLine("Detais of Mia_kholifa\nAge=33\nHeight=6fet\nContact:0192635436789");
                    }
                }
                else
                {
                    Console.WriteLine("You are a good Boy " + Name1);
                }

            }
            Console.ReadKey();
        }
    }
}
