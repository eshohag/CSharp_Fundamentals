using System;
using System.IO;

namespace FileWriteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string all = File.ReadAllText(@"G:\Intro CSharp\FileWriteApp\writefile.txt");
            Console.WriteLine(all);
            Console.WriteLine("If you want to Write File:\n Press-1 or Press-2 (Cancel/Exit)");
            var permission = Console.ReadLine();
            if (permission == 1.ToString())
            {
                Console.WriteLine("Write Your Text Below & then Hit Enter:");
                string text = Console.ReadLine();
                File.WriteAllText(@"G:\Intro CSharp\FileWriteApp\writefile.txt", text);
                Console.WriteLine("\n \n\n Dsiplay your write text: Y/N ");
                var display = Console.ReadLine();
                if (display == "Y")
                {
                    string displayData = File.ReadAllText(@"G:\Intro CSharp\FileWriteApp\writefile.txt");
                    Console.WriteLine(displayData);
                }
            }

        }
    }
}
