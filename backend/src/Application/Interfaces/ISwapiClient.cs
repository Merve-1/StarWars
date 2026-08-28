using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Dtos;

namespace Application.Interfaces;

public interface ISwapiClient
{
    Task<StarshipDto?> GetStarshipByIdAsync(string id, CancellationToken ct = default);
    Task<IReadOnlyList<StarshipDto>> GetStarshipsAsync(CancellationToken ct = default);
}