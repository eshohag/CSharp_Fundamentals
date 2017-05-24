using System;

namespace CDataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int myFiestNumber = 10;
            double mySecondNumber = 22.4;
            string myName = "My Name is Shohag";
            long longValue = myFiestNumber + (long)mySecondNumber;
            //myName =Convert.ToString(longValue);
            //myFiestNumber = (int)mySecondNumber;
            Console.WriteLine(myFiestNumber);
            //myName = Convert.ToString(myFiestNumber);
            //Console.WriteLine(myName);
            //myName = Convert.ToString(mySecondNumber);
            //Console.WriteLine(myName);
            myFiestNumber = Convert.ToInt32(myName);                               //Imposible String Convert
            //Console.WriteLine(myFiestNumber);
            //char ascii = 'a';
            ////int asciiValue = Convert.ToInt32(ascii);
            //int asciiValue = (int)ascii;

            //Console.WriteLine(asciiValue);
            Console.WriteLine(longValue);
            //myFiestNumber = (int)longValue;
            Console.WriteLine("Your Long Value convert");
            //Console.WriteLine(myFiestNumber);
            Console.ReadKey();

        }
    }
}
