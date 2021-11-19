using FederatedExampleService.Core.DataTransferObjects.Search;

namespace FederatedExampleService.Core.Application.Services
{
    public interface ISearchService
    {
        public Task<SearchResponseDto> GetSearchAsync(SearchRequestDto request);
    }
}
