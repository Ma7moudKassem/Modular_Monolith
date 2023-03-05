using Catalog.Core;
using Catalog.Core.Abstractions;
using Catalog.Infrasturcture;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Infrastructure;

namespace Catalog
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCatalogInfrastructure(configuration)
                    .AddCatalogCore();

            return services;
        }
    }
}
