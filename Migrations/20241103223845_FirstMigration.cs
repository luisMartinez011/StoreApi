using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Img = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TotalAmount = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CartId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedAt", "ModifiedAt", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3539), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3541), "Frutas" },
                    { 2, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3544), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3544), "Verduras" },
                    { 3, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3544), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3545), "Electrodomesticos" },
                    { 4, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3545), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3545), "Panaderia" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreatedAt", "Description", "Img", "ModifiedAt", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3654), "Una manzana roja", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3655), 14.99, "Manzana" },
                    { 2, 1, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3658), "Un platano amarillo", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3658), 16.989999999999998, "Platano" },
                    { 3, 1, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3659), "Fresa fresca", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3660), 11.99, "Fresa" },
                    { 4, 2, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3694), "Apio para ensaladas", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3694), 16.989999999999998, "Apio" },
                    { 5, 2, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3696), "Lechuga para ensaladas", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3696), 18.989999999999998, "Lechuga" },
                    { 6, 2, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3697), "Zanahorias para ver mejor", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3697), 13.99, "Zanahoria" },
                    { 7, 3, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3698), "Refrigerador con 4 cajones y refrigeracion constante", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3698), 15656.99, "Refrigerador" },
                    { 8, 3, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3699), "Para ver los partidos", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3699), 14543.99, "Television" },
                    { 9, 3, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3700), "Para lavar la ropa", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3701), 7000.9899999999998, "Lavadora" },
                    { 10, 4, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3702), "Dulce pan de muerto", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3702), 30.989999999999998, "Pan de Muerto" },
                    { 11, 4, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3703), "Muffin de pasas", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3703), 40.990000000000002, "Muffin" },
                    { 12, 4, new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3704), "Pay de fresa", "", new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3704), 140.99000000000001, "Pay" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
