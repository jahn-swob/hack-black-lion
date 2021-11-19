namespace FederatedExampleService.Core.Domain.Models.TypeAhead
{
    public class ProductSuggestionResult
    {
        public decimal Score { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
    }
}
