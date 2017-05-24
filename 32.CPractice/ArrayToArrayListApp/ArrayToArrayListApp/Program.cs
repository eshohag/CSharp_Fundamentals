using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] myStringArray = new string[2];
            //myStringArray[0] = "G";
            //myStringArray[1] = "L";

            //ArrayList myArrayList = new ArrayList();
            //myArrayList.AddRange(myStringArray);
            //foreach (string i in myArrayList)
            //{
            //    Console.WriteLine(i);
            //}


            // Array of ints.
            int[] arrayOfInts = new int[] { 10, 3, 33, 20, 56 };

            // Initialize array list.
            ArrayList arrayListOfInts = new ArrayList();

            // Add the items to array list.
            arrayListOfInts.AddRange(arrayOfInts);

            // Iterate and print the items in the array list.
            foreach (int obj in arrayOfInts)
            {
                Console.WriteLine(obj);
            }





            
            Console.ReadKey();

        }
    }
}
