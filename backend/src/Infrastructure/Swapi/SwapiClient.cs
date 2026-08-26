using System.Net.Http.Json;
using Infrastructure.Swapi.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Swapi;

public class SwapiClient : ISwapiClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<SwapiClient> _logger;

    public SwapiClient(HttpClient httpClient, IOptions<SwapiOptions> options, ILogger<SwapiClient> logger)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(options.Value.BaseUrl);
        _httpClient.Timeout = TimeSpan.FromSeconds(options.Value.TimeoutSeconds);
        _logger = logger;
    }

    public async Task<SwapiStarshipResponse?> GetStarshipByIdAsync(string id, CancellationToken ct = default)
    {
        var response = await _httpClient.GetAsync($"starships/{id}", ct);

        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            return null;

        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<SwapiStarshipResponse>(cancellationToken: ct);
    }
    public async Task<IReadOnlyList<SwapiStarshipResult>> GetStarshipsAsync(CancellationToken ct = default)
    {
        var response = await _httpClient.GetAsync("starships", ct);
        response.EnsureSuccessStatusCode();

        var payload = await response.Content.ReadFromJsonAsync<SwapiStarshipListResponse>(cancellationToken: ct);
        return payload?.Results ?? [];
    }
}

