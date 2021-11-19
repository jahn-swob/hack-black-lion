namespace FederatedExampleService.Core.Domain.Models.TypeAhead
{
    public class TypeAheadQueryResult
    {
        public List<SearchSuggestionResult> SearchSuggestions { get; set; } = new List<SearchSuggestionResult>();
        public List<ProductSuggestionResult> ProductSuggestions { get; set; } = new List<ProductSuggestionResult>();

    }
}
