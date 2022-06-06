namespace SuperHeroesAndVillainsApp.Web.Models;

public class SearchResponseViewModel : IResponseViewModel
{
    public List<Character> Results { get; set; }
    public string Response { get; set; }
    public string Error { get; set; }
}
