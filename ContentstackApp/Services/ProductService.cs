using ContentstackApp.Content;
using ContentstackApp.Helpers;
using ContentstackApp.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContentstackApp.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly ContenstackSettings _contenstackSettings;

        public ProductService(HttpClient httpClient,
                              ContenstackSettings contenstackSettings)
        {
            _httpClient = httpClient;
            _contenstackSettings = contenstackSettings;
        }

        //Get products page data.
        public async Task<ResponseProduct> GetProductDataAsync()
        {
            string uri = string.Format("{0}?{1}{2}", _contenstackSettings.Uris.ProductsPage,
                                                     _contenstackSettings.AccessData.Enviroment,
                                                     _contenstackSettings.IncludedContent.Product);
            ResponseProduct responseProduct = await _httpClient.GetJsonAsync<ResponseProduct>(uri);

            return responseProduct;
        }
    }
}
