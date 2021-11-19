using FederatedExampleService.Core.Infrastructure.Contracts.Search;
using FederatedExampleService.Core.Domain.Queries;
using FederatedExampleService.Core.Domain.Models.Search;

namespace FederatedExampleService.Core.Infrastructure.Services.Search
{
    public interface ISearchProviderDataMapper
    {
        SearchQueryRequestContract ConvertQueryToQueryRequestContractRequest(SearchQuery query);

        SearchQueryResult ConvertQueryResponseContractToQueryResult(SearchQueryResponseContract contract);
    }
}
