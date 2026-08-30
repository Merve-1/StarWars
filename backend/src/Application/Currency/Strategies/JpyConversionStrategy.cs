using Application.Interfaces;
using Microsoft.Extensions.Options;
namespace Application.Currency.Strategies;


public class JpyConversionStrategy : ICurrencyConversionStrategy
{
    private readonly CurrencyRatesOptions _rates;
    public JpyConversionStrategy(IOptions<CurrencyRatesOptions> rates) => _rates = rates.Value;

    public string CurrencyCode => "JPY";
    public decimal Convert(decimal creditsAmount) => creditsAmount * _rates.JpyPerCredit;
}