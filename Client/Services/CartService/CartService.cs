using AyacOnlineStore.Client.Services.ProductService;
using AyacOnlineStore.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, IToastService toastService, IProductService productService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
        }

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                cart = new List<ProductVariant>();
            }

            cart.Add(productVariant);
            await _localStorage.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(productVariant.ProductId);
            _toastService.ShowSuccess(product.Title, "Added to your shopping cart:");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = new List<CartItem>();
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                return result;
            }

            foreach (var item in cart)
            {
                var product = await _productService.GetProduct(item.ProductId);
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    Image = product.Image,
                    PurchaseOptionId = item.PurchaseOptionId
                };

                var variant = product.Variants.Find(v => v.PurchaseOptionId == item.PurchaseOptionId);
                if (variant != null)
                {
                    cartItem.PurchaseOptionName = variant.PurchaseOption?.Name;
                    cartItem.Price = variant.Price;
                }
                result.Add(cartItem);
            }
            return result;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            { 
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.PurchaseOptionId == item.PurchaseOptionId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }
    }
}
