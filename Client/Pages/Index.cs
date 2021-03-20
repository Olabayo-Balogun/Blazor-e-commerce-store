using AyacOnlineStore.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Pages
{
    public partial class Index
    {
        [Parameter]
        public string CategoryUrl { get; set; }

        private Category category = null;

        protected override async Task OnParametersSetAsync()
        {
            await ProductService.LoadProducts(CategoryUrl);

            if (CategoryUrl != null)
            {
                category = CategoryService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));
            }
            else
            {
                category = null;
            }

            await StatisticsService.IncrementVisits();
            await StatisticsService.GetVisits();
        }
    }
}
