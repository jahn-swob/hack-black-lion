using MicroService.Core.Domain.Models.Search;
using MicroService.Core.Domain.Queries;
using MicroService.Core.Infrastructure.Contracts.Search;

namespace MicroService.Core.Infrastructure.Services.Search
{
    public interface ISearchProviderDataMapper
    {
        SearchQueryRequestContract ConvertQueryToQueryRequestContractRequest(SearchQuery query);

        SearchQueryResult ConvertQueryResponseContractToQueryResult(SearchQueryResponseContract contract);
    }
}
