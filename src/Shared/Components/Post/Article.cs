using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Shared.Components.Post
{
    public class Article
    {
        public string Title { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Author { get; set; }
        public Source Source { get; set; }
        public string UrlToImage { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
