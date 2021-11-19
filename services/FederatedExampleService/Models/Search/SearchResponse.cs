using System.Text.Json.Serialization;
using FederatedExampleService.Core.DataTransferObjects.Search;
using FederatedExampleService.Interfaces;

namespace FederatedExampleService.Models.Search
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

        //public static SearchResponse FromDto()
        //{
        //    return new SearchResponse
        //    {
        //        TotalCount = 2,
        //        ProductResults = new List<Product>
        //        {
        //            new Product
        //            {
        //                Sku = 123,
        //                CurrentPrice =100,
        //                Description ="Item 1 Description",
        //                Name = "Item 1 Name",
        //                ImageUrl = "Item 1 Image Url",
        //                ProductUrl = "Item 1 Product Url",
        //                RegularPrice = 100                      
        //            },
        //            new Product
        //            {
        //                Sku = 234,
        //                CurrentPrice =300,
        //                Description ="Item 2 Description",
        //                Name = "Item 2 Name",
        //                ImageUrl = "Item 2 Image Url",
        //                ProductUrl = "Item 2 Product Url",
        //                RegularPrice = 300
        //            }
        //        }
        //    };
        //}
    }
}
