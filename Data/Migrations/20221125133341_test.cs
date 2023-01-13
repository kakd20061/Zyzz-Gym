using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserForeignKey = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
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
                values: new object[] { new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5882), new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5890), new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5896), new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5901), new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5906), new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5851), new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5866), new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5872), new DateTime(2022, 11, 24, 22, 31, 30, 502, DateTimeKind.Utc).AddTicks(5872) });
        }
    }
}
