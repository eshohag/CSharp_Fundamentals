using System;

namespace CLowerLimitToUpperLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lower Limit Input Value: ");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upper Limit Input Value: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Your Result for Lower Limit to Upper Limit:");
            for (; lowerLimit <= upperLimit; lowerLimit++)
            {
                Console.WriteLine(lowerLimit);
            }


            //Console.WriteLine("Your Result for Upper Limit to Lower Limit:");
            //for (int i = upperLimit; i >= lowerLimit; i--)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadKey();
        }
    }
}
