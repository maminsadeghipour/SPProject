using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infrastructure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "LastUpdatedAt", "Password", "PhoneNumber", "RegisteredAt", "Username" },
                values: new object[] { 1, new DateTime(2024, 4, 30, 9, 2, 24, 832, DateTimeKind.Local).AddTicks(1920), "Ali", "Alizadeh", null, "1234", "09121234567", new DateTime(2024, 4, 30, 9, 2, 24, 832, DateTimeKind.Local).AddTicks(1880), "Ali.Alizadeh" });

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "BankAccount", "CreatedAt", "FirstName", "LastName", "LastUpdatedAt", "Password", "PhoneNumber", "RegisteredAt", "Username" },
                values: new object[] { 1, "6362141111223344", new DateTime(2024, 4, 30, 9, 2, 24, 832, DateTimeKind.Local).AddTicks(9150), "Mohmad", "Sadeghi", null, "1234", "09123215476", new DateTime(2024, 4, 30, 9, 2, 24, 832, DateTimeKind.Local).AddTicks(9120), "m.sadeghi" });

            migrationBuilder.InsertData(
                table: "SkillServeCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "LastUpdatedAt", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4760), "ارئه خدمات مربوط به نظافت منزل و ...", null, "نظافت" },
                    { 2, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4780), "خدمات مربوط به ساختمان و..", null, "ساختمان" },
                    { 3, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4780), "تعمیرات یخچال و ...", null, "تعمیرات اشیا" },
                    { 4, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4780), "خدمات مربوط به خودرو تعمیرات و ...", null, "خودرو" },
                    { 5, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4790), "تعمیرات موبایل و تجهیزات الکترونیک", null, "الکترونیک" },
                    { 6, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(4790), "خدمات مربوط به اسباب کشی ", null, "حمل و نقل" }
                });

            migrationBuilder.InsertData(
                table: "SkillServes",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "LastUpdatedAt", "MinWage", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2540), "نظافت منزل با بهترین امکانات", null, 400000, "نظافت منزل" },
                    { 2, 1, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2600), "قالی های خود را به ما بسپارید", null, 300000, "قالی شویی" },
                    { 3, 2, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2600), "سردته؟ با یه درخواست سیستم گرمایشتو درست کن", null, 500000, "سرمایش و گرمایش" },
                    { 4, 2, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2600), "خسته شدی از اینکه ساختمانت درست نیست راه حلش پیش ماست", null, 300000, "تعمیرات ساختمان" },
                    { 5, 3, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2600), "دیگه نگران خراب شدن یخچالت نباش", null, 400000, "تعمیرات یخچال" },
                    { 6, 3, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2610), "ماشین لباسشوییت لباساتو خوب تمیز نمیکنه ؟ درخواست بده", null, 300000, "تعمیرات ماشین لباس شویی" },
                    { 7, 4, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2610), "تعمیر کارا ماشینتو جواب کردن ؟ اینجا درستش کن ", null, 600000, "تعمیرات خودرو" },
                    { 8, 4, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2610), "با همسرت سره کثیفی ماشین دعواتون شده ؟ اشکال نداره ما براتون مشکلتونو حل میکنیم", null, 150000, "کارواش" },
                    { 9, 5, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2610), "دیگه اگه موبایلت درست کار نکنه چه جوری می خوای زندگی کنی", null, 600000, "تعمیرات موبایل" },
                    { 10, 5, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2620), "حوصله نداری تا مغازه بری ما میاییم پیشت", null, 500000, "تعیرات لپ تاپ" },
                    { 11, 6, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2620), "می خوای نقل مکان کنی ؟ ما برات  بسته  بندی  و انجام میدیم", null, 200000, "سرویس بسته بندی" },
                    { 12, 6, new DateTime(2024, 4, 30, 9, 2, 24, 836, DateTimeKind.Local).AddTicks(2620), "می خوای نقل مکان کنی ؟ ما برات انجام میدیم", null, 700000, "اسباب کشی" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
