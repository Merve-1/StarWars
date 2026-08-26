namespace Infrastructure.Swapi;

public class SwapiOptions
{
    public const string SectionName = "Swapi";
    public string BaseUrl { get; set; } = string.Empty;
    public int DefaultPageSize { get; set; } = 10;
    public int TimeoutSeconds { get; set; } = 10;
}