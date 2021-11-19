using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace FederatedExampleService.Models.TypeAhead
{
    public class TypeAheadResponse
    {
        [JsonPropertyName("searchSuggestions")]
        public List<SearchSuggestion> SearchSuggestions { get; set; } = new List<SearchSuggestion>();

        [JsonPropertyName("productSuggestions")]
        public List<ProductSuggestion> ProductSuggestions { get; set; } = new List<ProductSuggestion>();
    }
}
