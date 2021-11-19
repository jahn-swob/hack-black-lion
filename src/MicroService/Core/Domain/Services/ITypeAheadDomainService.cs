namespace FederatedExampleService.Core.Domain.Services
{
    public interface ITypeAheadDomainService
    {
        Task<TypeAheadQueryResult> GetTypeAheadAsync(TypeAheadQuery query, CancellationToken cancellationToken);
    }
}
