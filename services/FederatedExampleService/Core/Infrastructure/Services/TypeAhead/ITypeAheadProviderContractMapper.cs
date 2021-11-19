namespace FederatedExampleService.Core.Infrastructure.Services.TypeAhead
{
    public interface ITypeAheadProviderContractMapper
    {
        string ConvertToUrl(TypeAheadQueryRequestContract typeAheadQueryRequestContract);

        TypeAheadQueryResponseContract ConvertResponseJsonToTypeAheadQueryResponseContract(LucidWorksTypeAheadResponseContract lucidWorksTypeAheadResponseContract);
    }
}
