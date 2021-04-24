using AyacOnlineStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Pages
{
    public partial class Cart
    {
        List<CartItem> cartItems = new List<CartItem>();

        bool orderPlaced = false;

        protected override async Task OnInitializedAsync()
        {
            cartItems = await CartService.GetCartItems();
        }

        private async Task DeleteItem(CartItem item)
        {
            await CartService.DeleteItem(item);
            cartItems = await CartService.GetCartItems();
        }
        private async Task PlaceOrder()
        {
            orderPlaced = true;
            await CartService.EmptyCart();
        }
    }
}
