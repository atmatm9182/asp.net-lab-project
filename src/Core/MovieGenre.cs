using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("movie_genre", Schema = "movies")]
public class MovieGenre
{
    public Movie? Movie { get; set; }
    [ForeignKey(nameof(Movie))]
    public int? MovieId { get; set; }

    public Genre? Genre { get; set; }
    [ForeignKey(nameof(Genre))]
    public int? GenreId { get; set; }
}
