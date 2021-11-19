using MicroService.Core.DataTransferObjects.Search;

namespace MicroService.Core.Application.Services
{
    public interface ISearchService
    {
        public Task<SearchResponseDto> GetSearchAsync(SearchRequestDto request);
    }
}
