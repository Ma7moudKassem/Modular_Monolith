namespace Person.Infrasturcture;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddPersonIfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabaseContexts<PersonDbContext>(configuration)
                .AddScoped<IPersonDbContext>(provider => provider.GetService<PersonDbContext>());

        return services;
    }
}
