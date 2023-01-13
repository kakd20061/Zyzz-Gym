using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class RequestsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1724), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1734), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1740), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1745), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1750), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1759), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1768), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1774), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1694), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1709), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1716), new DateTime(2022, 11, 29, 12, 14, 56, 345, DateTimeKind.Utc).AddTicks(1716) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Requests");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(618), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(657), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(663), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(668), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(673), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(683), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(690), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(696), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(590), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(605), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(610), new DateTime(2022, 11, 29, 12, 2, 20, 87, DateTimeKind.Utc).AddTicks(611) });
        }
    }
}
