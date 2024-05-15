using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("country", Schema = "movies")]
public class Country
{
    public int CountryId { get; set; }
    public string? CountryIsoCode { get; set; }
    public string? CountryName { get; set; }
}
