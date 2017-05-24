using System;

namespace CArrayIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[5];
            myIntArray[0] = 50;
            myIntArray[1] = 12;
            myIntArray[2] = 17;
            myIntArray[3] = 2;
            myIntArray[4] = 40;
            myIntArray[2] = 200;
            Array.Sort(myIntArray);                  //Before Sort than Reverse myArray
            Array.Reverse(myIntArray);
            Console.WriteLine("Length= " + myIntArray.Length);

            Console.WriteLine("--For Loop--");
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine(myIntArray[i]);
            }

            Console.WriteLine(" -- foreach loop--");
            foreach (int i in myIntArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
