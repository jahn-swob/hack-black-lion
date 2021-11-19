namespace FederatedExampleService.Core.Domain.Models.TypeAhead
{
    public class SearchSuggestionResult
    {
        public string Name { get; set; } = string.Empty;
        public decimal Score { get; set; }
    }
}
