using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("movie_cast", Schema = "movies")]
public class MovieCast
{
    public Movie? Movie { get; set; }
    public int? MovieId { get; set; }

    public Gender? Gender { get; set; }
    public int? GenderId { get; set; }

    public Person? Person { get; set; }
    public int? PersonId { get; set; }

    public string? CharacterName { get; set; }
    public int? CastOrder { get; set; }
}
