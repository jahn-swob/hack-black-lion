using FederatedExampleService.Interfaces;

namespace FederatedExampleService.Core.DataTransferObjects.Search
{
    public class ProductDto : IProduct
    {
        public int Sku { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ProductUrl { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public decimal Rank { get; set; }

        public decimal Rating { get; set; }

        public int PrimaryFamilyId { get; set; }

        public int PrimaryCategoryId { get; set; }

        public int RegularPrice { get; set; }

        public int CurrentPrice { get; set; } 
    }
}
