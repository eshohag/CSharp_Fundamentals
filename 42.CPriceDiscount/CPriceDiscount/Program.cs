using System;

namespace CPriceDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input Your Total Price:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Give Percentage:");
            decimal discountPriceUser = Convert.ToDecimal(Console.ReadLine());
            decimal discountPrice = discountPriceUser / 100;
            decimal discount = price * discountPrice;
            Console.WriteLine("Your Discount is " + discount);
            decimal netPrice = price - discount;
            Console.WriteLine("Your Net Price is " + netPrice);
            Console.ReadKey();
        }
    }
}
