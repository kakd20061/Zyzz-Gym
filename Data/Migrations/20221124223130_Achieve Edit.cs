using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class AchieveEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_AspNetUsers_UserId",
                table: "Achievements");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_UserId",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Achievements");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Achievements",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8904), new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8911), new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8916), new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8921), new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8926), new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8874), new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8888), new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8894), new DateTime(2022, 11, 24, 22, 23, 12, 991, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserId",
                table: "Achievements",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_AspNetUsers_UserId",
                table: "Achievements",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
