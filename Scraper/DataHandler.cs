using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Scraper
{
    public class DataHandler
    {

        private static List<string> urls = new List<string>();
        public void AddUrlsFromList(List<string> list)
        {
            try
            {
                urls.AddRange(list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void AddUrlsFromCSV(string path)
        {
            using (var reader = new StreamReader("accounts.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(",");
                        if (isValidUrl(values[2]))
                        {
                            urls.Add(values[2]);
                        }
                    }
                }
            }
        }

        public bool isValidEmail(string email)
        {
            return email.Contains('@');
        }

        public bool isValidUrl(string url)
        {
            //only working with https sites for now 
            return url.Contains("https://");
        }

        public string GetUrlAtIndex(int index)
        {
            return urls[index];
        }


        public static List<string> Urls { get => urls; }
    }
}
