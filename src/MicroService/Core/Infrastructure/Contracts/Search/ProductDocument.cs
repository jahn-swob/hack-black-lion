using System.Globalization;
using System.Text.Json.Serialization;
using MicroService.Interfaces;

namespace MicroService.Core.Infrastructure.Contracts.Search
{
    public class ProductDocument : IProduct
    {
        [JsonPropertyName("sku_i")]
        public int Sku { get; set; }

        [JsonPropertyName("primary_family_id_i")]
        public int PrimaryFamilyId { get; set; }

        [JsonPropertyName("primary_category_id_i")]
        public int PrimaryCategoryId { get; set; }

        [JsonPropertyName("Avg_Customer_Rating_ss")]
        public List<string> Ratings { get; set; } = new List<string>();

        [JsonPropertyName("current_price_i")]
        public int CurrentPrice { get; set; }

        [JsonPropertyName("regular_price_i")]
        public int RegularPrice { get; set; }

        [JsonPropertyName("score")]
        public decimal Rank { get; set; }

        [JsonIgnore]
        public decimal Rating
        {
            get
            {
                var avgRating = Ratings.FirstOrDefault();
                return decimal.TryParse(avgRating, out var actualRating) ? actualRating : Convert.ToDecimal("0.0");
            }
            set => Ratings.Add(value.ToString(CultureInfo.InvariantCulture));
        }

        [JsonPropertyName("sku_title_s")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("sku_description_long_s")]
        public string Description { get; set; } = string.Empty;
        
        [JsonPropertyName("product_url_s")]
        public string ProductUrl { get; set; } = string.Empty;

        [JsonPropertyName("image_url_display_s")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
