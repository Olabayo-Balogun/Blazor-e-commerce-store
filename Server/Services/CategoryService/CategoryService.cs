using AyacOnlineStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
        {
            new Category { Id = 1, Name = "Cereals", Url = "cereals", Icon = "cereals" },
               new Category { Id = 2, Name = "Fruits", Url = "fruits", Icon = "fruits" },
               new Category { Id = 3, Name = "Oils", Url = "oils", Icon = "oils" },
               new Category { Id = 4, Name = "Poultry", Url = "poultry", Icon = "poultry" },
               new Category { Id = 5, Name = "Vegetables", Url = "vegetables", Icon = "vegetables" }
        };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }
    }
}
