using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddImagesToProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1628), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1631), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1632), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1633), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1725), "https://www.smartnfinal.com.mx/wp-content/uploads/2016/08/99552-MANZANA-ROJA.jpg", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1729), "https://b3347428.smushcdn.com/3347428/wp-content/uploads/2023/05/PLATANO-ROATAN-ORGANICO-.jpg?lossy=1&strip=1&webp=1", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1730), "https://medibangpaint.com/wp-content/uploads/2020/02/IMG_0408.jpg", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1732), "https://www.superaki.mx/cdn/shop/products/0000000000009_84ef396d-cbfc-4e95-b453-9700a8db5a35_300x300.png?v=1626962900", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1733), "https://cdn.shopify.com/s/files/1/0566/4391/1854/products/0000000000103_f1f0fd0c-8edf-4117-b27a-870487339aa8.png?v=1646608440", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1734), "https://5aldia.cl/wp-content/uploads/2018/03/zanahoria.jpg", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1735), "https://cdn.homedepot.com.mx/productos/139687/139687-d.jpg", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1736), "https://www.elizondoenlinea.com/images/thumbs/20318274_0_390.jpg", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1737), "https://ss634.liverpool.com.mx/xl/1106074174.jpg", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1739), "https://www.lecreuset.mx/dw/image/v2/BDRT_PRD/on/demandware.static/-/Sites-le-creuset-mx-master/default/dw21018694/images/cat-recipes/R6-Pan-de-Muerto.jpg?sw=650&sh=650&sm=fit", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1740), "https://www.vitamix.com/content/dam/vitamix/migration/media/recipe/rcppumpkinmuffins/images/pumpkinmuffinsmainjpg.jpg", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1741), "https://t1.uc.ltmcdn.com/es/posts/9/9/4/como_hacer_pie_de_fresa_31499_orig.jpg", new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1741) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1827), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1831), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1832), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1833), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1906), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1908), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1910), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1911), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1912), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1914), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1915), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1916), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1918), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1919), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1920), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Img", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1921), "", new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1922) });
        }
    }
}
