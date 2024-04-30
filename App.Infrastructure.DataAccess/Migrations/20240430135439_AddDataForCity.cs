using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infrastructure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDataForCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 24, 38, 354, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "آذربایجان شرقی" },
                    { 2, "آذربایجان غربی" },
                    { 3, "اردبیل" },
                    { 4, "اصفهان" },
                    { 5, "البرز" },
                    { 6, "ایلام" },
                    { 7, "بوشهر" },
                    { 8, "تهران" },
                    { 9, "چهارمحال و بختیاری" },
                    { 10, "خراسان جنوبی" },
                    { 11, "خراسان رضوی" },
                    { 12, "خراسان شمالی" },
                    { 13, "خوزستان" },
                    { 14, "زنجان" },
                    { 15, "سمنان" },
                    { 16, "سیستان و بلوچستان" },
                    { 17, "فارس" },
                    { 18, "قزوین" },
                    { 19, "قم" },
                    { 20, "کردستان" },
                    { 21, "کرمان" },
                    { 22, "کرمانشاه" },
                    { 23, "کهگیلویه و بویراحمد" },
                    { 24, "گلستان" },
                    { 25, "گیلان" },
                    { 26, "لرستان" },
                    { 27, "مازندران" },
                    { 28, "مرکزی" },
                    { 29, "هرمزگان" },
                    { 30, "همدان" },
                    { 31, "یزد" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 17, 18, 34, 395, DateTimeKind.Local).AddTicks(9940));

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
    }
}
