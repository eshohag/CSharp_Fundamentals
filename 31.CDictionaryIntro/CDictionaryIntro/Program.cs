using System;
using System.Collections.Generic;

namespace CDictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(101, "CSE101");
            myDictionary.Add(102, "CSE102");
            myDictionary.Add(103, "CSE103");
            myDictionary[105] = "CSE105";
            myDictionary[106] = "CSE106";

            //foreach (var key in myDictionary.Values)
            //{
            //    Console.WriteLine(key);

            //}

            foreach (var i in myDictionary)
            {
                Console.WriteLine(i.Key + "-" + i.Value);

            }
            Console.ReadKey();
        }
    }
}
