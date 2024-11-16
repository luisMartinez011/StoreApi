using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class _20241111051237_isconfirmedDeleted2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Users");

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
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1906), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1908), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1910), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1911), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1912), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1914), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1915), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1916), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1918), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1919), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1920), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1921), new DateTime(2024, 11, 11, 5, 34, 48, 822, DateTimeKind.Utc).AddTicks(1922) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8737), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8742), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8743), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8744), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8816), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8820), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8822), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8824), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8825), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8827), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8828), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8829), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8830), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8831), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8832), new DateTime(2024, 11, 11, 5, 12, 37, 184, DateTimeKind.Utc).AddTicks(8832) });
        }
    }
}
