using Bibliotekarz.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Bibliotekarz.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.


        //Configuracja bazy danych (DbContextu)
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection"))
            .EnableSensitiveDataLogging().EnableDetailedErrors()
        );

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        // Konfiguracja Swaggera
        builder.Services.AddSwaggerGen();
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
            app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();

        app.UseAuthorization();

        // Use CORS policy
        app.UseCors("AllowAll");

        app.MapControllers();
        app.MapFallbackToFile("index.html");

        app.Run();
    }
}
