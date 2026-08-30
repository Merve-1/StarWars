using API.Endpoints;
using API.Extensions;
using Infrastructure;
using Infrastructure.Swapi;

var builder = WebApplication.CreateBuilder(args);

//services
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApiServices();

var app = builder.Build();

//Middleware pipeline
app.UseApiPipeline();

//Endpoints
app.MapStarshipEndpoints();

app.Run();