namespace SuperHeroesAndVillainsApp.Web.Models;

public interface ICharacterRepository
{
    Task<SearchResponseViewModel> GetCharactersByName(string name);
    Task<Character> GetCharacterById(int id);
}
