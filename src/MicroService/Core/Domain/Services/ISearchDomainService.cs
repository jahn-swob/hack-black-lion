using MicroService.Core.Domain.Models.Search;
using MicroService.Core.Domain.Queries;

namespace MicroService.Core.Domain.Services
{
    public interface ISearchDomainService
    {
        Task<SearchQueryResult> GetSearchAsync(SearchQuery query);
    }
}
