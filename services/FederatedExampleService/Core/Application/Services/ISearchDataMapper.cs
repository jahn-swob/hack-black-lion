using FederatedExampleService.Core.Domain.Queries;
using FederatedExampleService.Core.DataTransferObjects.Search;
using FederatedExampleService.Core.Domain.Models.Search;

namespace FederatedExampleService.Core.Application.Services
{
    public interface ISearchDataMapper
    {
        SearchQuery ConvertDtoToQuery(SearchRequestDto query);

        SearchResponseDto ConvertQueryResultToDto(SearchQueryResult response);
    }
}
