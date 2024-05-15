using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("movie", Schema = "movies")]
public class Movie
{
    public int MovieId { get; set; }
    public string? Title { get; set; }
    public int? Budget { get; set; }
    public string? Homepage { get; set; }
    public string? Overview { get; set; }
    public float? Popularity { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public long? Revenue { get; set; }
    public int? Runtime { get; set; }
    public string? MovieStatus { get; set; }
    public string? Tagline { get; set; }
    public float? VoteAverage { get; set; }
    public int? VoteCount { get; set; }
}
