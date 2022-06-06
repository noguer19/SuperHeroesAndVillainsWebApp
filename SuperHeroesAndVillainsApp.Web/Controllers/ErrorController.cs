using Microsoft.AspNetCore.Mvc;

namespace SuperHeroesAndVillainsApp.Web.Controllers;

public class ErrorController : Controller
{
    [Route("Error/{statusCode}")]
    public IActionResult HttpStatusCodeResultHandler(int statusCode)
    {
        switch (statusCode)
        {
            case 404:
                ViewBag.ErrorMessage = "The resource you requested could not be found";
                break;
        }
        return View("NotFound");
    }
}
