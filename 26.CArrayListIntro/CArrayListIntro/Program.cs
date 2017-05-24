using System;
using System.Collections;

namespace CArrayListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            //Any Type Value Stored in this system of ArrayList
            myArrayList.Add(20);
            myArrayList.Add(23);
            myArrayList.Add(18);                        //myArrayList[0]
            myArrayList.Add("BITM");                    //myArrayList[1]
            myArrayList.Add('B');                       //myArrayList[2]
            myArrayList.Add(12);                        //myArrayList[3]

            //myArrayList.Remove("BITM");

            myArrayList.RemoveAt(3);

            //myArrayList.Sort();
            //myArrayList.Reverse();
            //foreach (var item in myArrayList)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Count: " + myArrayList.Count);
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);

            }
            Console.ReadKey();
        }
    }
}
