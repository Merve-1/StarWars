using Application.Dtos;
using Application.PreFlightChecks;

namespace Application.Handler;

public class CostIntegrityCheckHandler: PreFlightCheckHandlerBase
{
    protected override void Check(StarshipDto starship, PreFlightCheckResult result)
    {
        if (starship.CostInCredits is null or < 0)
        {
            result.Passed = false;
            result.Issues.Add("Cost in credits is missing or negative.");
        }
    }
}