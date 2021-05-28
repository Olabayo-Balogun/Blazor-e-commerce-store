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

        private CartItem cartItem = new CartItem { Quantity = 1 };

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
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
            var productVariant = GetSelectedVariant();
            cartItem.PurchaseOptionId = productVariant.PurchaseOptionId;
            cartItem.PurchaseOptionName = productVariant.PurchaseOption.Name;
            cartItem.Image = product.Image;
            cartItem.Price = productVariant.Price;
            cartItem.ProductId = productVariant.ProductId;
            cartItem.ProductTitle = product.Title;

           if(cartItem.Quantity < 1)
            {
                return;
             }
            await CartService.AddToCart(cartItem);
        }

        private string GetViewString()
        {
            if(product.Views > 1000000)
            {
                return $"{((float)product.Views / 1000000).ToString("#.##")}M";
            }
            else if (product.Views > 100000)
            {
                return $"{((float)product.Views / 1000).ToString("#")}k";
            }
            else if (product.Views > 1000)
            {
                return $"{((float)product.Views / 1000).ToString("#.##")}K";
            }
            else
            {
                return product.Views.ToString("0##");
            }
        }
    }
}
