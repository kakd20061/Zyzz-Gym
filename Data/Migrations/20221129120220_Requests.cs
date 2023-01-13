using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class Requests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9771), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9788), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9796), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9805), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9812), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9827), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9843), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "ExerciseName",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9851), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9675), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9707), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9751), new DateTime(2022, 11, 25, 16, 33, 39, 789, DateTimeKind.Utc).AddTicks(9752) });
        }
    }
}
