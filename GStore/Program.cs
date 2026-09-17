using GameStore.Api.Context;
using GameStore.Api.Data;
using GameStore.Api.EndPoints;
using GStore.Api.Dtos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation(); // for validations 

var connString = "Data Source=GameStore.db"; // define db with its name
builder.Services.AddDbContext<GameStoreContext>(options =>
    options.UseSqlite(connString));


var app = builder.Build();

app.MapGameEndPoints();

app.MigrateDb();

//html routes
app.Run();

// dotnet ef migrations add InitialCreate --output-dir Data\Migrations
// dotnet ef database update

// GET general
        //group.MapGet("/", () => "Hello World!");

// dotnet run