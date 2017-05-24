using System.IO;
using System.Net;

namespace MyClassLibraryCode
{
    public class Scrape
    {
        public string WebPage(string url)
        {
            return GetWebPage(url);
        }
        public string WebPage(string url, string filePath)
        {
            string download = GetWebPage(url);
            File.WriteAllText(filePath, download);
            return download;
        }

        private string GetWebPage(string url)
        {
            WebClient aClient = new WebClient();
            string webPage = aClient.DownloadString(url);
            return webPage;
        }
    }
}
