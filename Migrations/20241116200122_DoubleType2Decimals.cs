using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class DoubleType2Decimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<double>(
                name: "TotalAmount",
                table: "Carts",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "CartItems",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldMaxLength: 2);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(60), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(65), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(66), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(68), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(149), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(153), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(154), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(156), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(157), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(159), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(162), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(163), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(165), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(166), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(167), new DateTime(2024, 11, 16, 20, 1, 22, 42, DateTimeKind.Utc).AddTicks(168) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "double precision",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "TotalAmount",
                table: "Carts",
                type: "double precision",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "CartItems",
                type: "double precision",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(18,2)");

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
    }
}
