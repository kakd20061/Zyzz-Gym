using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class Achieve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(432), new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(440), new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(445), new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(449), new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(454), new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(400), new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(416), new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(422), new DateTime(2022, 11, 25, 13, 35, 19, 933, DateTimeKind.Utc).AddTicks(422) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2268), new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2277), new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2283), new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2288), new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2294), new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2231), new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2252), new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2259), new DateTime(2022, 11, 25, 13, 34, 44, 372, DateTimeKind.Utc).AddTicks(2259) });
        }
    }
}
