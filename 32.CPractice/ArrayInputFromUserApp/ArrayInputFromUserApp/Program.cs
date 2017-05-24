using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInputFromUserApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Array Size:");
            int arraY = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[arraY];
            Console.WriteLine("Please Enter Your " + arraY + " integer Array Data:");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Total Array Length= " + myArray.Length);

            Console.WriteLine("Your Sorted Array:");
            //Array.Resize(myArray);
            Array.Sort(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("Containes Value is 22");
            Console.WriteLine(myArray.Contains(22));

            Console.WriteLine("Enter Your value Matching in this Array: ");
            int maTching = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myArray.Contains(maTching));
           



            //int[] theArray = {1, 3, 5, 7, 9};
            ////for (int i = 0; i < theArray.Length; i++)
            ////{
            ////    Console.WriteLine(theArray[i]);
            ////}
            //foreach (int i in (theArray))
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadKey();
        }
    }
}
