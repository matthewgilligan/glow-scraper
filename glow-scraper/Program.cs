using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace MusicScraper
{
    class Program
    {
        static ScrapingBrowser _scrapingBrowser = new ScrapingBrowser();

        static void Main(string[] args)
        {
            var url = "https://rateyourmusic.com/artist/fishmans";

            GetArtistDetails(url);
        }

        static HtmlNode GetHtml(string url)
        {
            var webpage = _scrapingBrowser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }
    }
}
