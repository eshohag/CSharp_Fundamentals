using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string>myQueue=new Queue<string>();
            myQueue.Enqueue("Osman");
            myQueue.Enqueue("Mamun");
            myQueue.Enqueue("Shohag");
            Console.WriteLine("===Foreach Loop===");
            foreach (string i in myQueue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Queue Dequeue");
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine("Dequeue is the return & Remove kore Queue Value, SO Dequeue one value");
            myQueue.Dequeue();
            Console.WriteLine("Peek Only Showing Method");
            Console.WriteLine(myQueue.Peek());
            //myQueue.Dequeue();

            string[] myQue = myQueue.ToArray();
            Console.WriteLine("Queue Convert to Array");
            foreach (string i in myQue)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
