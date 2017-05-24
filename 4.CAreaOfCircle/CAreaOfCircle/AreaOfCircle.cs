using System;

namespace CAreaOfCircle
{
    class AreaOfCircle
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            Console.WriteLine("Please Input your Radius");
            radius = Convert.ToDouble(Console.ReadLine());
            area = radius * radius * 3.141617;
            Console.WriteLine("Your Total Area is " + area);
            Console.ReadKey();

        }
    }
}
