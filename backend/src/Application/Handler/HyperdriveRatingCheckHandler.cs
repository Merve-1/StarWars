using Application.Dtos;
using Application.PreFlightChecks;

namespace Application.Handler;

public class HyperdriveRatingCheckHandler: PreFlightCheckHandlerBase
{
    protected override void Check(StarshipDto starship, PreFlightCheckResult result)
    {
        if (starship.HyperdriveRating is null or <= 0)
        {
            result.Passed = false;
            result.Issues.Add("Hyperdrive rating is missing or invalid.");
        }
    }
}