using System.Text.Json.Serialization;

namespace FederatedExampleService.Models.TypeAhead
{
    public class SearchSuggestion
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("score")]
        public decimal Score { get; set; }
    }
}
