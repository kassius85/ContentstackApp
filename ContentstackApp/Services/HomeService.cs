using ContentstackApp.Content;
using ContentstackApp.Helpers;
using ContentstackApp.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContentstackApp.Services
{
    public class HomeService : IHomeService
    {
        private readonly HttpClient _httpClient;
        private readonly ContenstackSettings _contenstackSettings;

        public HomeService(HttpClient httpClient,
                           ContenstackSettings contenstackSettings)
        {
            _httpClient = httpClient;
            _contenstackSettings = contenstackSettings;
        }

        // Get home page data.
        public async Task<ResponseHome> GetHomeDataAsync()
        {
            string uri = string.Format("{0}?{1}{2}", _contenstackSettings.Uris.Home,
                                                     _contenstackSettings.AccessData.Enviroment,
                                                     _contenstackSettings.IncludedContent.Product);
            ResponseHome responseHome = await _httpClient.GetJsonAsync<ResponseHome>(uri);

            return responseHome;
        }
    }
}
