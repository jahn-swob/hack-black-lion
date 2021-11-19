using System.Text.Json.Serialization;

namespace MicroService.Core.Infrastructure.Contracts.Search
{
    public class SearchResponse
    {
        [JsonPropertyName("response")]
        public SearchData Response { get; set; } = new SearchData();
    }
}
    