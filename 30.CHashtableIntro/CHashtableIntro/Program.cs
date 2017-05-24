using System;
using System.Collections;

namespace CHashtableIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashtable = new Hashtable();
            myHashtable.Add(111, 'M');
            myHashtable.Add(0101, 'a');
            myHashtable.Add("Hello", 101);
            myHashtable[1110] = 'm';

            myHashtable.Remove('a');

            //Console.WriteLine(myHashtable.Contains("Hello"));
            //Console.WriteLine(myHashtable.Contains("test"));
            //Console.WriteLine(myHashtable[111]);   

            Console.WriteLine("All Keys");
            foreach (var key in myHashtable.Keys)
            {
                Console.WriteLine(key);

            }
            Console.WriteLine("All Values");
            foreach (var value in myHashtable.Values)
            {
                Console.WriteLine(value);

            }
            Console.ReadKey();
        }
    }
}
