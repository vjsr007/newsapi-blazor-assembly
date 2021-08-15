using Client.Contract;
using Client.Shared.Components.Post;
using System.Threading.Tasks;

namespace Client.Stored
{
    public interface INewsService
    {
        public Task<NewsApiResponse<Article>> RequestArticles(NewsState newsState);
    }
}
