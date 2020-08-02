using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetAssessmentLuisCarlosNoguera.Models;
using DotNetAssessmentLuisCarlosNoguera.Api;
using Microsoft.Extensions.Options;
using System.Net.Http;

namespace DotNetAssessmentLuisCarlosNoguera.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICharacterRepository _characterRepository;

        public HomeController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task<IActionResult> Index(string characterName)
        {
            SearchResponseViewModel result = new SearchResponseViewModel();
            try
            {
                result = await _characterRepository.GetCharactersByName(characterName);
                ViewData["searchTerm"] = characterName;
                return View(result);
            }
            catch(Exception ex)
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
}
