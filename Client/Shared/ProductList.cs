using AyacOnlineStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Shared
{
    public partial class ProductList
    {
        protected override void OnInitialized()
        {
            ProductService.OnChange += StateHasChanged;
        }

        public void Dispose()
        {
            ProductService.OnChange -= StateHasChanged;
        }

        private string GetPriceText(Product product)
        {
            var variants = product.Variants;
            if (variants.Count == 0)
            {
                return string.Empty;
            }
            else if (variants.Count == 1)
            {
                return $"₦{variants[0].Price}";
            }
            decimal minPrice = variants.Min(v => v.Price);
            return $"Prices as low as ₦{minPrice}";
        }
    }
}
