using System.Globalization;
using Application.Dtos;
using Infrastructure.Swapi.Models;

namespace Infrastructure.Swapi;

public static class SwapiStarshipMapper
{
    public static StarshipDto ToDto(SwapiStarshipResult result)
    {
        var props = result.Properties;
        return new StarshipDto
        {
        
            Id = result.Uid ?? string.Empty,
            Name = props?.Name ?? string.Empty,
            Model = props?.Model ?? string.Empty,
            Manufacturer = props?.Manufacturer ?? string.Empty,
            CostInCredits = ParseDecimal(props?.CostInCredits),
            Crew = ParseInt(props?.Crew),
            Consumables = props?.Consumables ?? string.Empty,
            HyperdriveRating = ParseDecimal(props?.HyperdriveRating),
            Mglt = ParseDecimal(props?.Mglt),
            StarshipClass = props?.StarshipClass ?? string.Empty
        };

    }
   
    private static decimal? ParseDecimal(string? value) =>
        decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var result) ? result : null;
    
    private static int? ParseInt(string? value) =>
        int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var result) ? result : null;
}