using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using HtmlAgilityPack;


namespace WooSahCodex
{
    public class EtsyScraper
    {
        static void Scrape()
        {
            // April 2018 markup  --  www.etsy.com              
            for (var x = 1; x < 299; x++)
            {
                string Url = "https://www.etsy.com/shop/WooSahUSA/sold?ref=pagination&page=" + x.ToString();
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(Url);

                HtmlNodeCollection cardList = doc.DocumentNode.SelectNodes(@"//*[@id='content']/div[3]/div[1]/div");
                foreach (HtmlNode htmlNode in cardList.Nodes())
                {
                    var listId = htmlNode.ChildNodes[1].Attributes[1].Value;
                    var desc = htmlNode.ChildNodes[1].Attributes[5].Value;

                    Debug.Print(listId + "  ----  " + desc);

                }
            }
        }
    }
}
