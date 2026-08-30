namespace API.Extensions;

public static class ApiServiceCollectionExtensions
{
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        services.AddOpenApi();
        services.AddCors(options =>
        {
            options.AddPolicy("AllowFrontends", policy =>
            {
                policy.WithOrigins("http://localhost:4200") // Angular dev server 
                    .AllowAnyHeader()
                    .AllowAnyMethod();

            });
        });
        return services;
    }
}