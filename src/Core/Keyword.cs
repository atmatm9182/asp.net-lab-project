using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("keyword", Schema = "movies")]
public class Keyword
{
    public int KeywordId { get; set; }
    public string? KeywordName { get; set; }
}
