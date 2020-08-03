using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Models
{
    public interface IResponseViewModel
    {
        string Response { get; set; }
        string Error { get; set; }
    }
}
