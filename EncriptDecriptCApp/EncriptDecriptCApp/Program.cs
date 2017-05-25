using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EncriptDecriptCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encreaption Start program

            Console.WriteLine("Enter Your Text here....");
            string value = Console.ReadLine();

            //get ASCII Value from string
            Debug.Assert(value != null, "value != null");
            byte[] decriptInfo = Encoding.ASCII.GetBytes(value);

            //Every element increase value 5  for ASCII Encoding code
            List<int> encriptInfo = new List<int>();
            for (int i = 0; i < value.Length; i++)
            {
                encriptInfo.Add(decriptInfo[i] + 5);
            }

            //Display Encription String
            List<string> encriptInfoString = new List<string>();
            foreach (var encript in encriptInfo)
            {
                int asciiValue = encript;
                char getCharacter = (char)asciiValue;
                encriptInfoString.Add(getCharacter.ToString());
            }
            Console.Write("Encription String: ");
            encriptInfoString.ForEach(Console.Write);

            //Decreaption Start program
            Console.WriteLine("\n\n\nDo you want to decript your string (Example: yes / no)");
            string yesNo = Console.ReadLine();
            if (yesNo == "yes")
            {
                Console.WriteLine("We will provide two Solution (Example: 1 / 2 / 3 )");
                int way = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\nYour Decription String: ");
                if (way == 1)
                {
                    //Input ASCII code dirrect access

                    List<string> deCriptInfoString = decriptInfo.Select(unicode => (char)(int)unicode).Select(character => character.ToString()).ToList();
                    deCriptInfoString.ForEach(Console.Write);

                    //foreach (var decript in decriptInfo)
                    //{
                    //    int unicode = decript;
                    //    char character = (char)unicode;
                    //    deCriptInfoString.Add(character.ToString());
                    //}
                    //deCriptInfoString.ForEach(Console.Write);
                }
                else if (way == 2)
                {
                    List<string> deCriptInfoFinal = (from decript in encriptInfo select decript - 5 into a select (char)a into c select c.ToString()).ToList();
                    deCriptInfoFinal.ForEach(Console.Write);
                }
                else
                {
                    //Encription ASCII value to decription ASCII value

                    //Step one
                    List<int> deCriptInfoFinal = encriptInfo.Select(decript => decript - 5).ToList();
                    //List<int> deCriptInfoFinal = new List<int>();
                    //foreach (var decript in encriptInfo)
                    //{
                    //    deCriptInfoFinal.Add(decript - 5);
                    //}

                    //Step two
                    List<string> deCriptInfoDisplay = deCriptInfoFinal.Select(unicode => (char)unicode).Select(character => character.ToString()).ToList();
                    //foreach (var display in deCriptInfoFinal)
                    //{
                    //    int unicode = display;
                    //    char character = (char)unicode;
                    //    deCriptInfoDisplay.Add(character.ToString());
                    //}


                    deCriptInfoDisplay.ForEach(Console.Write);
                }
            }
            else
            {
                Console.WriteLine("\n\nThanks! See you next time...\n=======Doha======");
            }
            Console.ReadKey();
        }
    }
}
