using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimesCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDateTime =DateTime.Now;
            //Console.WriteLine(myDateTime.ToString());
            //Console.WriteLine(myDateTime.ToShortDateString());
            //Console.WriteLine(myDateTime.ToShortTimeString());
            //Console.WriteLine(myDateTime.ToLongTimeString());
            //Console.WriteLine(myDateTime.ToLongDateString());
            //Console.WriteLine(myDateTime.AddDays(1).ToShortDateString());
            //Console.WriteLine(myDateTime.AddHours(1).ToShortTimeString());
            //Console.WriteLine(myDateTime.AddHours(1).ToShortTimeString());
            //Console.WriteLine(myDateTime.ToUniversalTime());
            //Console.WriteLine(myDateTime.Minute);
            //Console.WriteLine(myDateTime.TimeOfDay);
            //Console.WriteLine(myDateTime.Month);


            //DateTime myBirthDay=new DateTime(1994,3,10);
            //Console.WriteLine(myBirthDay.ToShortDateString());


            //DateTime aDateTime = DateTime.Parse("10 / 3 / 1994");
            DateTime myBirthDay = new DateTime(1994, 3, 10);
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadKey();
        }
    }
}
