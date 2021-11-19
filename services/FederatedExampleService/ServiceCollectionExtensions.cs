using FederatedExampleService.Core.Application.Services;
using FederatedExampleService.Core.Domain.Services;
using FederatedExampleService.Core.Infrastructure.ServiceAgents.Search;
using FederatedExampleService.Core.Infrastructure.Services.Search;

namespace FederatedExampleService
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<ISearchService, SearchService>();
            services.AddScoped<ISearchDataMapper, SearchDataMapper>();
        }

        public static void AddDomainLayer(this IServiceCollection services)
        {
            services.AddScoped<ISearchDomainService, SearchServiceAgent>();
        }

        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddScoped<ISearchProviderDataMapper, SearchProviderDataMapper>();
            services.AddScoped<ISearchContractMapper, SearchContractMapper>();
            services.AddHttpClient<ISearchProvider, SearchProvider>();
        }

    }
}
