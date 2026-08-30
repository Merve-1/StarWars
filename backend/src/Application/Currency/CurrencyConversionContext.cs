using Application.Interfaces;

namespace Application.Currency;


public class CurrencyConversionContext
{
    private readonly IEnumerable<ICurrencyConversionStrategy> _strategies;
    public CurrencyConversionContext(IEnumerable<ICurrencyConversionStrategy> strategies) => _strategies = strategies;

    public CurrencyConversionResult Convert(decimal creditsAmount, string targetCurrency)
    {
        var strategy = _strategies.FirstOrDefault(s =>
                           s.CurrencyCode.Equals(targetCurrency, StringComparison.OrdinalIgnoreCase))
                       ?? throw new ArgumentException($"Unsupported currency: {targetCurrency}");

        return new CurrencyConversionResult
        {
            OriginalAmount = creditsAmount,
            ConvertedAmount = strategy.Convert(creditsAmount),
            Currency = strategy.CurrencyCode
        };
    }
}