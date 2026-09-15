using GameStore.Api.EndPoints;
using GStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation();

var app = builder.Build();


app.MapGameEndPoints();


//html routes
app.Run();

// GET general
        //group.MapGet("/", () => "Hello World!");