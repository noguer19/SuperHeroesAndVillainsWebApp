using Newtonsoft.Json;
namespace SuperHeroesAndVillainsApp.Web.Models;

public class CharacterRepository : ICharacterRepository
{
    private readonly HttpClient httpClient;

    public CharacterRepository(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<Character> GetCharacterById(int characterId)
    {
        try
        {
            var apiResponse = await httpClient.GetAsync($"{httpClient.BaseAddress}/{characterId}");
            string apiResponseAsString = await apiResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Character>(apiResponseAsString);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<SearchResponseViewModel> GetCharactersByName(string characterName)
    {
        try
        {
            var url = $"{httpClient.BaseAddress}/search/{characterName}";
            var apiResponse = await httpClient.GetAsync(url);
            string apiResponseAsString = await apiResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SearchResponseViewModel>(apiResponseAsString);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
