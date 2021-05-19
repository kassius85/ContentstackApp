using ContentstackApp.Content;
using ContentstackApp.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContentstackApp.Pages
{
    public partial class Product
    {
        [Inject]
        private IProductService ProductService { get; set; }

        [Inject]
        private IProductDetailService ProductDetail { get; set; }

        public ResponseProduct ResponseProduct { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ResponseProduct = await ProductService.GetProductDataAsync();

            await base.OnInitializedAsync();
        }
    }
}
