using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class Accounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdministration = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6543), new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6551), new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6556), new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6560), new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6565), new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6510), new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6524), new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6529), new DateTime(2022, 11, 23, 21, 47, 56, 125, DateTimeKind.Utc).AddTicks(6530) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1908), new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1914), new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1919), new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1924), new DateTime(2022, 11, 23, 16, 28, 51, 975, DateTimeKind.Utc).AddTicks(1924) });

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
    }
}
