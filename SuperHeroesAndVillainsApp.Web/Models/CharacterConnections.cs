using System.Text.Json.Serialization;

namespace SuperHeroesAndVillainsApp.Web.Models;

public class CharacterConnections
{
    [JsonPropertyName("group-affiliation")]
    public string GroupAffiliations { get; set; }
    public string Relatives { get; set; }
}
