using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSharedInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers().ConfigureApplicationPartManager(manager =>
        {
            manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
        });

        return services;
    }

    public static IServiceCollection AddDatabaseContexts<T>(this IServiceCollection services, IConfiguration configuration) where T : DbContext
    {
        string? connectionString = configuration.GetConnectionString("AppConnectionString");
        services.AddDbContext<T>(e => e.UseSqlServer(connectionString, e => e.MigrationsAssembly(typeof(T).FullName)));

        using (IServiceScope scope = services.BuildServiceProvider().CreateScope())
        {
            T dbContext = scope.ServiceProvider.GetRequiredService<T>();

            dbContext.Database.Migrate();
        }

        return services;
    }
}
