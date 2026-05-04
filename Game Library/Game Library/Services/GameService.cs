using System;

namespace Game_Library.Services;

public class GameService(HttpClient httpClient)
{
    public async Task<List<Game>> GetGamesAsync()
    {
        try
        {
            return await httpClient.GetFromJsonAsync<List<Game>>("http://localhost:5113/games") ?? new List<Game>();
        }
        catch (Exception ex)
        {
            // Log the exception (you can use a logging framework here)
            Console.Error.WriteLine($"Error fetching games: {ex.Message}");
            return new List<Game>(); // Return an empty list in case of error
        }
    }

    public async Task<Game?> GetGameByIdAsync(int id)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<Game>($"http://localhost:5113/games/{id}");
        }
        catch (Exception ex)
        {
            // Log the exception
            Console.Error.WriteLine($"Error fetching game with ID {id}: {ex.Message}");
            return null; // Return null in case of error
        }
    }

    public async Task<Game> AddGameAsync(Game game)
    {
        try
        {
            // Create a DTO object that matches what the API expects
            var createGameDto = new
            {
                Name = game.Name,
                GenreId = game.GenreId,
                Price = game.Price,
                ReleaseDate = game.ReleaseDate.ToString("yyyy-MM-dd")
            };

            var response = await httpClient.PostAsJsonAsync("http://localhost:5113/games", createGameDto);
            response.EnsureSuccessStatusCode(); // Throw an exception if the response is not successful
            return await response.Content.ReadFromJsonAsync<Game>() ?? throw new Exception("Failed to parse added game");
        }
        catch (Exception ex)
        {
            // Log the exception
            Console.Error.WriteLine($"Error adding game: {ex.Message}");
            throw; // Re-throw the exception in case of error
        }
    }
}
