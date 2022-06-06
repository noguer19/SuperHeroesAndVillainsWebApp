using System.Text.Json.Serialization;

namespace SuperHeroesAndVillainsApp.Web.Models;

public class CharacterBiography
{
    [JsonPropertyName("full-name")]
    public string FullName { get; set; }

    [JsonPropertyName("alter-egos")]
    public string AlterEgos { get; set; }
    public ICollection<string> Aliases { get; set; }

    [JsonPropertyName("place-of-birth")]
    public string PlaceOfBirth { get; set; }

    [JsonPropertyName("first-appearance")]
    public string FirstAppearance { get; set; }
    public string Publisher { get; set; }
    public string Alignment { get; set; }
}
