using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Api
{
    public interface IApiConfiguration
    {
        string GetBaseUrlWithToken();
    }
}
