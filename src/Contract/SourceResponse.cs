using Client.Shared.Components.Post;
using System.Collections.Generic;

namespace Client.Contract
{
    public class SourceResponse<T>
    {
        public string Status { get; set; }
        public ICollection<T> Sources { get; set; } = new HashSet<T>();

    }
}
