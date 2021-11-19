using MicroService.Core.Infrastructure.Contracts.Search;

namespace MicroService.Core.Infrastructure.Services.Search
{
    public interface ISearchProvider
    {
        Task<SearchQueryResponseContract> GetSearchQueryResponseAsync(SearchQueryRequestContract query);
    }
}
