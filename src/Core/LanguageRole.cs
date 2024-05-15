
using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("language_role", Schema = "movies")]
public class LanguageRole
{
    public int RoleId { get; set; }
    [Column("language_role")]
    public string? Role { get; set; }
}
