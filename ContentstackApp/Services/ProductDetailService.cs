using ContentstackApp.Content;
using ContentstackApp.Helpers;
using ContentstackApp.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContentstackApp.Services
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly HttpClient _httpClient;
        private readonly ContenstackSettings _contenstackSettings;

        public ProductDetailService(HttpClient httpClient,
                                    ContenstackSettings contenstackSettings)
        {
            _httpClient = httpClient;
            _contenstackSettings = contenstackSettings;
        }

        //Get products data.
        public async Task<ResponseProductDetail> GetProductDetailDataAsync(string id)
        {
            string uri = string.Format("{0}{1}?{2}", _contenstackSettings.Uris.Product,
                                                     id,
                                                     _contenstackSettings.AccessData.Enviroment);

            ResponseProductDetail responseProduct = await _httpClient.GetJsonAsync<ResponseProductDetail>(uri);

            return responseProduct;
        }
    }
}
