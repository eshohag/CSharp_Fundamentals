using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your String to Reverse:");
            string aString = Console.ReadLine();
            Char[] charArrayString = aString.ToCharArray();
            Array.Reverse(charArrayString);
            Console.WriteLine("==Foreach Loop==");
            foreach (var aChar in charArrayString)
            {
                Console.Write(aChar);
            }
            Console.WriteLine("\n==For Loop==");

            for (int i = 0; i < charArrayString.Length; i++)
            {
                Console.Write(charArrayString[i]);
            }
            Console.ReadKey();
        }
    }
}
