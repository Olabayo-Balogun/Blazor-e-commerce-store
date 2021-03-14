using AyacOnlineStore.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseOption> PurchaseOptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(p => new { p.ProductId, p.PurchaseOptionId });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cereals", Url = "cereals", Icon = "cereals" },
                new Category { Id = 2, Name = "Fruits", Url = "fruits", Icon = "fruits" },
                new Category { Id = 3, Name = "Oils", Url = "oils", Icon = "oils" },
                new Category { Id = 4, Name = "Poultry", Url = "poultry", Icon = "poultry" },
                new Category { Id = 5, Name = "Vegetables", Url = "vegetables", Icon = "vegetables" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 2,
                    Title = "Banana",
                    Description = "Fresh banana sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; banana isn't a fruit, botanists acknowledge banana as a berry. Fruits are defined by the manner and location of their seeds",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRi94BSgqwm6Zzv7mx3DJWxYRWNUPC0gf3pOA&usqp=CAU",
                    DateCreated = new DateTime(2021, 3, 5)
                },

               new Product
               {
                   Id = 2,
                   CategoryId = 1,
                   Title = "Corn",
                   Description = "Fresh corn sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; corn is one of the top three most consumed crop in the world",
                   Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYYVJEFeOlfYCHaynRROL_MLI2AbF1Aa4aUw&usqp=CAU",
                   DateCreated = new DateTime(2021, 3, 5)
               },

               new Product
               {
                   Id = 3,
                   CategoryId = 4,
                   Title = "Egg",
                   Description = "Fresh egg sourced directly from farmers in order to provide you with high quality at a price you love.",
                   Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/58/Instagram_egg.jpg/220px-Instagram_egg.jpg",
                   DateCreated = new DateTime(2021, 3, 5)
               },

               new Product
               {
                   Id = 4,
                   CategoryId = 3,
                   Title = "Palm Oil",
                   Description = "Fresh palm oil sourced directly from farmers in order to provide you with high quality at a price you love.",
                   Image = "https://i2.wp.com/eatwellabi.com/wp-content/uploads/2020/08/palm-oil-4.jpg?resize=725%2C900&ssl=1",
                   DateCreated = new DateTime(2021, 3, 5)
               },

                new Product
                {
                    Id = 5,
                    CategoryId = 5,
                    Title = "Pepper",
                    Description = "Fresh pepper sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; pepper isn't a vegetable, botanists acknowledge pepper as a fruit because of the location of its seed",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYdRaqkMUhc4WxHJcT0c9JRCfmdvWpdJUCOQ&usqp=CAU",
                    DateCreated = new DateTime(2021, 3, 5)
                },

                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Plantain",
                    Description = "Fresh plantain sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; plantain isn't a fruit, botanists acknowledge plantain as a berry. Fruits are defined by the manner and location of their seeds",
                    Image = "https://eatyfood.com/wp-content/uploads/2020/08/plantains.jpg",
                    DateCreated = new DateTime(2021, 3, 5)
                },

                new Product
                {
                    Id = 7,
                    CategoryId = 1,
                    Title = "Rice",
                    Description = "Fresh rice sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; rice is one of the top three most consumed crop in the world",
                    Image = "https://m.economictimes.com/thumb/msid-75184562,width-1200,height-900,resizemode-4,imgsize-414299/rice.jpg",
                    DateCreated = new DateTime(2021, 3, 5)
                },

                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Strawberry",
                    Description = "Fresh Strawberry sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; strawberry isn't a berry, botanists acknowledge strawberry as a false fruit because of it's multiple fruit nature",
                    Image = "https://www.thermofisher.com/blog/food/wp-content/uploads/sites/5/2015/08/single_strawberry__isolated_on_a_white_background.jpg",
                    DateCreated = new DateTime(2021, 3, 5)
                },

                 new Product
                 {
                     Id = 9,
                     CategoryId = 5,
                     Title = "Tomatoes",
                     Description = "Fresh Tomatoes sourced directly from farmers in order to provide you with high quality at a price you love. Fun fact; tomatoes isn't a vegetable, botanists acknowledge pepper as a fruit because of the location of its seed",
                     Image = "https://media.istockphoto.com/photos/tomato-isolated-tomato-on-white-background-with-clipping-path-full-picture-id941825808?k=6&m=941825808&s=612x612&w=0&h=zMkokhq3w7fN5xYeiTX27c6TICJ53ZvZg9AY2LNgw_0=",
                     DateCreated = new DateTime(2021, 3, 5)
                 },

                 new Product
                 {
                     Id = 10,
                     CategoryId = 3,
                     Title = "Vegetable Oil",
                     Description = "Fresh groundnut oil sourced directly from farmers in order to provide you with high quality at a price you love.",
                     Image = "https://www.goldenpeanut.com/Images/OurProducts/PeanutOil/Extract.png",
                     DateCreated = new DateTime(2021, 3, 5)
                 }
            );

            modelBuilder.Entity<PurchaseOption>().HasData(
               new PurchaseOption { Id = 1, Name = "Default" },
               new PurchaseOption { Id = 2, Name = "Bunch(Ripe)" },
               new PurchaseOption { Id = 3, Name = "Bunch(Unripe)" }, 
               new PurchaseOption { Id = 4, Name = "Cob" },
               new PurchaseOption { Id = 5, Name = "Crate" },
               new PurchaseOption { Id = 6, Name = "Kg" },
               new PurchaseOption { Id = 7, Name = "Litres" },
               new PurchaseOption { Id = 8, Name = "Units" },
               new PurchaseOption { Id = 9, Name = "Units(Ripe)" },
               new PurchaseOption { Id = 10, Name = "Units(Unripe)" }
           );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    PurchaseOptionId = 1,
                    OriginalPrice = 100m,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    PurchaseOptionId = 2,
                    Price = 199.99m,
                    OriginalPrice = 400m,
                },
                new ProductVariant
                {
                    ProductId = 1,
                    PurchaseOptionId = 3,
                    Price = 199.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    PurchaseOptionId = 8,
                    OriginalPrice = 100m,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    PurchaseOptionId = 9,
                    OriginalPrice = 100m,
                    Price = 19.99m
                },
                new ProductVariant
                {
                ProductId = 2,
                     PurchaseOptionId = 1,
                     Price = 29.99m,
                     OriginalPrice = 50m,
                 },
                new ProductVariant
                 {
                     ProductId = 2,
                     PurchaseOptionId = 4,
                     Price = 29.99m,
                     OriginalPrice = 50m,
                 },
                new ProductVariant
                  {
                      ProductId = 2,
                      PurchaseOptionId = 6,
                      Price = 99.99m,
                      OriginalPrice = 200m,
                  },
                 new ProductVariant
                 {
                     ProductId = 3,
                     PurchaseOptionId = 5,
                     OriginalPrice = 1200m,
                     Price = 719.76m
                 },

                new ProductVariant
                 {
                     ProductId = 3,
                     PurchaseOptionId = 8,
                     OriginalPrice = 50m,
                     Price = 29.99m
                 },
                new ProductVariant
                 {
                     ProductId = 4,
                     PurchaseOptionId = 1,
                     OriginalPrice = 200m,
                     Price = 99.99m
                 },
                new ProductVariant
                 {
                     ProductId = 4,
                     PurchaseOptionId = 7,
                     OriginalPrice = 200m,
                     Price = 99.99m
                 },
                new ProductVariant
                 {
                     ProductId = 5,
                     PurchaseOptionId = 1,
                     OriginalPrice = 50m,
                     Price = 19.99m
                 },
                new ProductVariant
                 {
                     ProductId = 5,
                     PurchaseOptionId = 6,
                     OriginalPrice = 200m,
                     Price = 99.99m
                 },

                new ProductVariant
                  {
                      ProductId = 5,
                      PurchaseOptionId = 8,
                      OriginalPrice = 50m,
                      Price = 19.99m
                  },
                new ProductVariant
                  {
                      ProductId = 6,
                      PurchaseOptionId = 1,
                      OriginalPrice = 100m,
                      Price = 19.99m
                  },
                new ProductVariant
                   {
                        ProductId = 6,
                        PurchaseOptionId = 2,
                        Price = 199.99m,
                        OriginalPrice = 400m,
                    },
                new ProductVariant
                    {
                        ProductId = 6,
                        PurchaseOptionId = 3,
                        Price = 199.99m
                    },
                new ProductVariant
                    {
                        ProductId = 6,
                        PurchaseOptionId = 9,
                        OriginalPrice = 100m,
                        Price = 19.99m
                    },
                new ProductVariant
                    {
                        ProductId = 6,
                        PurchaseOptionId = 10,
                        OriginalPrice = 100m,
                        Price = 19.99m
                    },
                new ProductVariant
                     {
                         ProductId = 7,
                         PurchaseOptionId = 1,
                         OriginalPrice = 500m,
                         Price = 400m
                     },
                new ProductVariant
                    {
                        ProductId = 7,
                        PurchaseOptionId = 6,
                        OriginalPrice = 500m,
                        Price = 400m
                    },
                new ProductVariant
                    {
                        ProductId = 8,
                        PurchaseOptionId = 1,
                        OriginalPrice = 200m,
                        Price = 49.99m
                    },
                new ProductVariant
                    {
                        ProductId = 8,
                        PurchaseOptionId = 6,
                        OriginalPrice = 7000m,
                        Price = 1000m
                    },
                new ProductVariant
                    {
                        ProductId = 8,
                        PurchaseOptionId = 8,
                        OriginalPrice = 200m,
                        Price = 49.99m
                    },
                new ProductVariant
                    {
                        ProductId = 9,
                        PurchaseOptionId = 1,
                        OriginalPrice = 100m,
                        Price = 49.99m
                    },
                new ProductVariant
                    {
                        ProductId = 9,
                        PurchaseOptionId = 6,
                        OriginalPrice = 2000m,
                        Price = 1000m
                    },
                new ProductVariant
                    {
                        ProductId = 9,
                        PurchaseOptionId = 8,
                        OriginalPrice = 100m,
                        Price = 49.99m
                    },
                new ProductVariant
                    {
                        ProductId = 10,
                        PurchaseOptionId = 1,
                        OriginalPrice = 400m,
                        Price = 199.99m
                    },
                new ProductVariant
                    {
                        ProductId = 10,
                        PurchaseOptionId = 7,
                        OriginalPrice = 400m,
                        Price = 199.99m
                    }
            );
        }
    }
}
