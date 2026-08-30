using Application.Dtos;
using Application.PreFlightChecks;

namespace Application.Handler;

public class CrewCapacityCheckHandler: PreFlightCheckHandlerBase
{
    protected override void Check(StarshipDto starship, PreFlightCheckResult result)
    {
        if (starship.Crew is null or 0)
        {
            result.Passed = false;
            result.Issues.Add("Crew capacity data is missing or zero.");
        }
    }
}