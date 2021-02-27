using System;
using System.Linq;
using HtmlAgilityPack;
using ScrapySharp.Extensions;

namespace glowscraper.Services
{
    public class ArtistService
    {
        internal ArtistDetails GetArtistDetails(HtmlNode html)
        {
            var artistDetails = new ArtistDetails();

            var NameNode = html.CssSelect(".artist_name_hdr").First();
            artistDetails.Name = NameNode.InnerText;

            return artistDetails;
        }
    }

    public class ArtistDetails
    {
        public string Name { get; set; }
        public string Formed { get; set; }
    }
}
