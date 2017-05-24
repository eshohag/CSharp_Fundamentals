using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string>myHash=new Dictionary<int, string>();
            myHash.Add(1,"CSE-1");
            myHash[0] = "CSE-2";
            myHash.Add(2,"CSE-3");
            Console.WriteLine(myHash.ContainsKey(1));
            Console.WriteLine(myHash.ContainsValue("CSE-1"));


            //for (int i = 0; i < myHash.Count; i++)
            //{
            //    Console.WriteLine(myHash[i]);
            //}
            //foreach (var i in myHash)
            //{
            //    Console.WriteLine(i);
            //}




            Console.WriteLine("====My Logic====");
            ArrayList myAr = new ArrayList(myHash);
            //foreach (var i in myAr)
            //{
            //    Console.WriteLine();
            //}
            for (int i = 0; i < myAr.Count; i++)
            {
                Console.WriteLine(myAr[i]);
            }
           
            Console.ReadKey();
        }
    }
}
