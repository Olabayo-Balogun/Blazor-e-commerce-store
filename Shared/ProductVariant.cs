using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AyacOnlineStore.Shared
{
    public class ProductVariant
    {
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public PurchaseOption PurchaseOption { get; set; }
        public int PurchaseOptionId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
    }
}
