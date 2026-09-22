using GameStore.Api.Context;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

using GameStore.Api.Models;

public static class DataExpensions{
    
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();

        dbContext.Database.Migrate();
    }
    

    public static void AddGameStoreDb(this WebApplicationBuilder builder)
    {
    var connString = builder.Configuration.GetConnectionString("GameStore"); // define db with its name
    builder.Services.AddScoped<GameStoreContext>();
    builder.Services.AddDbContext<GameStoreContext>(options =>
        options
            .UseSqlite(connString)
            .UseSeeding((context, _) =>
            {
                if (!context.Set<Genre>().Any())
                {
                    context.Set<Genre>().AddRange(
                        new Genre { Name = "Fighting" },
                        new Genre { Name = "RPG" },
                        new Genre { Name = "Platformer" },
                        new Genre { Name = "Racing" },
                        new Genre { Name = "Sports" }
                    );

                    context.SaveChanges();
                }
            }));
    }
}