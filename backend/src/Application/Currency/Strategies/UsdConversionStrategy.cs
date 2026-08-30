using Application.Interfaces;
using Microsoft.Extensions.Options;

namespace Application.Currency.Strategies;

public class UsdConversionStrategy : ICurrencyConversionStrategy
{
    private readonly CurrencyRatesOptions _rates;
    public UsdConversionStrategy(IOptions<CurrencyRatesOptions> rates) => _rates = rates.Value;

    public string CurrencyCode => "USD";
    public decimal Convert(decimal creditsAmount) => creditsAmount * _rates.UsdPerCredit;
}