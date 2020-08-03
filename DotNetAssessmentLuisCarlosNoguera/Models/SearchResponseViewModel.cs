using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Models
{
    public class SearchResponseViewModel : IResponseViewModel
    {
        public List<Character> Results { get; set; }
        public string Response { get; set; }
        public string Error { get; set; }
    }
}
