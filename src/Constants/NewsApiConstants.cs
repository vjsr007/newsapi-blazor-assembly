using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Constants
{
    public static class NewsApiConstants
    {
        public const string ARTICLES_ENDPOINT = "{0}everything?{1}&apiKey={2}";
        public const string SOURCE_ENDPOINT = "{0}top-headlines/sources?apiKey={1}";
    }
}
