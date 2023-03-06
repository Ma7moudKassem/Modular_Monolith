namespace Catalog.Infrasturcture;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddCatalogInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabaseContexts<CatalogDbContext>(configuration)
            .AddScoped<ICatalogDbContext>(provider => provider.GetService<CatalogDbContext>());

        return services;
    }
}
