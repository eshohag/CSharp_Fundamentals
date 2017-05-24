using System;
using System.Collections.Generic;

namespace CNestedSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("Shohag");
            myList.Add("Shakil");
            myList.Add("Fahomid");
            myList.Add("Asiqur");
            List<string> shohagList = new List<string>();
            shohagList.Add("Contact");
            shohagList.Add("Email");
            shohagList.Add("Location");
            foreach (string s in myList)
            {
                switch (s)
                {
                    case "Shohag":
                        Console.WriteLine("You are a Shohag");
                        foreach (var shohag in shohagList)
                        {
                            switch (shohag)
                            {
                                case "Contact":
                                    Console.WriteLine("     Contact Number: 01926029000");
                                    break;
                                case "Email":
                                    Console.WriteLine("     Email Number: shohaghassan14@gmail.com");
                                    break;
                                case "Location":
                                    Console.WriteLine("     Location: Gaibandha");
                                    break;
                            }
                        }

                        break;
                    case "Fahomid":
                        Console.WriteLine("You are a Fahomid");
                        break;
                    case "Shakil":
                        Console.WriteLine("You are a Shakil");
                        break;

                    case "Asiqur":
                        Console.WriteLine("You are a Asiqur");
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
