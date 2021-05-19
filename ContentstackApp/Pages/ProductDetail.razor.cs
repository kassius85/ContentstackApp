using ContentstackApp.Content;
using ContentstackApp.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ContentstackApp.Pages
{
    public partial class ProductDetail
    {
        [Inject]
        private IProductDetailService ProductDetailService { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string BackgroundColor { get; set; }

        public ResponseProductDetail ResponseProduct { get; set; }

        private string Style { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ResponseProduct = await ProductDetailService.GetProductDetailDataAsync(Id);

            // Get personalized styles.
            Style = string.Format("font-size: {0}px;",
                                    ResponseProduct.Product.TitleSize);

            await base.OnInitializedAsync();
        }
    }
}
