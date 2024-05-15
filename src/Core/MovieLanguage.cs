using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("movie_languages", Schema = "movies")]
public class MovieLanguage
{
    public Movie? Movie { get; set; }
    [ForeignKey(nameof(Movie))]
    public int? MovieId { get; set; }

    public Language? Language { get; set; }
    [ForeignKey(nameof(Language))]
    public int? LanguageId { get; set; }

    public LanguageRole? LanguageRole { get; set; }
    [ForeignKey(nameof(LanguageRole))]
    public int? LanguageRoleId { get; set; }

}
