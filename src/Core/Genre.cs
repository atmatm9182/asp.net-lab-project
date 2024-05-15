using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("genre", Schema = "movies")]
public class Genre
{
    public int GenreId { get; set; }
    public string? GenreName { get; set; }
}
