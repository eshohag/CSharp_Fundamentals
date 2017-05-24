using System;

namespace CHypotenceRightTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 5;
            double length = 8;
            double hypotance = Math.Sqrt((height * height) + (length * length));
            Console.WriteLine("Hypotence of the triangle with sides " + height + " by " + length + " is " + hypotance);
            Console.ReadKey();
        }
    }
}
