namespace FederatedExampleService.Core.Infrastructure.Contracts.TypeAhead
{
    public class SearchSuggestionContract
    {
        public string Name { get; set; } = string.Empty;
        public decimal Score { get; set; }
    }
}
