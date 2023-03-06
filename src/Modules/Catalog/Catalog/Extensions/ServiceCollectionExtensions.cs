namespace Catalog
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCatalogCore()
                .AddCatalogInfrastructure(configuration);

            return services;
        }
    }
}
