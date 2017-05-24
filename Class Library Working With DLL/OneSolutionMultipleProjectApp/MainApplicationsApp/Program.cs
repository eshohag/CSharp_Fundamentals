using MyClassLibraryCode;
using System;

namespace MainApplicationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape aScrape = new Scrape();
            string download = aScrape.WebPage(@"http://www.gmail.com");
            string read = aScrape.WebPage(@"http://www.hotmail.com", @"G:\Intro CSharp\Class Library Working With DLL\OneSolutionMultipleProjectApp\file.txt");
            //Console.WriteLine(download);
            Console.WriteLine(read);
            Console.ReadKey();
        }
    }
}
