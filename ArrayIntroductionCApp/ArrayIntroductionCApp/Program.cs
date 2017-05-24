using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIntroductionCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int []numbersArray=new int[5];
            numbersArray[0] = 1;
            numbersArray[1] = 2;
            numbersArray[2] = 3;
            numbersArray[3] = 4;
            numbersArray[4] = 5;
           // numbersArray[5] = 6;      out of range my array size 

            //for (int i = 0; i < numbersArray.Length; i++)
            //{
            //    Console.WriteLine("Array position {0} values {1}",i,numbersArray[i]);
            //}
            foreach (var i in numbersArray)
            {
                //Console.WriteLine("Array position {0} values {1}", i, numbersArray[i]);
                Console.WriteLine("Array values "+i);

            }

            Console.WriteLine("\nSecond Array ");
            Console.WriteLine("------------ ");

            int[] numberArray = new[] {1, 2, 3, 4, 5, 6, 7, 8};

            foreach (var i in numberArray)
            {
                //Console.WriteLine("Array position {0} values {1}", i, numbersArray[i]);   Cann't find the possition 
                Console.WriteLine("Array values " + i);

            }
            Console.ReadKey();

        }
    }
}
