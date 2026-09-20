
using GameStore.Api.Data;
using GameStore.Api.EndPoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation(); // for validations 
builder.AddGameStoreDb();



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