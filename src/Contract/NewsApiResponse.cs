using Client.Shared.Components.Post;
using System.Collections.Generic;

namespace Client.Contract
{
    public class NewsApiResponse<T>
    {
        public string Status { get; set; }
        public int TotalResults { get; set; } = 0;
        public ICollection<T> Articles { get; set; } = new HashSet<T>();

    }
}
