using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeLearnAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), "0c6b4d64-2431-420d-8568-67b7a4d2d833", "Teacher", "TEACHER" },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), "49f4ba6c-9123-444b-8e44-063342f55684", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"));
        }
    }
}
