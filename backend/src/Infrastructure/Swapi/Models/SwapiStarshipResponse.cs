namespace Infrastructure.Swapi.Models;

public class SwapiStarshipResponse
{
    public string? Message { get; set; }
    public SwapiStarshipResult? Result { get; set; }
}

public class SwapiStarshipListResponse
{
    public int TotalRecords { get; set; }
    public int TotalPages { get; set; }
    public string? Next { get; set; }
    public string? Previous { get; set; }
    public List<SwapiStarshipResult>? Results { get; set; }
}

public class SwapiStarshipResult
{
    public string? Uid { get; set; }
    public SwapiStarshipProperties? Properties { get; set; }
}

public class SwapiStarshipProperties
{
    public string? Name { get; set; }
    public string? Model { get; set; }
    public string? Manufacturer { get; set; }
    public string? CostInCredits { get; set; }
    public string? Crew { get; set; }
    public string? Consumables { get; set; }
    public string? HyperdriveRating { get; set; }
    public string? Mglt { get; set; }
    public string? StarshipClass { get; set; }
}