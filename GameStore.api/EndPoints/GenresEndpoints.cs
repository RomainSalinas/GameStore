using GameStore.api.Dtos;
using GameStore.api.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace GameStore.api.Controllers.EndPoints;

public static class GenresEndpoints
{
    public static void MapGenresEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/genres");

        group.MapGet("/", async (GameStoreContext dbContext) =>
            await dbContext.Genres.Select(genre => 
            new GenreDto(genre.Id, genre.Name))
            .AsNoTracking()
            .ToListAsync());
    }
}
