using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class ExerciseAchieveRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExerciseForeignKey",
                table: "Achievements",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_ExerciseForeignKey",
                table: "Achievements",
                column: "ExerciseForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_ExerciseName_ExerciseForeignKey",
                table: "Achievements",
                column: "ExerciseForeignKey",
                principalTable: "ExerciseName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_ExerciseName_ExerciseForeignKey",
                table: "Achievements");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_ExerciseForeignKey",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "ExerciseForeignKey",
                table: "Achievements");

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
    }
}
