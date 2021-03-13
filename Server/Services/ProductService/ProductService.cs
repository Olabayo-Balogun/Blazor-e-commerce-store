using AyacOnlineStore.Server.Services.CategoryService;
using AyacOnlineStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Server.Services.ProductService
{   
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct (int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product; 
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        public List<Product> Products { get; set; } = new List<Product>
            {
                new Product
               {
                   Id = 1,
                   CategoryId = 2,
                   Title = "Banana",
                   Description = "Fresh banana sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; banana isn't a fruit, botanists acknowledge banana as a berry. Fruits are defined by the manner and location of their seeds",
                   Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRi94BSgqwm6Zzv7mx3DJWxYRWNUPC0gf3pOA&usqp=CAU",
                   Price = 19.99m,
                   OriginalPrice = 100m,
                   DateCreated = new DateTime(2021, 3, 5)
               },

               new Product
               {
                   Id = 2,
                   CategoryId = 1,
                   Title = "Corn",
                   Description = "Fresh corn sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; corn is one of the top three most consumed crop in the world",
                   Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYYVJEFeOlfYCHaynRROL_MLI2AbF1Aa4aUw&usqp=CAU",
                   Price = 29.99m,
                   OriginalPrice = 50m,
                   DateCreated = new DateTime(2021, 3, 5)
               },

               new Product
               {
                   Id = 3,
                   CategoryId = 4,
                   Title = "Egg",
                   Description = "Fresh egg sourced directly from farmers in order to provide you with high quality at a price you love.",
                   Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/58/Instagram_egg.jpg/220px-Instagram_egg.jpg",
                   Price = 29.99m,
                   OriginalPrice = 50m,
                   DateCreated = new DateTime(2021, 3, 5)
               },

               new Product
               {
                   Id = 4,
                   CategoryId = 3,
                   Title = "Palm Oil",
                   Description = "Fresh palm oil sourced directly from farmers in order to provide you with high quality at a price you love.",
                   Image = "https://i2.wp.com/eatwellabi.com/wp-content/uploads/2020/08/palm-oil-4.jpg?resize=725%2C900&ssl=1",
                   Price = 99.99m,
                   OriginalPrice = 200m,
                   DateCreated = new DateTime(2021, 3, 5)
               },

                new Product
                {
                    Id = 5,
                    CategoryId = 5,
                    Title = "Pepper",
                    Description = "Fresh pepper sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; pepper isn't a vegetable, botanists acknowledge pepper as a fruit because of the location of its seed",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYdRaqkMUhc4WxHJcT0c9JRCfmdvWpdJUCOQ&usqp=CAU",
                    Price = 19.99m,
                    OriginalPrice = 50m,
                    DateCreated = new DateTime(2021, 3, 5)
                },

                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Plantain",
                    Description = "Fresh plantain sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; plantain isn't a fruit, botanists acknowledge plantain as a berry. Fruits are defined by the manner and location of their seeds",
                    Image = "https://eatyfood.com/wp-content/uploads/2020/08/plantains.jpg",
                    Price = 49.99m,
                    OriginalPrice = 100m,
                    DateCreated = new DateTime(2021, 3, 5)
                },

                new Product
                {
                    Id = 7,
                    CategoryId = 1,
                    Title = "Rice",
                    Description = "Fresh rice sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; rice is one of the top three most consumed crop in the world",
                    Image = "https://m.economictimes.com/thumb/msid-75184562,width-1200,height-900,resizemode-4,imgsize-414299/rice.jpg",
                    Price = 399.99m,
                    OriginalPrice = 500m,
                    DateCreated = new DateTime(2021, 3, 5)
                },

                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Strawberry",
                    Description = "Fresh Strawberry sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; strawberry isn't a berry, botanists acknowledge strawberry as a false fruit because of it's multiple fruit nature",
                    Image = "https://www.thermofisher.com/blog/food/wp-content/uploads/sites/5/2015/08/single_strawberry__isolated_on_a_white_background.jpg",
                    Price = 49.99m,
                    OriginalPrice = 200m,
                    DateCreated = new DateTime(2021, 3, 5)
                },

                 new Product
                 {
                     Id = 9,
                     CategoryId = 5,
                     Title = "Tomatoes",
                     Description = "Fresh Tomatoes sourced directly from farmers in order to provide you with high quality at a price you love. Fun fact; tomatoes isn't a vegetable, botanists acknowledge pepper as a fruit because of the location of its seed",
                     Image = "https://media.istockphoto.com/photos/tomato-isolated-tomato-on-white-background-with-clipping-path-full-picture-id941825808?k=6&m=941825808&s=612x612&w=0&h=zMkokhq3w7fN5xYeiTX27c6TICJ53ZvZg9AY2LNgw_0=",
                     Price = 49.99m,
                     OriginalPrice = 100m,
                     DateCreated = new DateTime(2021, 3, 5)
                 },

                 new Product
               {
                   Id = 10,
                   CategoryId = 3,
                   Title = "Vegetable Oil",
                   Description = "Fresh groundnut oil sourced directly from farmers in order to provide you with high quality at a price you love.",
                   Image = "https://www.goldenpeanut.com/Images/OurProducts/PeanutOil/Extract.png",
                   Price = 199.99m,
                   OriginalPrice = 400m,
                   DateCreated = new DateTime(2021, 3, 5)
               }
            };
    }
}
