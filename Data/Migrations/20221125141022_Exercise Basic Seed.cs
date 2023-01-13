using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class ExerciseBasicSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2963), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2971), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2976), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2981), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3011), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.InsertData(
                table: "ExerciseName",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3021), "Bench Press", new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3021) },
                    { 2, new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3027), "Shoulder Press", new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3027) },
                    { 3, new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3032), "Squat", new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3032) }
                });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2932), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2948), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2954), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(2954) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3573), new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3581), new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3586), new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3590), new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3594), new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3546), new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3559), new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3564), new DateTime(2022, 11, 25, 13, 37, 53, 898, DateTimeKind.Utc).AddTicks(3564) });
        }
    }
}
