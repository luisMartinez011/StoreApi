using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class isconfirmedDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3539), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3544), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3544), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3545), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3654), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3658), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3659), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3694), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3696), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3697), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3698), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3699), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3700), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3702), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3703), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3704), new DateTime(2024, 11, 3, 22, 38, 43, 376, DateTimeKind.Utc).AddTicks(3704) });
        }
    }
}
