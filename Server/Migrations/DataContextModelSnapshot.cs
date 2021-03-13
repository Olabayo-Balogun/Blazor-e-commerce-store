﻿// <auto-generated />
using System;
using AyacOnlineStore.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AyacOnlineStore.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AyacOnlineStore.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "cereals",
                            Name = "Cereals",
                            Url = "cereals"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "fruits",
                            Name = "Fruits",
                            Url = "fruits"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "oils",
                            Name = "Oils",
                            Url = "oils"
                        },
                        new
                        {
                            Id = 4,
                            Icon = "poultry",
                            Name = "Poultry",
                            Url = "poultry"
                        },
                        new
                        {
                            Id = 5,
                            Icon = "vegetables",
                            Name = "Vegetables",
                            Url = "vegetables"
                        });
                });

            modelBuilder.Entity("AyacOnlineStore.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh banana sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; banana isn't a fruit, botanists acknowledge banana as a berry. Fruits are defined by the manner and location of their seeds",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRi94BSgqwm6Zzv7mx3DJWxYRWNUPC0gf3pOA&usqp=CAU",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 100m,
                            Price = 19.99m,
                            Title = "Banana"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh corn sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; corn is one of the top three most consumed crop in the world",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYYVJEFeOlfYCHaynRROL_MLI2AbF1Aa4aUw&usqp=CAU",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 50m,
                            Price = 29.99m,
                            Title = "Corn"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh egg sourced directly from farmers in order to provide you with high quality at a price you love.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/58/Instagram_egg.jpg/220px-Instagram_egg.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 50m,
                            Price = 29.99m,
                            Title = "Egg"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh palm oil sourced directly from farmers in order to provide you with high quality at a price you love.",
                            Image = "https://i2.wp.com/eatwellabi.com/wp-content/uploads/2020/08/palm-oil-4.jpg?resize=725%2C900&ssl=1",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 200m,
                            Price = 99.99m,
                            Title = "Palm Oil"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh pepper sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; pepper isn't a vegetable, botanists acknowledge pepper as a fruit because of the location of its seed",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYdRaqkMUhc4WxHJcT0c9JRCfmdvWpdJUCOQ&usqp=CAU",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 50m,
                            Price = 19.99m,
                            Title = "Pepper"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh plantain sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; plantain isn't a fruit, botanists acknowledge plantain as a berry. Fruits are defined by the manner and location of their seeds",
                            Image = "https://eatyfood.com/wp-content/uploads/2020/08/plantains.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 100m,
                            Price = 49.99m,
                            Title = "Plantain"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh rice sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; rice is one of the top three most consumed crop in the world",
                            Image = "https://m.economictimes.com/thumb/msid-75184562,width-1200,height-900,resizemode-4,imgsize-414299/rice.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 500m,
                            Price = 399.99m,
                            Title = "Rice"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Strawberry sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; strawberry isn't a berry, botanists acknowledge strawberry as a false fruit because of it's multiple fruit nature",
                            Image = "https://www.thermofisher.com/blog/food/wp-content/uploads/sites/5/2015/08/single_strawberry__isolated_on_a_white_background.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 200m,
                            Price = 49.99m,
                            Title = "Strawberry"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Tomatoes sourced directly from farmers in order to provide you with high quality at a price you love. Fun fact; tomatoes isn't a vegetable, botanists acknowledge pepper as a fruit because of the location of its seed",
                            Image = "https://media.istockphoto.com/photos/tomato-isolated-tomato-on-white-background-with-clipping-path-full-picture-id941825808?k=6&m=941825808&s=612x612&w=0&h=zMkokhq3w7fN5xYeiTX27c6TICJ53ZvZg9AY2LNgw_0=",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 100m,
                            Price = 49.99m,
                            Title = "Tomatoes"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh groundnut oil sourced directly from farmers in order to provide you with high quality at a price you love.",
                            Image = "https://www.goldenpeanut.com/Images/OurProducts/PeanutOil/Extract.png",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 400m,
                            Price = 199.99m,
                            Title = "Vegetable Oil"
                        });
                });

            modelBuilder.Entity("AyacOnlineStore.Shared.Product", b =>
                {
                    b.HasOne("AyacOnlineStore.Shared.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AyacOnlineStore.Shared.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}