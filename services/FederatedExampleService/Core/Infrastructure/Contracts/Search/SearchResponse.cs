using System.Text.Json.Serialization;

namespace FederatedExampleService.Core.Infrastructure.Contracts.Search
{
    public class SearchResponse
    {
        [JsonPropertyName("response")]
        public SearchData Response { get; set; } = new SearchData();
    }
}
    