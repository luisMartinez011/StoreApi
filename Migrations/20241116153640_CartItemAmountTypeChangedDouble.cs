using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class CartItemAmountTypeChangedDouble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalAmount",
                table: "Carts",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "TotalAmount",
                table: "Carts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

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
    }
}
