using Microsoft.Extensions.Configuration;

namespace SuperHeroesAndVillainsApp.Web.ApiConfiguration
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
