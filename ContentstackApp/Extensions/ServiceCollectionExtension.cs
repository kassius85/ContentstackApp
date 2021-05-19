using ContentstackApp.Helpers;
using ContentstackApp.Interfaces;
using ContentstackApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ContentstackApp.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterGeneralServices(this IServiceCollection service, ContenstackSettings contenstackSettings)
        {
            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(contenstackSettings.AccessData.ApiUrl)
            };

            // Add headers
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Custom headers
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("api_key", contenstackSettings.AccessData.ApiKey);
            httpClient.DefaultRequestHeaders.Add("access_token", contenstackSettings.AccessData.AccessToken);

            // HttpClient services
            service.AddScoped(_ => httpClient);

            // Contenstack Settings services
            service.AddScoped(_ => contenstackSettings);
        }

        public static void RegisterDataServices(this IServiceCollection service)
        {
            service.AddScoped<IHomeService, HomeService>();
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IProductDetailService, ProductDetailService>();
            service.AddScoped<IHeaderService, HeaderService>();
            service.AddScoped<IMenuService, MenuService>();
        }
    }
}
