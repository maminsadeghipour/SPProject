using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FeedbackAcceptedByAdminProperty2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAcceptedByAdmin",
                table: "CustomerFeedbacks",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 17, 10, 8, 3, 471, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 5, 17, 10, 8, 3, 471, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 17, 10, 8, 3, 472, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 5, 17, 10, 8, 3, 472, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 10, 8, 3, 480, DateTimeKind.Local).AddTicks(2720));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAcceptedByAdmin",
                table: "CustomerFeedbacks");

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
    }
}
