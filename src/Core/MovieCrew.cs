using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("movie_crew", Schema = "movies")]
public class MovieCrew
{
    public Person? Person { get; set; }
    public int? PersonId { get; set; }

    public Movie? Movie { get; set; }
    public int? MovieId { get; set; }

    public Department? Department { get; set; }
    public int? DepartmentId { get; set; }

    public string? Job { get; set; }
}
