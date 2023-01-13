using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class AnnouncementBasicSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1878), new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1908), "New delivery of WPC", new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1914), new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "CreatedAt", "Description", "PhotoUrl", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1919), "We bought some more plates to avoid fights for gains!", "https://kronos-shop.pl/pol_pl_HMS-Talerz-Olimpijski-Gumowany-Obciazenie-20-kg-12442_2.jpg", "More plates on the gym", new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1919) },
                    { 5, new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1924), "Sadly We must announce that gym will be closed at 1st December due to technical break :(", "https://www.klubfitness.njn.pl/photos/40217/235965916_1906319619541469_7780126213647886945_n.jpg.jpg", "Gym will be closed at 1st December", new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1924) }
                });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1848), new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1863), new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1869), new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1870) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4909), new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4916), "New delivery of Whey Protein Complex", new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4922), new DateTime(2022, 11, 23, 16, 11, 15, 627, DateTimeKind.Utc).AddTicks(4922) });

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
    }
}
