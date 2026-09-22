using Microsoft.AspNetCore.Mvc;

namespace GStore.Api.Dtos;

//how data will work between client and server
// sort of models
public record GameSummaryDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);

