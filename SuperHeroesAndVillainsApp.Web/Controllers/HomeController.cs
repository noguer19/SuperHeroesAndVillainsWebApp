using Microsoft.AspNetCore.Mvc;
using SuperHeroesAndVillainsApp.Web.Models;
using System.Diagnostics;

namespace SuperHeroesAndVillainsApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly ICharacterRepository _characterRepository;

    public HomeController(ICharacterRepository characterRepository)
    {
        _characterRepository = characterRepository;
    }

    public async Task<IActionResult> Index(string characterName)
    {
        try
        {
            if (string.IsNullOrEmpty(characterName))
                return View(new SearchResponseViewModel());

            var characterList = await _characterRepository.GetCharactersByName(characterName);
            TempData["searchTerm"] = characterName;
            return View(characterList);
        }
        catch (Exception ex)
        {
            ViewData["ErrorMessage"] = "There was an error when proccessing your current request. Please check your internet connection and try again or contact the tech suppport team.";
            return View("Error");
        }
    }

    public async Task<IActionResult> Character(int id)
    {
        try
        {
            var character = await _characterRepository.GetCharacterById(id);
            if (character.Id == 0)
            {
                Response.StatusCode = 404;
                return View("CharacterNotFound");
            }
            return View(character);
        }
        catch (Exception ex)
        {
            ViewData["ErrorMessage"] = "There was an error when processing your current request. Please check your internet connection and try again or contact the tech suppport team.";
            return View("Error");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
