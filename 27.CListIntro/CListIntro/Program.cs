using System;
using System.Collections.Generic;

namespace CListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myStringList = new List<string>();

            myStringList.Add("Bangladesh");
            myStringList.Add("is");
            myStringList.Add("our");
            myStringList.Add("country");
            //myStringList.Sort();
            //myStringList.Reverse();
            //myStringList.RemoveAt(1);



            //foreach (string s in myStringList)
            //{
            //    Console.WriteLine(s);
            //}

            Console.WriteLine("Count: " + myStringList.Count);
            for (int i = 0; i < myStringList.Count; i++)
            {
                Console.WriteLine(myStringList[i]);
            }
            Console.ReadKey();

        }
    }
}
