using MicroService.Core.DataTransferObjects.Search;
using MicroService.Core.Domain.Models.Search;
using MicroService.Core.Domain.Queries;

namespace MicroService.Core.Application.Services
{
    public interface ISearchDataMapper
    {
        SearchQuery ConvertDtoToQuery(SearchRequestDto query);

        SearchResponseDto ConvertQueryResultToDto(SearchQueryResult response);
    }
}
