using System;
using System.IO;
using System.Net;

namespace WebClientClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient aClient = new WebClient();
            string stringHtml = aClient.DownloadString("http://msdn.microsoft.com");
            Console.WriteLine(stringHtml);

            File.WriteAllText(@"G:\Intro CSharp\WebClientClassApp\SaveText.txt", stringHtml);

            Console.ReadKey();
        }
    }
}
