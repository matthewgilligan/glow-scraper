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

        static ArtistDetails GetArtistDetails(string url)
        {
            var htmlNode = GetHtml(url);
            var artistDetails = new ArtistDetails();

            var NameNode = htmlNode.CssSelect(".artist_name_hdr").First();
            artistDetails.Name = NameNode.InnerText;

            return artistDetails;
        }

        static HtmlNode GetHtml(string url)
        {
            var webpage = _scrapingBrowser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }
    }

    public class ArtistDetails
    {
        public string Name { get; set; }
        public string Formed { get; set; }
    }
}
