using System.Text.Json.Serialization;

namespace FederatedExampleService.Models
{
    public class Product
    {
        [JsonPropertyName("sku")]
        public int Sku { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("regular_price")]
        public int RegularPrice { get; set; }

        [JsonPropertyName("current_price")]
        public int CurrentPrice { get; set; }

        [JsonPropertyName("product_url")]
        public string ProductUrl { get; set; } = string.Empty;

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
