namespace Person.Core;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddPersonCore(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        
        return services;
    }
}
