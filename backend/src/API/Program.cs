using API.Endpoints;
using Infrastructure;
using Infrastructure.Swapi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddInfrastructure(builder.Configuration);
var app = builder.Build();

app.MapStarshipEndpoints();

app.Run();