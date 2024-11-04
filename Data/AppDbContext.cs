using StoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;

namespace StoreAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            //base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(countryConfiguration);

            modelBuilder.Entity<User>()
               .HasOne(a => a.Cart)
               .WithOne(b => b.User)
               .HasForeignKey<Cart>(b => b.UserId);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId=1,Title = "Frutas" },
                new Category { CategoryId = 2, Title = "Verduras" },
                new Category { CategoryId = 3, Title = "Electrodomesticos" },
                new Category { CategoryId = 4, Title = "Panaderia" }

                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId=1, Title="Manzana", Description="Una manzana roja", CategoryId=1, Price=14.99, Img=""},
                new Product { ProductId=2, Title="Platano", Description="Un platano amarillo", CategoryId=1, Price=16.99, Img=""},
                new Product { ProductId = 3, Title = "Fresa", Description = "Fresa fresca", CategoryId = 1, Price = 11.99, Img = "" },
                new Product { ProductId = 4, Title = "Apio", Description = "Apio para ensaladas", CategoryId = 2, Price = 16.99, Img = "" },
                new Product { ProductId = 5, Title = "Lechuga", Description = "Lechuga para ensaladas", CategoryId = 2, Price = 18.99, Img = "" },
                new Product { ProductId = 6, Title = "Zanahoria", Description = "Zanahorias para ver mejor", CategoryId = 2, Price = 13.99, Img = "" },
                new Product { ProductId = 7, Title = "Refrigerador", Description = "Refrigerador con 4 cajones y refrigeracion constante", CategoryId = 3, Price = 15656.99, Img = "" },
                new Product { ProductId = 8, Title = "Television", Description = "Para ver los partidos", CategoryId = 3, Price = 14543.99, Img = "" },
                new Product { ProductId = 9, Title = "Lavadora", Description = "Para lavar la ropa", CategoryId = 3, Price = 7000.99, Img = "" },
                new Product { ProductId = 10, Title = "Pan de Muerto", Description = "Dulce pan de muerto", CategoryId = 4, Price = 30.99, Img = "" },
                new Product { ProductId = 11, Title = "Muffin", Description = "Muffin de pasas", CategoryId = 4, Price = 40.99, Img = "" },
                new Product { ProductId = 12, Title = "Pay", Description = "Pay de fresa", CategoryId = 4, Price = 140.99, Img = "" }

                );
        }

        




        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
