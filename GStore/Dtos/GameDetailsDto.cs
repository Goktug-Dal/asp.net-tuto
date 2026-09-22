using Microsoft.AspNetCore.Mvc;

namespace GStore.Api.Dtos;

//how data will work between client and server
// sort of models
public record GameDetailsDto(
    int Id,
    string Name,
    int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);

