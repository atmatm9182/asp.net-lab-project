using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("production_company", Schema = "movies")]
public class ProductionCompany
{
    public int CompanyId { get; set; }
    public string? CompanyName { get; set; }
}
