using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using glowscraper.Services;
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
            var url = "https://rateyourmusic.com/charts/top/album/all-time/loc:japan/exc:live,archival/1/#results";
            var html = GetHtml(url);

            //var artistService = new ArtistService();
            //artistService.GetArtistDetails(html);

            var linkService = new LinkService();
            var artistLinks = linkService.GetArtistLinks(html);

            Console.WriteLine(artistLinks);
        }

        static HtmlNode GetHtml(string url)
        {
            var webpage = _scrapingBrowser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }
    }
}
