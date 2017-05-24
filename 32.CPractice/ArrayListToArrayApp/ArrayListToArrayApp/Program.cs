using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListToArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList of different types of objects.
            ArrayList arrayListObjects = new ArrayList() { 10, "hello", 20 };
            arrayListObjects.Add(23);
            arrayListObjects.Add(33);


            // Convert to object array using ToArray of array list.
            object[] arrayObjects = arrayListObjects.ToArray();

            // Iterate and print the object array
            foreach (object obj in arrayObjects)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}
