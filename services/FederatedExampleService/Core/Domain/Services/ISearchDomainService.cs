using FederatedExampleService.Core.Domain.Models.Search;
using FederatedExampleService.Core.Domain.Queries;

namespace FederatedExampleService.Core.Domain.Services
{
    public interface ISearchDomainService
    {
        Task<SearchQueryResult> GetSearchAsync(SearchQuery query);
    }
}
