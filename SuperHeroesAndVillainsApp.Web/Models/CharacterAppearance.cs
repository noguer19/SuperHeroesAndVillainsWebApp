using System.Text.Json.Serialization;

namespace SuperHeroesAndVillainsApp.Web.Models;

public class CharacterAppearance
{
    public string Gender { get; set; }
    public string Race { get; set; }
    public ICollection<string> Height { get; set; }
    public ICollection<string> Weight { get; set; }

    [JsonPropertyName("eye-color")]
    public string EyeColor { get; set; }

    [JsonPropertyName("hair-color")]
    public string HairColor { get; set; }
}
