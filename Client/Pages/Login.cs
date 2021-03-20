using AyacOnlineStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Pages
{
    public partial class Login
    {
        private User user = new User();

        private async void HandleLogin()
        {
            Console.WriteLine("Log me in!");
            await LocalStorage.SetItemAsync<string>("username", user.Username);
            await AuthenticationStateProvider.GetAuthenticationStateAsync();
            NavigationManager.NavigateTo("");
        }
    }
}
