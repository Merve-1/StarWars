namespace Application.Currency;

public class CurrencyConversionResult
{
    public decimal OriginalAmount { get; set; }
    public decimal ConvertedAmount { get; set; }
    public string Currency { get; set; } = string.Empty;
}