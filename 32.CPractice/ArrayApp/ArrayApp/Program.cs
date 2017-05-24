using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6];
            myArray[0] = 12;
            myArray[1] = 10;
            myArray[3] = 33;
            myArray[5] = 100;
            myArray[4] = 77;
            myArray[2] = 88;
            //myArray[6] = 3333;                 //Overfolw Data because of my Array SIze is 6

            Console.WriteLine("My Array Length is="+myArray.Length);
            Console.WriteLine("myArray[3] position Value="+myArray[3]);

            Console.WriteLine("===for Loop with Sorted===");
            Array.Sort(myArray);
            for (int item = 0; item < myArray.Length; item++)
            {
                Console.WriteLine(myArray[item]);
            }

            Console.WriteLine("===FOreEach Loop with Reverse===");
            Array.Reverse(myArray);
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
                
            Console.ReadKey();

        }
    }
}
