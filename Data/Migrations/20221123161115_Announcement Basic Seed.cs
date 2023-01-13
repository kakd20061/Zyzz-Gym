using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class AnnouncementBasicSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4909), new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4909) });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "CreatedAt", "Description", "PhotoUrl", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4916), "In cooperation with the Olimp company, new whey protein complex are available in our store. Check this out!", "https://static.pepper.pl/threads/raw/RGwF5/582471_1/re/1600x900/qt/60/582471_1.jpg", "New delivery of Whey Protein Complex", new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4917) },
                    { 3, new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4922), "We are happy to say that we have got new modern gym equipment", "https://www.ironcompany.com/media/mf_webp/jpg/media/catalog/product/cache/e2c8244c5972c0e74c812d913143823a/l/e/legend-selectedge-1124-multi-press-xlg.webp", "New gym equipment", new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4922) }
                });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4879), new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4895), new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4901), new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4901) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1098), new DateTime(2022, 11, 23, 15, 30, 32, 348, DateTimeKind.Utc).AddTicks(1099) });

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
    }
}
