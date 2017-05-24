using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMathodsCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Give Your Name:");
            //string name = Console.ReadLine();
            //GetReverseString(name);

            //Console.WriteLine("\nPlease Give Your Address:");
            //string address = Console.ReadLine();
            //GetReverseString(address);


            Console.WriteLine("Please Give Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine(GetReverseString(name));
           ;

            Console.WriteLine("\nPlease Give Your Address:");
            string address = Console.ReadLine();
            Console.WriteLine(GetReverseString(address));


            Console.ReadKey();
        }

        //private static void GetReverseString(string text)
        //{
        //    Char[] charArry = text.ToCharArray();
        //    Array.Reverse(charArry);
        //    foreach (var i in charArry)
        //    {
        //        Console.Write(i);
        //    }
        //}
        private static string GetReverseString(string text)
        {
            Char[] charArry = text.ToCharArray();
            Array.Reverse(charArry);
            string re= String.Concat(charArry);
            return re;
        }
    }
}
