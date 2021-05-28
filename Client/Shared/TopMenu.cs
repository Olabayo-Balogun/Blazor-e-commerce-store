using AyacOnlineStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Shared
{
    public partial class TopMenu
    {
        private Product selectedProduct;
        protected override void OnInitialized()
        {
            CartService.OnChange += StateHasChanged;
        }

        public void Dispose()
        {
            CartService.OnChange -= StateHasChanged;
        }

        private int GetProductCount()
        {
            var cart = LocalStorage.GetItem<List<ProductVariant>>("cart");
            return cart != null ? cart.Count : 0;
        }

        private void HandleSearch(Product product)
        {
            if (product == null) return;
            selectedProduct = product;
            NavigationManager.NavigateTo($"product/{selectedProduct.Id}");

        }

        private async Task<IEnumerable<Product>> SearchProduct(string searchText)
        {
            var response = await ProductService.SearchProducts(searchText);
            return response;
        }
    }
}
