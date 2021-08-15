using Client.Contract;
using Client.Shared.Components.Post;
using Client.Stored;
using System.Threading.Tasks;

namespace Client.Services
{
    public interface INewsService
    {
        public Task<NewsApiResponse<Article>> RequestArticles(NewsState newsState);
    }
}
