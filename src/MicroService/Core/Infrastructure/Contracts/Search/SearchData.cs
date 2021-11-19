using System.Text.Json.Serialization;

namespace MicroService.Core.Infrastructure.Contracts.Search
{
    public class SearchData
    {
        [JsonPropertyName("numFound")]
        public int NumFound { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("docs")]
        public List<ProductDocument> Documents { get; set; } = new List<ProductDocument>();
    }
}
