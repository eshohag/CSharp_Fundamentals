
using System;

namespace CVariableInitial
{
    class Variable
    {
        static void Main(string[] args)
        {
            int fNumber;                                       //Variable declared  not initial in this case 
            int secondNumber;                                  //Variable declared
            int threeNumber = 4;                               //Variable declared & inital this variable at a time
            Console.WriteLine("Input your First Number");
            fNumber = Convert.ToInt32(Console.ReadLine());     //fNumber is a integer value declard  and ReadLine is a string Value so Convert it
            Console.WriteLine("Input your Second Number");
            secondNumber = Convert.ToInt32(Console.ReadLine());     //Inital this variable after delared variable
            int addition = fNumber + secondNumber + threeNumber;
            Console.WriteLine("Total Addition is " + addition);
            Console.ReadKey();
        }
    }
}
