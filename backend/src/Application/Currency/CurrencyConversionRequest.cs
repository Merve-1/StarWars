namespace Application.Currency;

public class CurrencyConversionRequest
{
    public decimal Amount { get; set; }
    public string TargetCurrency { get; set; } = string.Empty;
}