using System;

namespace CInputValueFromUser
{
    class InputValue                                  // InputValue Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your First Name:");
            string fName = Console.ReadLine();        //Input Value with variable
            Console.WriteLine("Your Last Name:");     //Print 
            string lName = Console.ReadLine();        //Input Value with variable
            Console.WriteLine("Your Age:");           //Print 
            string age = Console.ReadLine();          //Input Value with variable
            string yourDetails = fName + " " + lName + " \nYour Age: " + age;        //Variable name yourDetails
            Console.WriteLine("Your Name: " + yourDetails);                          //Print this variable
            Console.ReadKey();                         //Catch this screen 
        }
    }
}
