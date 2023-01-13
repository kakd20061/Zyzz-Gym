using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyzzGymOriginal.Data.Migrations
{
    public partial class UserAchevementsRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserForeignKey",
                table: "Achievements",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserForeignKey",
                table: "Achievements",
                column: "UserForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_AspNetUsers_UserForeignKey",
                table: "Achievements",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_AspNetUsers_UserForeignKey",
                table: "Achievements");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_UserForeignKey",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "UserForeignKey",
                table: "Achievements");

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
    }
}
