using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
namespace Catalog.Core;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddCatalogCore(this IServiceCollection services)
    {

        return services;
    }
}
