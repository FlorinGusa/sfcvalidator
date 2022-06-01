using System;
using Scraper.pyScraper;

namespace Scraper // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEBSCRAPER");
            Console.WriteLine("__________________");
            var innerHtml = WebData.GetHtml("https://en.rte.pt/home").InnerHtml;
            Console.WriteLine(WebData.getEmailsFromHTML(innerHtml));

            //List<string> links = WebData.GetLinks(new Uri("https://www.fanuc.eu/de/en"));
            //for (int i = 0; i < links.Count; i++)
            //{
            //    Console.WriteLine(links[i]);
            //}

        }
    }
}