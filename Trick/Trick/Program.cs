using System;
using System.Collections.Generic;
using System.Linq;

namespace Trick
{
    class Program
    {
        public static void Removesss(List<int> values)
        {
            values = values.Where(x => x != 0).ToList();
        }
        static void Main()                                  //Errorr Solution of Problem in Main1() Replace by Main() 
        {
            List<int> Myvalues = new List<int> { 1, 0, 3, 4, 0, 6, 0 };

            Removesss(Myvalues);
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
