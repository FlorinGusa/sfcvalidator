using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scraper.pyScraper
{
    public class WebData
    {
        static ScrapingBrowser? _browser;
        static HtmlNode? dummyHtml;
        static HtmlWeb? web;

        public WebData()
        {
            _browser = new ScrapingBrowser();
            _browser.KeepAlive = true;
            _browser.Proxy = null;
            _browser.AllowAutoRedirect = true;

            web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36";
            web.CaptureRedirect = true;
            setupDummyHtmlNode();
        }

        void setupDummyHtmlNode()
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            dummyHtml = new HtmlNode(HtmlNodeType.Document, htmlDocument, 0);

        }

        public static HtmlNode GetHtml(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                try
                {
                    web.Load(url);
                }catch(Exception e)
                {
                    Console.WriteLine(url + " ISSUE: " + e.StackTrace);
                }
                HttpStatusCode statusCode = HttpStatusCode.OK;
                web.PostResponse += (HttpRequestException, response) =>
                {
                    if (response != null)
                    {
                        statusCode = response.StatusCode;
                    }
                };

                string redirectUrl = web.ResponseUri.ToString();

                Console.WriteLine(url + " " + statusCode);

                if (redirectUrl.CompareTo(url) == 1)
                {
                    url = web.ResponseUri.ToString();
                    Console.WriteLine(" Redirected to: " + web.ResponseUri.ToString());
                }

                if (statusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine("Unable to connect to: " + url);
                }


                WebPage res = _browser.NavigateToPage(new Uri(url));
                if (res.Html != null)
                {
                    return res.Html;
                }
            }

            return dummyHtml;
        }

        public static HtmlDocument genHtmlDocument(string html)
        {
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);
            return document;
        }

        // Finds mailto: attribute within given string
        public static string getEmailsFromHTML(string html)
        {
            string h = new string(html.Where(c => !char.IsControl(c)).ToArray());

            StringBuilder sb = new StringBuilder(h.Length);
            try
            {
                HtmlDocument htmlDoc = genHtmlDocument(h);

                if (htmlDoc.DocumentNode.SelectNodes("//a/@href").Count > 0)
                {
                    foreach (HtmlAgilityPack.HtmlNode node in htmlDoc.DocumentNode.SelectNodes("//a/@href"))
                    {
                        if (node.Name == "a")
                        {
                            if (node.Attributes["href"].Value.StartsWith("mailto:"))
                            {
                                sb.AppendLine(node.InnerText);
                            }

                        }
                    }
                    return sb.ToString();
                }
                else
                {
                    return String.Empty;
                }
            }
            catch (Exception ex)
            {
                //bad formatted html
                Console.WriteLine(ex.Message);
            }

            return String.Empty;
        }

        public static List<string> GetLinks(Uri uri)
        {
            var regex = new Regex("^http(s)?://" + uri.Host, RegexOptions.IgnoreCase);
            var doc = new HtmlWeb().Load(uri);

            return doc.DocumentNode
                .Descendants("a")
                .Select(a =>
                {
                    var val = a.GetAttributeValue("href", string.Empty);
                    return val.StartsWith("/") ? uri.GetLeftPart(UriPartial.Authority) + val : val;
                })
                .Distinct()
                .Where(u => !string.IsNullOrEmpty(u) && regex.IsMatch(u))
                .ToList();
        }

        public List<string> GetMainPageLinks(string url)
        {
            var homePageLinks = new List<string>();
            var html = GetHtml(url);
            var links = html.CssSelect("a");

            foreach (var link in links)
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
