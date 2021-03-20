using AyacOnlineStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Shared
{
    public partial class TopMenu
    {
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
    }
}
