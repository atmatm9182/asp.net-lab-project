using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("gender", Schema = "movies")]
public class Gender
{
    public int GenderId { get; set; }
    [Column("gender")]
    public string? GenderName { get; set; }
}
