using MicroService.Core.DataTransferObjects.Search;
using MicroService.Core.Domain.Services;

namespace MicroService.Core.Application.Services
{
    public class SearchService : ISearchService
    {
        private readonly ILogger<SearchService> _logger;
        private readonly ISearchDomainService _searchDomainService;
        private readonly ISearchDataMapper _searchDataMapper;

        public SearchService(ILogger<SearchService> logger, ISearchDomainService searchDomainService, ISearchDataMapper searchDataMapper)
        {
            _logger = logger;
            _searchDomainService = searchDomainService;
            _searchDataMapper = searchDataMapper;
        }

        public async Task<SearchResponseDto> GetSearchAsync(SearchRequestDto request)
        {
            var query = _searchDataMapper.ConvertDtoToQuery(request);
            var domainResponse = await _searchDomainService.GetSearchAsync(query);
            var response = _searchDataMapper.ConvertQueryResultToDto(domainResponse);
            return response;
        }

    }
}
