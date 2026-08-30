using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using Application.Dtos;
using Application.Interfaces;

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


   
    public async Task<StarshipDto?> GetStarshipByIdAsync(string id, CancellationToken ct = default)
    {
        var response = await _httpClient.GetAsync($"starships/{id}", ct);

        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            return null;

        response.EnsureSuccessStatusCode();
        var raw = await response.Content.ReadFromJsonAsync<SwapiStarshipResponse>(cancellationToken: ct);

        return raw?.Result is null ? null : SwapiStarshipMapper.ToDto(raw.Result);
    }

    public async Task<IReadOnlyList<StarshipDto>> GetStarshipsAsync(CancellationToken ct = default)
    {
        var response = await _httpClient.GetAsync("starships", ct);
        response.EnsureSuccessStatusCode();

        var payload = await response.Content.ReadFromJsonAsync<SwapiStarshipListResponse>(cancellationToken: ct);
        var results = payload?.Results ?? [];

        return results.Select(SwapiStarshipMapper.ToDto).ToList();
    }
}

