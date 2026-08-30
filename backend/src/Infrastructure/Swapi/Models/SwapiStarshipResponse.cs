using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Infrastructure.Swapi.Models;

public class SwapiStarshipResponse
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("result")]
    public SwapiStarshipResult? Result { get; set; }
    
}

public class SwapiStarshipListResponse
{
   
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("total_records")]
    public int TotalRecords { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("results")]
    public List<SwapiStarshipResult>? Results { get; set; }
    
}

public class SwapiStarshipResult
{
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("properties")]
    public SwapiStarshipProperties? Properties { get; set; }
}

public class SwapiStarshipProperties
{
  
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; set; }

    [JsonPropertyName("cost_in_credits")]
    public string? CostInCredits { get; set; }

    [JsonPropertyName("crew")]
    public string? Crew { get; set; }

    [JsonPropertyName("consumables")]
    public string? Consumables { get; set; }

    [JsonPropertyName("hyperdrive_rating")]
    public string? HyperdriveRating { get; set; }

    [JsonPropertyName("MGLT")]
    public string? Mglt { get; set; }

    [JsonPropertyName("starship_class")]
    public string? StarshipClass { get; set; }}