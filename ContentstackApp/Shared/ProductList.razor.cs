using ContentstackApp.Content;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace ContentstackApp.Shared
{
    public partial class ProductList
    {
        [Parameter]
        public List<ProductDetail> ProductDetailList { get; set; }

        [Parameter]
        public CardsStyle CardsStyle { get; set; }
    }
}
