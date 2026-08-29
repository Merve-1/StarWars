using Application;
using Application.Interfaces;
using Application.PreFlightChecks;

namespace API.Endpoints;

public static class StarshipEndpoints
{
    public static void MapStarshipEndpoints(this WebApplication app)
    {
        app.MapGet("/api/starships", async (ISwapiClient swapiClient, CancellationToken ct) =>
        {
            var starships = await swapiClient.GetStarshipsAsync(ct);
            return Results.Ok(starships);
        });
        app.MapGet("/api/starships/{id}", async (string id, ISwapiClient swapiClient, CancellationToken ct) =>
        {
            var starship = await swapiClient.GetStarshipByIdAsync(id, ct);
            return starship is null ? Results.NotFound() : Results.Ok(starship);
        });
        app.MapGet("/api/starships/{id}/preflight-check",
            async (string id, ISwapiClient swapiClient, CancellationToken ct) =>
            {
                var starship = await swapiClient.GetStarshipByIdAsync(id, ct);
                if(starship is null) return Results.NotFound();

                var pipeline = PreFlightCheckPipelineFactory.Build();
                var result = pipeline.Handle(starship, new PreFlightCheckResult());
                return Results.Ok(result);
            });
    }
}