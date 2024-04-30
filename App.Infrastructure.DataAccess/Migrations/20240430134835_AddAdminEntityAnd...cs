using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminEntityAnd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Username" },
                values: new object[] { 1, new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(9940), null, "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 4, 30, 17, 18, 34, 392, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 4, 30, 17, 18, 34, 392, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 4, 30, 17, 18, 34, 392, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 4, 30, 17, 18, 34, 392, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(6760));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 4, 30, 9, 2, 24, 832, DateTimeKind.Local).AddTicks(1920), new DateTime(2024, 4, 30, 9, 2, 24, 832, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 4, 30, 9, 2, 24, 832, DateTimeKind.Local).AddTicks(9150), new DateTime(2024, 4, 30, 9, 2, 24, 832, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2620));
        }
    }
}
