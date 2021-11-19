namespace FederatedExampleService.Core.Infrastructure.Services.TypeAhead
{
    public interface ITypeAheadProviderDataMapper
    {
        TypeAheadQueryRequestContract ConvertQueryToQueryRequestContract(TypeAheadQuery typeAheadQuery);

        TypeAheadQueryResult ConvertQueryResponseContractToQueryResult(TypeAheadQueryResponseContract typeAheadQueryResponseContract);
    }
}
