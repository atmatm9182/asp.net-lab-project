using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("production_country", Schema = "movies")]
public class ProductionCountry
{
    public Movie? Movie { get; set; }
    [ForeignKey(nameof(Movie))]
    public int? MovieId { get; set; }

    public Country? Country { get; set; }
    [ForeignKey(nameof(Country))]
    public int? CountryId { get; set; }
}
