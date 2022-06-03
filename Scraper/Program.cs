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
            WebData webData = new WebData();
            DataHandler handler = new DataHandler();
            handler.AddUrlsFromCSV("accounts.csv");

            for (int i = 0; i < DataHandler.Urls.Count; i++)
            {
                var _url = handler.GetUrlAtIndex(i).Trim('\"');
                var _localHtml = WebData.GetHtml(_url).InnerHtml;
                if (_localHtml != null)
                {
                    var _emails = WebData.getEmailsFromHTML(_localHtml);
                    if (_emails != "" && handler.isValidEmail(_emails))
                    {
                        Console.WriteLine(_emails);
                    }
                    else
                    {
                        Console.WriteLine("No emails found for: " + _url + "\n");
                    }
                }
            }

        }
    }
}