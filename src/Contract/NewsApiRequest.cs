using Newtonsoft.Json;

namespace Client.Contract
{
    public class NewsApiRequest
    {
        [JsonProperty("q")]
        public string Query { get; set; } = "*";

        [JsonProperty("qInTitle")]
        public string QueryInTitle { get; set; }

        [JsonProperty("sources")]
        public string Sources { get; set; } 

        [JsonProperty("domains")]
        public string Domains { get; set; }

        [JsonProperty("excludeDomains")]
        public string ExcludeDomains { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; } = 20;

        [JsonProperty("page")]
        public int Page { get; set; } = 1;
    }
}
