using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class AchievementBasicSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedAt", "ExerciseForeignKey", "Reps", "UpdatedAt", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7140), 1, 6, new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7141), 100.0 },
                    { 2, new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7148), 2, 6, new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7148), 100.0 },
                    { 3, new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7154), 3, 6, new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7154), 100.0 }
                });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7083), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7095), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7101), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7106), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7111), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7121), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7128), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7133), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7052), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7068), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7073), new DateTime(2022, 11, 25, 14, 58, 42, 858, DateTimeKind.Utc).AddTicks(7074) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3021), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3027), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3032), new DateTime(2022, 11, 25, 14, 10, 22, 55, DateTimeKind.Utc).AddTicks(3032) });

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
    }
}
