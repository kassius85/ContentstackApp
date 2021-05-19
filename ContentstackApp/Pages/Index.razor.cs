using ContentstackApp.Content;
using ContentstackApp.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ContentstackApp.Pages
{
    public partial class Index
    {
        [Inject]
        private IHomeService HomeService { get; set; }

        public ResponseHome ResponseHome { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ResponseHome = await HomeService.GetHomeDataAsync();

            await base.OnInitializedAsync();
        }
    }
}