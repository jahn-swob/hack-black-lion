using MicroService.Core.Domain.Models.Search;
using MicroService.Core.Domain.Queries;
using MicroService.Core.Domain.Services;
using MicroService.Core.Infrastructure.Services.Search;

namespace MicroService.Core.Infrastructure.ServiceAgents.Search
{
    public class SearchServiceAgent : ISearchDomainService
    {
        private readonly ILogger<SearchServiceAgent> _log;
        private readonly ISearchProviderDataMapper _mapper;
        private readonly ISearchProvider _provider;

        public SearchServiceAgent(ILogger<SearchServiceAgent> log, ISearchProvider provider, ISearchProviderDataMapper mapper)
        {
            _log = log;
            _provider = provider;
            _mapper = mapper;
        }

        public async Task<SearchQueryResult> GetSearchAsync(SearchQuery query)
        {
            var requestContract = _mapper.ConvertQueryToQueryRequestContractRequest(query);
            var responseContract = await _provider.GetSearchQueryResponseAsync(requestContract);
            var response = _mapper.ConvertQueryResponseContractToQueryResult(responseContract);
            return response;
        }
    }
}
