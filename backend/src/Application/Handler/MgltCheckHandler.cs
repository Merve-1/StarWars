using Application.Dtos;
using Application.PreFlightChecks;

namespace Application.Handler;

public class MgltCheckHandler: PreFlightCheckHandlerBase
{
    protected override void Check(StarshipDto starship, PreFlightCheckResult result)
    {
        if (starship.Mglt is null or <= 0)
        {
            result.Passed = false;
            result.Issues.Add("MGLT (sublight speed) is missing or invalid.");
        }
    }
}