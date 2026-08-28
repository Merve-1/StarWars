namespace Application.Dtos;

public class StarshipDto
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public decimal? CostInCredits { get; set; }
    public int? Crew { get; set; }
    public string Consumables { get; set; } = string.Empty;
    public decimal? HyperdriveRating { get; set; }
    public decimal? Mglt { get; set; }
    public string StarshipClass  { get; set; } = string.Empty;
}