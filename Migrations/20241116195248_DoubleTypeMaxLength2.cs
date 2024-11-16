using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class DoubleTypeMaxLength2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2042), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2046), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2048), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2049), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2213), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2216), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2218), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2220), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2221), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2222), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2224), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2225), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2226), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2228), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2229), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2230), new DateTime(2024, 11, 16, 19, 52, 48, 226, DateTimeKind.Utc).AddTicks(2231) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4643), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4646), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4683), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4684), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4769), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4772), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4774), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4776), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4777), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4778), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4780), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4781), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4783), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4784), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4786), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4787), new DateTime(2024, 11, 16, 15, 36, 40, 228, DateTimeKind.Utc).AddTicks(4787) });
        }
    }
}
