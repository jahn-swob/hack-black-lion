using FederatedExampleService.Core.Infrastructure.Contracts.Search;

namespace FederatedExampleService.Core.Infrastructure.Services.Search
{
    public interface ISearchProvider
    {
        Task<SearchQueryResponseContract> GetSearchQueryResponseAsync(SearchQueryRequestContract query);
    }
}
