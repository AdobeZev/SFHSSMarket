using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using HtmlAgilityPack;

namespace Scraper
{
    public class WebScraper
    {

        public static async void scrapeWeb(string url)
        {

            var webClient = new HttpClient();
            var html = await webClient.GetStringAsync(url);

            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var nodes = doc.DocumentNode.SelectSingleNode("//div[@Class='wbus71']");

            Console.Write($"\nCode:{nodes.GetType()}");

        }

    }
}