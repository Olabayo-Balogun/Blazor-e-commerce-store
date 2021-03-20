using AyacOnlineStore.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Pages
{
    public partial class ProductDetails
    {
        private Product product = new Product();

        private int currentPurchaseOptionId = 1;

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            product = await ProductService.GetProduct(Id);
            if (product.Variants.Count > 0)
            {
                currentPurchaseOptionId = product.Variants[0].PurchaseOptionId;
            }
        }

        private ProductVariant GetSelectedVariant()
        {
            var variant = product.Variants.FirstOrDefault(v => v.PurchaseOptionId == currentPurchaseOptionId);
            return variant;
        }

        private async Task AddToCart()
        {
            await CartService.AddToCart(GetSelectedVariant());
        }
    }
}
