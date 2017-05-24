using System;

namespace MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            Console.WriteLine(aCalculator.Add(1, 1, 3));



            //int a;
            //a = 10;
            //Console.WriteLine("Premitive data type " + Change(a));

            MyClass aClass = new MyClass();
            aClass.Number = 12;
            aClass.ThiredNumber = 14;
            aClass.TwoNumber = 13;
            Change(aClass);
            Console.WriteLine(aClass.Number);


            Console.ReadKey();
        }

        private static void Change(MyClass Class)
        {

            Class.Number = 20;


        }
        //private static int Change(int i)
        //{

        //    i = 20;
        //    return i;
        //}
        public class MyClass
        {
            public int Number { get; set; }
            public int TwoNumber { get; set; }
            public int ThiredNumber { get; set; }
        }
    }
}
