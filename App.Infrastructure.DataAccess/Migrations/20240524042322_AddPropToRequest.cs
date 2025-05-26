using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPropToRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeadLine",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34eb570f-8960-4328-bb4d-1531969a3a3d", "AQAAAAIAAYagAAAAEGXlAp/INAcavbisgQMP4w1HoS4ZS/0FeGUivUCywWtDOwnLRmwYaoo3eg5hekKiag==", "967b079b-e7f5-46af-9262-97de5d65941f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bfcc9de-5a03-4a5b-b774-89935d741890", "AQAAAAIAAYagAAAAELWVoOJTrUgYoJDe4zsut0wfgIh2G3/TvBrgod0ZhhYlH4HBw+joig/LaV1DxbluFA==", "77710c24-f1a0-4f08-b5b2-61c961d8a3c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ee17c0a-01da-464f-bca2-ae32fdf05ad9", "AQAAAAIAAYagAAAAEGX1x90f/dhyjN/GH4Do7sloAc/xDnkRAwNfGgObrGpuUbAQLQmcqm2vwhz9HZxRDA==", "edc93947-e947-4b3d-bfff-46dcbf1d54c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3388030-ae23-46d7-8fc0-3d87da6582f3", "AQAAAAIAAYagAAAAED5zMyAXSRdOW4cu/bJ7Tt/aKisNIZEVFo1J6hpgsrHGbu+KzIvUzyodC8mPcDR8CA==", "a57d47ad-fe56-4882-9f73-8299a56342b8" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 24, 7, 53, 20, 973, DateTimeKind.Local).AddTicks(6120), new DateTime(2024, 5, 24, 7, 53, 20, 973, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 24, 7, 53, 20, 974, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 5, 24, 7, 53, 20, 974, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 24, 7, 53, 20, 974, DateTimeKind.Local).AddTicks(2830), new DateTime(2024, 5, 24, 7, 53, 20, 974, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 7, 53, 20, 977, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.CreateIndex(
                name: "IX_Requests_AddressId",
                table: "Requests",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Addresses_AddressId",
                table: "Requests",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Addresses_AddressId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_AddressId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "DeadLine",
                table: "Requests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d77b9e47-fb83-4426-8ea8-996d22136002", "AQAAAAIAAYagAAAAEOR1VAfVDDUzB70uK8p2uiJ9lPwTQmIwwS7oZHV89g69xizjWCwCa7CFOMLfXwLsig==", "6dbc8e75-41fa-4e56-9c66-3a98eab403d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9940057-036a-435f-8473-44a7695b02ae", "AQAAAAIAAYagAAAAEESCyZHUNGLrhdFo3J3nD2oX3poUB3/9dwcKVzQdAhQWxPJwhoYxO98JiQvHmPdJqQ==", "2056778c-7746-4c91-a34c-4a720c0354dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41e79fb4-76c4-4f4f-961a-bcb4a25650f6", "AQAAAAIAAYagAAAAEFHKMQRRlnvyYhd8rxOAzK6Q8iMNmM0KTWNMR8dyg2/wqCetPdGnGeVV+BkSyKM7/w==", "523d7738-6e2c-4d89-875c-63603f29c280" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "413651ea-0a60-4882-8b03-cb1ec588c17a", "AQAAAAIAAYagAAAAEBrtEYx5mqPIBBHhFHCq6RjxzMjshtEjz/u6XnfwTXR32jyVoCAXfi2IVrjFh7DGHQ==", "74f0bd1d-27dd-40f5-8f7f-306a9016aa8a" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 22, 23, 23, 54, 240, DateTimeKind.Local).AddTicks(550), new DateTime(2024, 5, 22, 23, 23, 54, 240, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 22, 23, 23, 54, 240, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 5, 22, 23, 23, 54, 240, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RegisteredAt" },
                values: new object[] { new DateTime(2024, 5, 22, 23, 23, 54, 240, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 5, 22, 23, 23, 54, 240, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 245, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 245, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 245, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 245, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 245, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "SkillServeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 245, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "SkillServes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 23, 23, 54, 244, DateTimeKind.Local).AddTicks(6430));
        }
    }
}
