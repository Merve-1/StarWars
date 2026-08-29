using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Swapi;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<SwapiOptions>(configuration.GetSection(SwapiOptions.SectionName));
        services.AddHttpClient<ISwapiClient, SwapiClient>();
        return services;
    }
}