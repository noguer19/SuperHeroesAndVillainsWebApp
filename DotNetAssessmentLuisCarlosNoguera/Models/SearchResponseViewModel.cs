using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Models
{
    public class SearchResponseViewModel
    {
        public string Response { get; set; }
        public string Error { get; set; }
        public string ResultsFor { get; set; }
        public List<Character> Results { get; set; }
    }
}
