using MicroService.Core.DataTransferObjects.Search;
using MicroService.Core.Domain.Models.Search;
using MicroService.Core.Domain.Queries;
using MicroService.Interfaces;

namespace MicroService.Core.Application.Services
{
    public class SearchDataMapper : ISearchDataMapper
    {
        public SearchQuery ConvertDtoToQuery(SearchRequestDto query)
        {
            return new SearchQuery
            {                
                Query = query.Query
            };
        }

        public SearchResponseDto ConvertQueryResultToDto(SearchQueryResult response)
        {
            return new SearchResponseDto
            {
                TotalCount = response.TotalCount,
                ProductResults = response.ProductResults.Select(p => p.Convert<ProductDto>()).ToList(),
            };
        }
    }
}
