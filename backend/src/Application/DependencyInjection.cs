using Application.Currency;
using Application.Currency.Strategies;
using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<CurrencyRatesOptions>(configuration.GetSection(CurrencyRatesOptions.SectionName));

        services.AddSingleton<ICurrencyConversionStrategy, UsdConversionStrategy>();
        services.AddSingleton<ICurrencyConversionStrategy, EurConversionStrategy>();
        services.AddSingleton<ICurrencyConversionStrategy, GbpConversionStrategy>();
        services.AddSingleton<ICurrencyConversionStrategy, JpyConversionStrategy>();
        services.AddSingleton<CurrencyConversionContext>();

        return services;
    }
}