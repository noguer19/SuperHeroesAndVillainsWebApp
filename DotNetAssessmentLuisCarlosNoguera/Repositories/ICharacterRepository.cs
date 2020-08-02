using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Models
{
    public interface ICharacterRepository
    {
        Task<SearchResponseViewModel> GetCharactersByName(string name);
        Task<Character> GetCharacterById(int id);
    }
}
