using Application.Dtos;
using Application.Interfaces;

namespace Application.PreFlightChecks;

public abstract class PreFlightCheckHandlerBase : IPreFlightCheckHandler
{
    private IPreFlightCheckHandler? _next;
    public void SetNext(IPreFlightCheckHandler next) => _next = next;

    public PreFlightCheckResult Handle(StarshipDto starship, PreFlightCheckResult result)
    {
        Check(starship, result);
        return _next is null ? result :  _next.Handle(starship, result);
    }
    protected abstract void Check(StarshipDto starship, PreFlightCheckResult result);
}