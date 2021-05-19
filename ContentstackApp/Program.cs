using ContentstackApp.Extensions;
using ContentstackApp.Helpers;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ContentstackApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");


            ContenstackSettings contenstackSettings = builder.Configuration.GetSection("ContenstackSettings").Get<ContenstackSettings>();
            
            // General services.
            builder.Services.RegisterGeneralServices(contenstackSettings);

            // Register services to access data from API.
            builder.Services.RegisterDataServices();

            await builder.Build().RunAsync();
        }
    }
}
