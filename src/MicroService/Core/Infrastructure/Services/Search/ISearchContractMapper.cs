using MicroService.Core.Infrastructure.Contracts.Search;

namespace MicroService.Core.Infrastructure.Services.Search
{
    public interface ISearchContractMapper
    {
        string BuildRoute(SearchQueryRequestContract query);

        SearchQueryResponseContract BuildResponse(SearchResponse response, SearchQueryRequestContract query);
    }
}
