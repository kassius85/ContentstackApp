using ContentstackApp.Content;
using ContentstackApp.Helpers;
using ContentstackApp.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContentstackApp.Services
{
    public class HeaderService : IHeaderService
    {
        private readonly HttpClient _httpClient;
        private readonly ContenstackSettings _contenstackSettings;

        public HeaderService(HttpClient httpClient,
                             ContenstackSettings contenstackSettings)
        {
            _httpClient = httpClient;
            _contenstackSettings = contenstackSettings;
        }

        //Get header data
        public async Task<ResponseHeader> GetHeaderDataAsync()
        {
            // Make call to get header data.
            string uri = string.Format("{0}?{1}", _contenstackSettings.Uris.Header,
                                                  _contenstackSettings.AccessData.Enviroment);
            ResponseHeader responseHeader = await _httpClient.GetJsonAsync<ResponseHeader>(uri);

            return responseHeader;
        }
    }
}
