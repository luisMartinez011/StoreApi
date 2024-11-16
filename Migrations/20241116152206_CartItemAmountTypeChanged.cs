using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class CartItemAmountTypeChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "CartItems",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9792), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9795), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9796), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9797), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9864), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9867), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9869), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9871), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9872), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9874), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9875), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9876), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9878), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9879), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9881), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9882), new DateTime(2024, 11, 16, 15, 22, 5, 647, DateTimeKind.Utc).AddTicks(9882) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "CartItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

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
    }
}
