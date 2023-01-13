using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class AnnouncementTestSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "CreatedAt", "Description", "PhotoUrl", "Title", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1098), "In cooperation with the kfd company, new whey protein flavors are available in our store!", "https://a.allegroimg.com/s1024/0c35f7/641f676d4bf5b3f5b02baa7a23b9", "New whey protein falvours", new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1063), new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1081), new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1087), new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1088) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4850), new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4865), new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4871), new DateTime(2022, 11, 21, 21, 34, 5, 542, DateTimeKind.Utc).AddTicks(4872) });
        }
    }
}
