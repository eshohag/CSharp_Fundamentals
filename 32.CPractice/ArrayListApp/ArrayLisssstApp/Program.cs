using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLisssstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList=new ArrayList();
            myArrayList.Add(7);
            myArrayList.Add(22);
            myArrayList.Add(33);
            myArrayList.Add(5);
            myArrayList.Add("BITM");

            //myArrayList.Remove(5);         //Remove Value
            //myArrayList.RemoveAt(0);          //Array Position delete so data is delete
            //myArrayList.Reverse();
            //myArrayList.Sort();                     //Same type data than sort
            Console.WriteLine("Array List Count "+myArrayList.Count);
            Console.WriteLine(myArrayList[0]);
            Console.WriteLine("\nForeach Loop Print ");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nFor Loop Print ");
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }
            Console.ReadKey();
        }
    }
}
