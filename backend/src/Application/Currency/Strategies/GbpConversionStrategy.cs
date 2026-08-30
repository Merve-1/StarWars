using Application.Interfaces;
using Microsoft.Extensions.Options;
namespace Application.Currency.Strategies;



public class GbpConversionStrategy : ICurrencyConversionStrategy
{
    private readonly CurrencyRatesOptions _rates;
    public GbpConversionStrategy(IOptions<CurrencyRatesOptions> rates) => _rates = rates.Value;

    public string CurrencyCode => "GBP";
    public decimal Convert(decimal creditsAmount) => creditsAmount * _rates.GbpPerCredit;
}