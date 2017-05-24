using System.IO;
using System.Net;

namespace dllClassLibraryWorking
{
    public class FindHtmlStringDownload
    {
        public string WebPageString(string url)
        {
            var downloadString = GetWebDownloadString(url);
            return downloadString;
        }
        public string WebPageString(string url, string filePath)
        {
            string downloadString = GetWebDownloadString(url);
            File.WriteAllText(filePath, downloadString);
            string fileRead = File.ReadAllText(filePath);
            return fileRead;
        }
        private static string GetWebDownloadString(string url)
        {
            WebClient aClient = new WebClient();
            string downloadString = aClient.DownloadString(url);
            return downloadString;
        }
    }
}
