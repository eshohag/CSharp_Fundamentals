using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string>myQueuee=new Queue<string>();
            myQueuee.Enqueue("Hello");
            myQueuee.Enqueue("BITM");
            myQueuee.Enqueue("CSE");
            myQueuee.Enqueue("EEE");
            Console.WriteLine(myQueuee.Dequeue());
            string[] myArray = myQueuee.ToArray();
            myQueuee.Dequeue();
            Console.WriteLine(myQueuee.Contains("CSE"));

            Console.WriteLine("ForeEach Loop");
            foreach (string s in myQueuee)
            {
                Console.WriteLine(s);
            }


            Console.ReadKey();

        }
    }
}
