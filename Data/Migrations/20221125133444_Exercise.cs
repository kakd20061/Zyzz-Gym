using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class Exercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExerciseName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseName", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseName");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8323), new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8363), new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8368), new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8373), new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8378), new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8292), new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8307), new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8313), new DateTime(2022, 11, 25, 13, 33, 41, 313, DateTimeKind.Utc).AddTicks(8313) });
        }
    }
}
