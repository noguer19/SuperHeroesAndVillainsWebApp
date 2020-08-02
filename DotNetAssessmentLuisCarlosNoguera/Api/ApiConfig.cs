using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Api
{
    public class ApiConfig : IApiConfiguration
    {
        private IConfiguration _config;
        private string _baseApiUrl;
        private string _authToken;
        public ApiConfig(IConfiguration config)
        {
            _config = config;
            _baseApiUrl = config["BaseApiUrl"];
            _authToken = config["AuthToken"];
        }

        public string GetBaseUrlWithToken()
        {
            return _baseApiUrl + _authToken;
        }
    }
}
