using System.ComponentModel.DataAnnotations;

namespace Game_Library;

public class Game
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(50)]
    public string? Name { get; set; }
    
    public string? Genre { get; set; }
    
    [Range(1, 50)]
    public int GenreId { get; set; }
    
    [Range(1, 100)]
    public decimal Price { get; set; }
    
    public DateOnly ReleaseDate { get; set; }
}

