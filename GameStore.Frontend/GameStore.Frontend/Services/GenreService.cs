using System;

namespace GameStore.Frontend.Services;

public class GenreService(HttpClient httpClient)
{
    public async Task<List<Genre>> GetGenresAsync()
    {
        try
        {
            return await httpClient.GetFromJsonAsync<List<Genre>>("http://localhost:5113/genres") ?? new List<Genre>();
        }
        catch (Exception ex)
        {
            // Log the exception (you can use a logging framework here)
            Console.Error.WriteLine($"Error fetching genres: {ex.Message}");
            return new List<Genre>(); // Return an empty list in case of error
        }
    }

}
