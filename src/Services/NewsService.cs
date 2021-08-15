using Client.Constants;
using Client.Contract;
using Client.Shared.Components.Post;
using Client.Stored;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;

namespace Client.Services
{
    public class NewsService : INewsService
    {
        private readonly IConfiguration _configuration;

        public NewsService(IConfiguration configuration) {
            _configuration = configuration;
        }
        public async Task<NewsApiResponse<Article>> RequestArticles(NewsState newsState)
        {
            var sources = newsState?.SourceSelected?.Select(s => s.id).ToArray();
            var filters = new NewsApiRequest
            {
                Page = newsState?.CurrentPage ?? 1,
                PageSize = NewsApiConstants.PAGE_SIZE,
                Query = newsState?.TopicSelected ?? "*",
                Sources = sources != null ? string.Join(',', sources) : String.Empty,
                Language = newsState?.LanguageSelected?.Select(s => s.id).FirstOrDefault() ?? "",
                SortBy = newsState?.SortBySelected?.Select(s => s.id).FirstOrDefault() ?? "",
            };
            var queryString = GetQueryString(filters);
            var url = _configuration["NewsAPI:url"];
            var articlesEndpoint = string.Format(NewsApiConstants.ARTICLES_ENDPOINT, url, queryString, _configuration["NewsAPI:key"]);
            using (var client = new HttpClient())
            {
                return await client.GetFromJsonAsync<NewsApiResponse<Article>>(articlesEndpoint);
            }            
        }

        private string GetQueryString(NewsApiRequest request)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(request);
            var jObj = JObject.FromObject(request);

            return String.Join("&",
                            jObj.Children().Cast<JProperty>()
                            .Where(jp => !string.IsNullOrEmpty(jp.Value.ToString()) && jp.Value.ToString() != "[]")
                            .Select(jp => jp.Name + "=" + HttpUtility.UrlEncode(jp.Value.ToString())));

        }
    }
}
