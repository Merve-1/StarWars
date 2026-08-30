using Application.Dtos;
using Application.PreFlightChecks;

namespace Application.Interfaces;

public interface IPreFlightCheckHandler
{
    void SetNext(IPreFlightCheckHandler next);
    PreFlightCheckResult Handle(StarshipDto starship, PreFlightCheckResult result);
}