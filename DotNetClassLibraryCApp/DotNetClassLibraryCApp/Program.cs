using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DotNetClassLibraryCApp
{
    class Program
    {
        static void Main(string[] args)
        {
           WebClient aClient=new WebClient();
            string text = aClient.DownloadString("http://www.google.com/");
            Console.WriteLine(text);

           // File.WriteAllText("G:\\text.txt",text);
            File.WriteAllText(@"G:\text.txt", text);
            Console.ReadKey();
        }
    }
}
