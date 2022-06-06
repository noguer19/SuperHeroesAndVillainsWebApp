﻿using Newtonsoft.Json;
using SuperHeroesAndVillainsApp.Web.ApiConfiguration;
namespace SuperHeroesAndVillainsApp.Web.Models;

public class CharacterRepository : ICharacterRepository
{
    private readonly IApiConfiguration _apiConfiguration;
    private readonly string _apiBaseUrl;

    public CharacterRepository(IApiConfiguration apiConfiguration)
    {
        _apiConfiguration = apiConfiguration;
        _apiBaseUrl = _apiConfiguration.GetBaseUrlWithToken();
    }

    public async Task<Character> GetCharacterById(int characterId)
    {
        Character character = new Character();
        try
        {
            using var httpClient = new HttpClient();
            var apiResponse = await httpClient.GetAsync($"{_apiBaseUrl}/{characterId}");
            string apiResponseAsString = await apiResponse.Content.ReadAsStringAsync();
            character = JsonConvert.DeserializeObject<Character>(apiResponseAsString);
        }
        catch (Exception ex)
        {
            throw;
        }

        return character;
    }

    public async Task<SearchResponseViewModel> GetCharactersByName(string characterName)
    {
        SearchResponseViewModel responseViewModel = new SearchResponseViewModel();
        if (!string.IsNullOrEmpty(characterName))
        {
            try
            {
                using var httpClient = new HttpClient();
                var apiResponse = await httpClient.GetAsync($"{_apiBaseUrl}/search/{characterName}");
                string apiResponseAsString = await apiResponse.Content.ReadAsStringAsync();
                responseViewModel = JsonConvert.DeserializeObject<SearchResponseViewModel>(apiResponseAsString);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        return responseViewModel;
    }
}
