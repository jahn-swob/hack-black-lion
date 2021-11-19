namespace FederatedExampleService.Core.Domain.Models.Search
{
    public class SearchQueryResult
    {
        public int TotalCount { get; set; }
        public List<ProductResult> ProductResults { get; set; } = new List<ProductResult>();
    }
}
