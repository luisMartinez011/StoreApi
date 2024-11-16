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
                new Product { ProductId=1, Title="Manzana", Description="Una manzana roja", CategoryId=1, Price=14.99, Img= "https://www.smartnfinal.com.mx/wp-content/uploads/2016/08/99552-MANZANA-ROJA.jpg" },
                new Product { ProductId=2, Title="Platano", Description="Un platano amarillo", CategoryId=1, Price=16.99, Img= "https://b3347428.smushcdn.com/3347428/wp-content/uploads/2023/05/PLATANO-ROATAN-ORGANICO-.jpg?lossy=1&strip=1&webp=1" },
                new Product { ProductId = 3, Title = "Fresa", Description = "Fresa fresca", CategoryId = 1, Price = 11.99, Img = "https://medibangpaint.com/wp-content/uploads/2020/02/IMG_0408.jpg" },
                new Product { ProductId = 4, Title = "Apio", Description = "Apio para ensaladas", CategoryId = 2, Price = 16.99, Img = "https://www.superaki.mx/cdn/shop/products/0000000000009_84ef396d-cbfc-4e95-b453-9700a8db5a35_300x300.png?v=1626962900" },
                new Product { ProductId = 5, Title = "Lechuga", Description = "Lechuga para ensaladas", CategoryId = 2, Price = 18.99, Img = "https://cdn.shopify.com/s/files/1/0566/4391/1854/products/0000000000103_f1f0fd0c-8edf-4117-b27a-870487339aa8.png?v=1646608440" },
                new Product { ProductId = 6, Title = "Zanahoria", Description = "Zanahorias para ver mejor", CategoryId = 2, Price = 13.99, Img = "https://5aldia.cl/wp-content/uploads/2018/03/zanahoria.jpg" },
                new Product { ProductId = 7, Title = "Refrigerador", Description = "Refrigerador con 4 cajones y refrigeracion constante", CategoryId = 3, Price = 15656.99, Img = "https://cdn.homedepot.com.mx/productos/139687/139687-d.jpg" },
                new Product { ProductId = 8, Title = "Television", Description = "Para ver los partidos", CategoryId = 3, Price = 14543.99, Img = "https://www.elizondoenlinea.com/images/thumbs/20318274_0_390.jpg" },
                new Product { ProductId = 9, Title = "Lavadora", Description = "Para lavar la ropa", CategoryId = 3, Price = 7000.99, Img = "https://ss634.liverpool.com.mx/xl/1106074174.jpg" },
                new Product { ProductId = 10, Title = "Pan de Muerto", Description = "Dulce pan de muerto", CategoryId = 4, Price = 30.99, Img = "https://www.lecreuset.mx/dw/image/v2/BDRT_PRD/on/demandware.static/-/Sites-le-creuset-mx-master/default/dw21018694/images/cat-recipes/R6-Pan-de-Muerto.jpg?sw=650&sh=650&sm=fit" },
                new Product { ProductId = 11, Title = "Muffin", Description = "Muffin de pasas", CategoryId = 4, Price = 40.99, Img = "https://www.vitamix.com/content/dam/vitamix/migration/media/recipe/rcppumpkinmuffins/images/pumpkinmuffinsmainjpg.jpg" },
                new Product { ProductId = 12, Title = "Pay", Description = "Pay de fresa", CategoryId = 4, Price = 140.99, Img = "https://t1.uc.ltmcdn.com/es/posts/9/9/4/como_hacer_pie_de_fresa_31499_orig.jpg" }

                );
        }

        




        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
