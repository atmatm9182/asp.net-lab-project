using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("language", Schema = "movies")]
public class Language
{
    public int LanguageId { get; set; }
    public string? LanguageCode { get; set; }
    public string? LanguageName { get; set; }
}
