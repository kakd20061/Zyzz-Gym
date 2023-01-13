using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class PricingBasicSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pricing",
                columns: new[] { "Id", "CreatedAt", "Description", "PassTypeName", "Price", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4850), "You can train when and how much you want!", "24/7 Gym Pass", 29.99f, new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.InsertData(
                table: "Pricing",
                columns: new[] { "Id", "CreatedAt", "Description", "PassTypeName", "Price", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4865), "You can train only at night (21:00 - 06:00)!", "Night Gym Pass", 14.99f, new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.InsertData(
                table: "Pricing",
                columns: new[] { "Id", "CreatedAt", "Description", "PassTypeName", "Price", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4871), "You can train when and how much you want! Money will be deducted automatically. If you choose this option, you must have a bank account.", "24/7 Self-renewable Gym Pass", 19.99f, new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4872) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
