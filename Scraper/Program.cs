using System;
using Scraper.pyScraper;

namespace Scraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extracting emails");
            Console.WriteLine("__________________");

            var _linkList = Constants.Urls;
            for (int i = 0; i < _linkList.LongLength; i++)
            {
                if (WebData.GetHtml(_linkList[i]) != null)
                {
                    Console.WriteLine(WebData.getEmailsFromHTML(WebData.GetHtml(_linkList[i]).InnerHtml));
                }
            }

        }
    }
}