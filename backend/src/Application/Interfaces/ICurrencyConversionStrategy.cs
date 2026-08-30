namespace Application.Interfaces;

public interface ICurrencyConversionStrategy
{
    string CurrencyCode { get; }
    decimal Convert(decimal creditsAmount);
}