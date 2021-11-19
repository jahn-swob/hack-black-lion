using MicroService.Core.Domain.Models.Search;
using MicroService.Core.Domain.Queries;
using MicroService.Core.Infrastructure.Contracts.Search;
using MicroService.Interfaces;

namespace MicroService.Core.Infrastructure.Services.Search
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
