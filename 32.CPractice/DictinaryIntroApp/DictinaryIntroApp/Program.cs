using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictinaryIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
              myDictionary.Add(11,"CSE-101");
              myDictionary.Add(12,"CSE-102");
              myDictionary[14]="CSE-103";
              myDictionary.Add(13,"CSE-104");
             
            Console.WriteLine(myDictionary.ContainsKey(13));
            Console.WriteLine(myDictionary.Count);
            myDictionary.Remove(11);
            Array myArr = myDictionary.ToArray();    //Dictionary To  Array Convert
            foreach (var i in myArr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("====Key to Value====");
            foreach (var show in myDictionary)
            {
                Console.WriteLine(show.Key+"="+show.Value);
                
            }
            Console.WriteLine("====Value to Key====");
            foreach (var show1 in myDictionary)
            {
                Console.WriteLine(show1.Value+"= "+show1.Key);
            }
            Console.ReadKey();
        }
    }
}
