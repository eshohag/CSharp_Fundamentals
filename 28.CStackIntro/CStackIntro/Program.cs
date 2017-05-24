using System;
using System.Collections.Generic;

namespace CStackIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(12);
            myStack.Push(33);
            myStack.Push(44);
            myStack.Push(55);

            int[] myArray = myStack.ToArray();
            Console.WriteLine("using peek() for one time: " + myStack.Peek());
            //myStack.Pop();
            //Console.WriteLine("\nafter using pop for one time, using contain() : "+myStack.Contains(33));
            //Console.WriteLine("\nafter after using POP() for one time: "+myStack.Pop());
            //Console.WriteLine("\nAfter pushing values in foreach loop ---\n");
            //foreach (int i in myStack)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\n after turning myStack to myArray : ");
            Array.Sort(myArray);
            Console.WriteLine("Length is " + myStack.Count);
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
