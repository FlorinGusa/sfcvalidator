using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scraper.Web
{
    public class WebData
    {
        static ScrapingBrowser _browser = new ScrapingBrowser();
        
        public HtmlNode GetHtml(string url)
        {
            WebPage webpage = _browser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }

        public List<string> GetMainPageLinks(string url)
        {
            var homePageLinks = new List<string>();
            var html = GetHtml(url);
            var links = html.CssSelect("a");

            foreach(var link in links)
            {
                if (link.Attributes["href"].Value.Contains(".html"))
                {
                    homePageLinks.Add(link.Attributes["href"].Value);
                }
            }

            return homePageLinks;
        }


    }
}
