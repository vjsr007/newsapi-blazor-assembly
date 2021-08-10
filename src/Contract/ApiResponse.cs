using Client.Shared.Components.Post;
using System.Collections.Generic;

namespace Client.Contract
{
    public class ApiResponse
    {
        public string Status { get; set; }
        public int TotalResults { get; set; } = 0;
        public ICollection<Article> Articles { get; set; } = new HashSet<Article>();

    }
}
