using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("person", Schema = "movies")]
public class Person
{
    public int PersonId { get; set; }
    public string? PersonName { get; set; }
}
