namespace FederatedExampleService.Core.Infrastructure.Contracts.Search
{
    public class SearchQueryResponseContract
    {
        public int TotalCount { get; set; }
        public List<ProductContract> ProductResults { get; set; } = new List<ProductContract>();
    }
}
