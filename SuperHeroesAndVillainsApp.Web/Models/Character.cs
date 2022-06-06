namespace SuperHeroesAndVillainsApp.Web.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CharacterImage Image { get; set; }
    public CharacterAppearance Appearance { get; set; }
    public CharacterBiography Biography { get; set; }
    public CharacterPowerstats Powerstats { get; set; }
    public CharacterWork Work { get; set; }
    public CharacterConnections Connections { get; set; }
}
