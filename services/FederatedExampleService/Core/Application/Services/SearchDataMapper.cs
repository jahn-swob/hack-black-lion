using FederatedExampleService.Core.Domain.Queries;
using FederatedExampleService.Core.DataTransferObjects.Search;
using FederatedExampleService.Core.Domain.Models.Search;
using FederatedExampleService.Interfaces;

namespace FederatedExampleService.Core.Application.Services
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
