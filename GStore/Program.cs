using GameStore.Api.EndPoints;
using GStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGameEndPoints();


//html routes
app.Run();

// GET general
        //group.MapGet("/", () => "Hello World!");