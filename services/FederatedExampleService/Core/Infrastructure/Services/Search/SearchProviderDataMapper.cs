using FederatedExampleService.Core.Domain.Queries;
using FederatedExampleService.Core.Infrastructure.Contracts.Search;
using FederatedExampleService.Core.Domain.Models.Search;
using FederatedExampleService.Interfaces;

namespace FederatedExampleService.Core.Infrastructure.Services.Search
{
    public class SearchProviderDataMapper : ISearchProviderDataMapper
    {
        public SearchQueryRequestContract ConvertQueryToQueryRequestContractRequest(SearchQuery query)
        {
            return new SearchQueryRequestContract
            {
                Query = query.Query
            };
        }

        public SearchQueryResult ConvertQueryResponseContractToQueryResult(SearchQueryResponseContract contract)
        {
            return new SearchQueryResult
            {
                TotalCount = contract.TotalCount,
                ProductResults = contract.ProductResults.Select(p => p.Convert<ProductResult>()).ToList(),
            };
        }
    }
}
