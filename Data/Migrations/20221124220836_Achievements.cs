using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class Achievements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserForeignKey = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievements_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserId",
                table: "Achievements",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

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
    }
}
