using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class RevertingAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(621), new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(630), new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(635), new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(639), new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(644), new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(590), new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(606), new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(612), new DateTime(2022, 11, 24, 12, 27, 12, 848, DateTimeKind.Utc).AddTicks(612) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdministration = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
    }
}
