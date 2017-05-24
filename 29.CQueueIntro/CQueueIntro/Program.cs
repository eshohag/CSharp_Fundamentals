using System;
using System.Collections.Generic;

namespace CQueueIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("BITM");
            myQueue.Enqueue("CSE");

            //Console.WriteLine(myQueue.Peek());
            //myQueue.Dequeue();
            //myQueue.Dequeue();

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());

            Console.WriteLine("Combining every element by Enqueue:");
            foreach (string s in myQueue)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
