using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using ScrapySharp.Extensions;

namespace glowscraper.Services
{
    public class LinkService
    {
        internal List<string> GetArtistLinks(HtmlNode html)
        {
            var artistLinks = new List<string>();
            var links = html.CssSelect(".artist");

            foreach (var link in links)
            {
                if (link.Attributes["href"].Value.Contains(".html"))
                {
                    artistLinks.Add(link.Attributes["href"].Value);
                }
            }

            return artistLinks;
        }
    }
}
