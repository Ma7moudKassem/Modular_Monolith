namespace Person
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersonModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersonCore()
                    .AddPersonIfrastructure(configuration);

            return services;
        }
    }
}
