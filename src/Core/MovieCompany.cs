using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("movie_company", Schema = "movies")]
public class MovieCompany
{
    public ProductionCompany? Company { get; set; }
    public int? CompanyId { get; set; }

    public Movie? Movie { get; set; }
    public int? MovieId { get; set; }
}
