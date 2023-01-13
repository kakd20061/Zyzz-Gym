using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_AspNetUsers_UserId",
                table: "Achievements");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Achievements",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_AspNetUsers_UserId",
                table: "Achievements",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_AspNetUsers_UserId",
                table: "Achievements");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Achievements",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8818), new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8827), new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8833), new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8838), new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8844), new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8788), new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8804), new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8810), new DateTime(2022, 11, 24, 22, 8, 36, 368, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_AspNetUsers_UserId",
                table: "Achievements",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
