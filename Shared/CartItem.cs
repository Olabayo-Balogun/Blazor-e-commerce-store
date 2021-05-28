using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyacOnlineStore.Shared
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int PurchaseOptionId { get; set; }
        public string ProductTitle { get; set; }
        public string PurchaseOptionName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
    }
}
