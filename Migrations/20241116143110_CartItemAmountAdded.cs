using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class CartItemAmountAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "CartItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7419), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7421), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7487), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7490), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7492), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7494), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7495), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7497), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7498), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7529), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7532), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7533), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7535), new DateTime(2024, 11, 16, 14, 31, 9, 662, DateTimeKind.Utc).AddTicks(7535) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "CartItems");

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
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1725), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1729), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1730), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1732), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1734), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1735), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1736), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1737), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1739), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1740), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 11, 11, 6, 29, 9, 291, DateTimeKind.Utc).AddTicks(1741) });
        }
    }
}
