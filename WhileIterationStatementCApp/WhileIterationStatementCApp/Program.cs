using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WhileIterationStatementCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Chose an Option below:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Games");
            Console.WriteLine("3) Exit");
            int number = Int32.Parse(Console.ReadLine());
            if (number == 1)
            {
                PrintNumber();
                return true;
            }
            else if (number == 2)
            {
                GuessingGames();
                return true;
            }
            else if (number == 3)
            {
                // Environment.Exit(-1);   Close this Applications

                return false;
            }
            else
            {
                return true;
            }

        }

        private static void PrintNumber()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.Write("Type a Number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            //while (counter <= result)
            while (counter < result+1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGames()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");
            Random myRandom=new Random();
            int randomNumber = myRandom.Next(1,10);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string result = Console.ReadLine();
                guesses++;
                if (result==randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} Guessess",guesses);
            Console.ReadLine();
        }
    }
}
