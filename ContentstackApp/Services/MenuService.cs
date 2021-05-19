using ContentstackApp.Content;
using ContentstackApp.Helpers;
using ContentstackApp.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContentstackApp.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient _httpClient;
        private readonly ContenstackSettings _contenstackSettings;

        public MenuService(HttpClient httpClient,
                           ContenstackSettings contenstackSettings)
        {
            _httpClient = httpClient;
            _contenstackSettings = contenstackSettings;
        }

        //Get menu data.
        public async Task<ResponseMenu> GetMenuDataAsync()
        {
            string uri = string.Format("{0}?{1}", _contenstackSettings.Uris.Menu,
                                                  _contenstackSettings.AccessData.Enviroment);
            ResponseMenu responseMenu = await _httpClient.GetJsonAsync<ResponseMenu>(uri);

            return responseMenu;
        }
    }
}
