using FederatedExampleService.Core.Domain.Services;
using FederatedExampleService.Core.Domain.Models.TypeAhead;
using FederatedExampleService.Core.Domain.Queries;

namespace FederatedExampleService.Core.Infrastructure.ServiceAgents.TypeAhead
{
    public class TypeAheadServiceAgent : ITypeAheadDomainService
    {
        private readonly ILogger<TypeAheadServiceAgent> _logger;
        private readonly ITypeAheadProvider _provider;
        private readonly ITypeAheadProviderDataMapper _dataMapper;

        public TypeAheadServiceAgent(ILogger<TypeAheadServiceAgent> logger, ITypeAheadProvider provider, ITypeAheadProviderDataMapper dataMapper)
        {
            _logger = logger;
            _provider = provider;
            _dataMapper = dataMapper;
        }

        public async Task<TypeAheadQueryResult> GetTypeAheadAsync(TypeAheadQuery query, CancellationToken cancellationToken)
        {
            var requestContract = _dataMapper.ConvertQueryToQueryRequestContract(query);
            var responseContract = await _provider.GetTypeAheadQueryResponseAsync(requestContract, cancellationToken);
            var response = _dataMapper.ConvertQueryResponseContractToQueryResult(responseContract);
            return response;
        }
    }
}
