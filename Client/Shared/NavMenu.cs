using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Shared
{
    public partial class NavMenu
    {
        private bool collapseNavMenu = true;

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        protected override async Task OnInitializedAsync()
        {
            await CategoryService.LoadCategories();
        }

        private async void Logout()
        {
            await LocalStorage.RemoveItemAsync("username");
            await AuthenticationStateProvider.GetAuthenticationStateAsync();
        }
    }
}
