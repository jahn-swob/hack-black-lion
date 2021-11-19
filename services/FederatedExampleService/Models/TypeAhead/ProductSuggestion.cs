using System.Text.Json.Serialization;

namespace FederatedExampleService.Models.TypeAhead
{
    public class ProductSuggestion
    {
        [JsonPropertyName("score")]
        public decimal Score { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; } = string.Empty;

        [JsonPropertyName("sku")]
        public string Sku { get; set; } = string.Empty;
    }
}
