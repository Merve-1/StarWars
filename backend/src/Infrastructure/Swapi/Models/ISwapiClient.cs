namespace Infrastructure.Swapi.Models;


public interface ISwapiClient
{
    Task<SwapiStarshipResponse?> GetStarshipByIdAsync(string id, CancellationToken ct = default);
    Task<IReadOnlyList<SwapiStarshipResult>> GetStarshipsAsync(CancellationToken ct = default);
}