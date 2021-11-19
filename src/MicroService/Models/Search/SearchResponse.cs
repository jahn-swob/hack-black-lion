using System.Text.Json.Serialization;
using MicroService.Core.DataTransferObjects.Search;
using MicroService.Interfaces;

namespace MicroService.Models.Search
{
    public class SearchResponse
    {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("product_results")]
        public List<Product> ProductResults { get; set; } = new List<Product>();

        public static SearchResponse FromDto(SearchResponseDto response)
        {
            return new SearchResponse
            {
                TotalCount = response.TotalCount,
                ProductResults = response.ProductResults.Select(p => p.Convert<Product>()).ToList()
            };
        }
    }
}
