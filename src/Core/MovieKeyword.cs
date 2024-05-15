using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("movie_keywords", Schema = "movies")]
public class MovieKeyword
{
    public Movie? Movie { get; set; }
    [ForeignKey(nameof(Movie))]
    public int? MovieId { get; set; }

    public Keyword? Keyword { get; set; }
    [ForeignKey(nameof(Keyword))]
    public int? KeywordId { get; set; }
}
