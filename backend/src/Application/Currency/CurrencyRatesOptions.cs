namespace Application.Currency;

public class CurrencyRatesOptions
{
    public const string SectionName ="CurrencyRates";
    public decimal UsdPerCredit { get; set; }
    public decimal EurPerCredit { get; set; }
    public decimal GbpPerCredit { get; set; }
    public decimal JpyPerCredit { get; set; }
}