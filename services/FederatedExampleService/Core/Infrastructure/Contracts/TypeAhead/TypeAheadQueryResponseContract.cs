namespace FederatedExampleService.Core.Infrastructure.Contracts.TypeAhead
{
    public class TypeAheadQueryResponseContract
    {
        public List<SearchSuggestionContract> SearchSuggestions { get; set; } = new List<SearchSuggestionContract>();
        public List<ProductSuggestionContract> ProductSuggestions { get; set; } = new List<ProductSuggestionContract>();

    }
}
