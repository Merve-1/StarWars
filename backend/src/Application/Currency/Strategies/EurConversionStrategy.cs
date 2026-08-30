using Application.Interfaces;
using Microsoft.Extensions.Options;

namespace Application.Currency.Strategies;



public class EurConversionStrategy : ICurrencyConversionStrategy
{
    private readonly CurrencyRatesOptions _rates;
    public EurConversionStrategy(IOptions<CurrencyRatesOptions> rates) => _rates = rates.Value;

    public string CurrencyCode => "EUR";
    public decimal Convert(decimal creditsAmount) => creditsAmount * _rates.EurPerCredit;
}