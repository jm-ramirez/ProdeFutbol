using System.Collections.Generic;

namespace ProdeFutbol.Common.Models
{
    public class Group : List<GroupDetailResponse>
    {
        public string Name { get; set; }

        public List<GroupDetailResponse> Teams => this;
    }
}
