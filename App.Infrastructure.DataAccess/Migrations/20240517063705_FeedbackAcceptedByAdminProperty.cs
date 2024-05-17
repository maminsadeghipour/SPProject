using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FeedbackAcceptedByAdminProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 17, 10, 7, 4, 459, DateTimeKind.Local).AddTicks(2420), new DateTime(2024, 5, 17, 10, 7, 4, 459, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 17, 10, 7, 4, 459, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 5, 17, 10, 7, 4, 459, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 7, 4, 464, DateTimeKind.Local).AddTicks(1880));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 354, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 4, 30, 17, 24, 38, 349, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 4, 30, 17, 24, 38, 349, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 4, 30, 17, 24, 38, 350, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 4, 30, 17, 24, 38, 350, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 353, DateTimeKind.Local).AddTicks(7340));
        }
    }
}
