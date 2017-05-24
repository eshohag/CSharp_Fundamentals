using dllClassLibraryWorking;
using System;

namespace WebPageStringDownloadReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FindHtmlStringDownload aDownload = new FindHtmlStringDownload();
            string download = aDownload.WebPageString(@"http://www.facebook.com/");
            string display = aDownload.WebPageString(@"http://www.facebook.com/", @"G:\Intro CSharp\Class Library Working With DLL\WebPageStringDownloadReadWriteFile\filePath.txt");
            Console.WriteLine(download);
            Console.WriteLine(display);
            Console.ReadKey();
        }
    }
}
