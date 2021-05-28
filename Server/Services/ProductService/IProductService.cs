using AyacOnlineStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProduct(int id);
        Task<List<Product>> GetProductsByCategory(string categoryUrl);
        Task<List<Product>> SearchProducts(string searchText);
    }
}
