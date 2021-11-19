using System.Text.Json.Serialization;
using FederatedExampleService.Interfaces;

namespace FederatedExampleService.Models.Search
{
    public class Product : IProduct
    {
        [JsonPropertyName("sku")]
        public int Sku { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("product_url")]
        public string ProductUrl { get; set; } = string.Empty;

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = string.Empty;

        [JsonPropertyName("rank")]
        public decimal Rank { get; set; }

        [JsonPropertyName("rating")]
        public decimal Rating { get; set; }

        [JsonPropertyName("primary_family_id")]
        public int PrimaryFamilyId { get; set; }

        [JsonPropertyName("primary_category_id")]
        public int PrimaryCategoryId { get; set; }

        [JsonPropertyName("regular_price")]
        public int RegularPrice { get; set; }

        [JsonPropertyName("current_price")]
        public int CurrentPrice { get; set; }
    }
}
