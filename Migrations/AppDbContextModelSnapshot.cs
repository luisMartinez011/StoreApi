﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StoreAPI.Data;

#nullable disable

namespace StoreAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StoreAPI.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CartId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("CartId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("StoreAPI.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CartItemId"));

                    b.Property<double>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("CartId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("StoreAPI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(60),
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(63),
                            Title = "Frutas"
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(65),
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(65),
                            Title = "Verduras"
                        },
                        new
                        {
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(66),
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(67),
                            Title = "Electrodomesticos"
                        },
                        new
                        {
                            CategoryId = 4,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(68),
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(68),
                            Title = "Panaderia"
                        });
                });

            modelBuilder.Entity("StoreAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(149),
                            Description = "Una manzana roja",
                            Img = "https://www.smartnfinal.com.mx/wp-content/uploads/2016/08/99552-MANZANA-ROJA.jpg",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(149),
                            Price = 14.99,
                            Title = "Manzana"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(153),
                            Description = "Un platano amarillo",
                            Img = "https://b3347428.smushcdn.com/3347428/wp-content/uploads/2023/05/PLATANO-ROATAN-ORGANICO-.jpg?lossy=1&strip=1&webp=1",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(153),
                            Price = 16.989999999999998,
                            Title = "Platano"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(154),
                            Description = "Fresa fresca",
                            Img = "https://medibangpaint.com/wp-content/uploads/2020/02/IMG_0408.jpg",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(155),
                            Price = 11.99,
                            Title = "Fresa"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(156),
                            Description = "Apio para ensaladas",
                            Img = "https://www.superaki.mx/cdn/shop/products/0000000000009_84ef396d-cbfc-4e95-b453-9700a8db5a35_300x300.png?v=1626962900",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(156),
                            Price = 16.989999999999998,
                            Title = "Apio"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(157),
                            Description = "Lechuga para ensaladas",
                            Img = "https://cdn.shopify.com/s/files/1/0566/4391/1854/products/0000000000103_f1f0fd0c-8edf-4117-b27a-870487339aa8.png?v=1646608440",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(158),
                            Price = 18.989999999999998,
                            Title = "Lechuga"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(159),
                            Description = "Zanahorias para ver mejor",
                            Img = "https://5aldia.cl/wp-content/uploads/2018/03/zanahoria.jpg",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(159),
                            Price = 13.99,
                            Title = "Zanahoria"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(160),
                            Description = "Refrigerador con 4 cajones y refrigeracion constante",
                            Img = "https://cdn.homedepot.com.mx/productos/139687/139687-d.jpg",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(161),
                            Price = 15656.99,
                            Title = "Refrigerador"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(162),
                            Description = "Para ver los partidos",
                            Img = "https://www.elizondoenlinea.com/images/thumbs/20318274_0_390.jpg",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(162),
                            Price = 14543.99,
                            Title = "Television"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(163),
                            Description = "Para lavar la ropa",
                            Img = "https://ss634.liverpool.com.mx/xl/1106074174.jpg",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(163),
                            Price = 7000.9899999999998,
                            Title = "Lavadora"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(165),
                            Description = "Dulce pan de muerto",
                            Img = "https://www.lecreuset.mx/dw/image/v2/BDRT_PRD/on/demandware.static/-/Sites-le-creuset-mx-master/default/dw21018694/images/cat-recipes/R6-Pan-de-Muerto.jpg?sw=650&sh=650&sm=fit",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(165),
                            Price = 30.989999999999998,
                            Title = "Pan de Muerto"
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(166),
                            Description = "Muffin de pasas",
                            Img = "https://www.vitamix.com/content/dam/vitamix/migration/media/recipe/rcppumpkinmuffins/images/pumpkinmuffinsmainjpg.jpg",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(166),
                            Price = 40.990000000000002,
                            Title = "Muffin"
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(167),
                            Description = "Pay de fresa",
                            Img = "https://t1.uc.ltmcdn.com/es/posts/9/9/4/como_hacer_pie_de_fresa_31499_orig.jpg",
                            ModifiedAt = new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(168),
                            Price = 140.99000000000001,
                            Title = "Pay"
                        });
                });

            modelBuilder.Entity("StoreAPI.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StoreAPI.Models.Cart", b =>
                {
                    b.HasOne("StoreAPI.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("StoreAPI.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StoreAPI.Models.CartItem", b =>
                {
                    b.HasOne("StoreAPI.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreAPI.Models.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StoreAPI.Models.Product", b =>
                {
                    b.HasOne("StoreAPI.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("StoreAPI.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("StoreAPI.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("StoreAPI.Models.Product", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("StoreAPI.Models.User", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
