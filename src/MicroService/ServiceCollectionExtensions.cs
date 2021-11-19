using MicroService.Core.Application.Services;
using MicroService.Core.Domain.Services;
using MicroService.Core.Infrastructure.ServiceAgents.Search;
using MicroService.Core.Infrastructure.Services.Search;

namespace MicroService
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
