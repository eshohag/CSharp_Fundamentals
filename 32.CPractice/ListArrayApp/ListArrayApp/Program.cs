using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylistA=new List<string>();
            mylistA.Add("SEIP");
            mylistA.Add("DotNet");
            mylistA.Add("Batch-20");
            mylistA.Add("BASIS");

            mylistA.Sort();
            mylistA.Reverse();
            mylistA.Remove("SEIP");
            mylistA.RemoveAt(1);                         //Remove Array Position not Value 
            Console.WriteLine("Length " + mylistA.Count);

            foreach (string item in mylistA)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < mylistA.Count; i++)
            //{
            //    Console.WriteLine(mylistA[i]);
            //} 
            Console.ReadKey();
        }
    }
}
