using Application.Dtos;
using Application.PreFlightChecks;

namespace Application.Handler;

public class ConsumablesCheckHandler : PreFlightCheckHandlerBase
{
    protected override void Check(StarshipDto starship, PreFlightCheckResult result)
    {
        if (string.IsNullOrWhiteSpace(starship.Consumables) ||
            starship.Consumables.Equals("unknown", StringComparison.OrdinalIgnoreCase))
        {
            result.Passed = false;
            result.Issues.Add("Consumables data are missing or negative.");
        }
    }
}