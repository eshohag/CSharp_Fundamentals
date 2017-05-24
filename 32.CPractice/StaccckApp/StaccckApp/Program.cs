using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaccckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack=new Stack<int>();
            myStack.Push(23);
            myStack.Push(20);
            myStack.Push(33);
            myStack.Push(40);
            myStack.Push(66);
            myStack.Push(88);
            //Console.WriteLine(myStack.Contains(20));
            //int[] myArray = myStack.ToArray();
            Console.WriteLine(myStack.Peek());
            myStack.Pop();
            Console.WriteLine(myStack.Peek());
            myStack.Pop();
            Console.WriteLine("Number Of Total Stack= " + myStack.Count);

            
            //Console.WriteLine(myStack.Pop());
            //myStack.Pop();
            //Console.WriteLine(myStack.Pop());
            //myStack.Pop();
            //Console.WriteLine(myStack.Count);
            //Console.WriteLine("Foreach Loop");
            //foreach (int i in myArray)
            //{
            //    Console.WriteLine((i));
            //}



            //Console.WriteLine("For Loop");
            //for (int i = 0; i < myArray.Count(); i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            Console.ReadKey();
        }
    }
}
