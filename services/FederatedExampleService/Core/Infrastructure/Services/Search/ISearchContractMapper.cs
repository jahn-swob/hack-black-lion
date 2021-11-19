using FederatedExampleService.Core.Infrastructure.Contracts.Search;

namespace FederatedExampleService.Core.Infrastructure.Services.Search
{
    public interface ISearchContractMapper
    {
        string BuildRoute(SearchQueryRequestContract query);

        SearchQueryResponseContract BuildResponse(SearchResponse response, SearchQueryRequestContract query);
    }
}
