using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeLearnAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("02e843dd-92e9-43f3-a932-ef3f56427a69"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f0ed550-eb5a-41e3-9541-2a33ac99e89b"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e03e8c8-2d17-43ce-9cf3-13ef6b3898a0"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("20e2b281-fc38-4459-b833-3cd4c18c64f4"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("291c475f-1188-40bd-8d1f-848ec8fd2f72"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e91cc36-60ac-4a6c-9465-5a3e5c03214f"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3d3d1804-cdd2-4b07-884c-548f1a2bd42e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e2ff54a-8a44-4f94-bd60-de2934648168"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fb5a876-044c-4d8b-892f-7d4185058516"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("41d5900b-4705-437a-920e-d7d2de3cc5c4"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5202a525-6d58-47dd-96b9-43a0364665f0"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("57d43eb2-5286-40ae-82c3-8b2cf3022c52"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("67fb050c-8840-432e-99a4-62cfcf9428c6"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b56437c-c0d5-4ac3-8b22-99dc6e58ae12"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a6e0abe-53d8-4f4e-9e04-b4040315f3f3"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7f104f9d-883a-4cb9-9c83-5394e42832de"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("84898997-ae7a-4859-ac0a-8fca696418ae"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("85c9159e-49e5-459f-a672-942d420f526e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9eaafbaa-8370-4193-a434-bc13ee746054"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9fcc1a2d-3f79-402e-87ae-13511370048c"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3245e28-dad6-4ae4-bb62-46c355c4cd4d"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bab0ba44-6a0d-44be-8a3a-cb3c3ba3e964"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("be84443b-68c0-40b5-9a1f-bc17a850df1d"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ca4dc07d-0476-4e05-98b1-b088531d7c95"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d08a39a6-4f77-42df-b8be-94645d050582"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("dce6d8d3-81eb-49c8-93f2-25c66ba15c7e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e37c15a7-b7ea-4c87-a281-8c8819887d23"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ef317eca-b069-42cd-b2ee-7bbb7647d976"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1157ee5-f369-4999-9f53-b774a31f083a"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd908cd0-6885-4cb1-9b24-f643e6986dbb"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("093952f0-3c99-4d7f-a55c-044a439c2a80") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1550609e-55b1-41fb-95fc-f97130414df0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("17dda6d3-9ee2-4730-96a8-eeb4808ecc1c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("27b4f856-9c33-4973-8a7f-eaf4e0f309b0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("2930efdc-a6f1-4f2c-87ef-d3578be79c85") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("30c1f7a5-9a4b-437c-ab10-6c2dfb149288") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("4b34ce73-b81a-4c7f-aea2-dfafddb0a77e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("9aafc0a1-b895-4469-820a-a30cb85555f3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c3ab4ebd-6d78-4936-8f48-2a82bf4b506e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("ca0c920b-977c-4271-9888-c1255caf2aef") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("cad48058-ec90-425f-906d-c5b558b028b4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("d2601590-4a39-48b4-be4b-df5b36edc175") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("d2601590-4a39-48b4-be4b-df5b36edc175") });

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("093952f0-3c99-4d7f-a55c-044a439c2a80"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1550609e-55b1-41fb-95fc-f97130414df0"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("17dda6d3-9ee2-4730-96a8-eeb4808ecc1c"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("27b4f856-9c33-4973-8a7f-eaf4e0f309b0"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2930efdc-a6f1-4f2c-87ef-d3578be79c85"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("30c1f7a5-9a4b-437c-ab10-6c2dfb149288"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("4b34ce73-b81a-4c7f-aea2-dfafddb0a77e"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("9aafc0a1-b895-4469-820a-a30cb85555f3"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c3ab4ebd-6d78-4936-8f48-2a82bf4b506e"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ca0c920b-977c-4271-9888-c1255caf2aef"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("cad48058-ec90-425f-906d-c5b558b028b4"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("1451b12d-9c03-4088-9934-5603483c1acf"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4559c446-4f68-4be6-8995-1469489bb31b", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7344), "teacher6@example.com", true, "Teacher6", (byte)1, null, "User", false, null, "TEACHER6@EXAMPLE.COM", "TEACHER6", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7344), "teacher6" },
                    { new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9e213b71-cda6-4851-8943-61289ea7e824", new DateTime(2024, 9, 30, 8, 47, 58, 757, DateTimeKind.Local).AddTicks(2767), "admin1@example.com", true, "FirstAdmin", (byte)1, null, "Admin", false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1", "AQAAAAIAAYagAAAAEDeRvh96NNgh54caBaBB7tTHgBE3nBOzz/goZfbYFPswKXr5HdXouP3qf+bkqt4UjQ==", null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 757, DateTimeKind.Local).AddTicks(2782), "admin1" },
                    { new Guid("2952c90a-1718-4c77-b66c-a40c2292a710"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "682d012d-755c-43de-a3ee-5961dad12767", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(5438), "teacher1@example.com", true, "Teacher1", (byte)1, null, "User", false, null, "TEACHER1@EXAMPLE.COM", "TEACHER1", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(5439), "teacher1" },
                    { new Guid("3b6b8489-4075-4625-9689-06d4884cd027"), 0, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "324f7a56-7310-4565-ad6b-76a93755c83a", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(4559), "admin2@example.com", true, "SecondAdmin", (byte)1, null, "Admin", false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2", "AQAAAAIAAYagAAAAEDMW/4W9RiSYDtRh67dOd6EQcQmHm1LfgV1ZG3d+6EMR2r4Bs5SKg2WT+5zY7NFrSQ==", null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(4576), "admin2" },
                    { new Guid("801e660c-638e-40b1-83f2-fe550965a213"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "edd5315b-62c0-4f44-9210-71da2f10d873", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7205), "teacher5@example.com", true, "Teacher5", (byte)1, null, "User", false, null, "TEACHER5@EXAMPLE.COM", "TEACHER5", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7206), "teacher5" },
                    { new Guid("8d7aac49-009d-497e-a303-2bbb1b31c3c9"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ca29be8-e464-4380-8325-ae41d09ed739", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7603), "teacher8@example.com", true, "Teacher8", (byte)1, null, "User", false, null, "TEACHER8@EXAMPLE.COM", "TEACHER8", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7604), "teacher8" },
                    { new Guid("9780ac73-137e-45b8-9870-789bd2878e35"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "61352dda-daef-4db9-b7d5-1f01e72f4fc0", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(5788), "teacher3@example.com", true, "Teacher3", (byte)1, null, "User", false, null, "TEACHER3@EXAMPLE.COM", "TEACHER3", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(5788), "teacher3" },
                    { new Guid("b29fa928-0d73-4260-bed8-9ebd2a637177"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "19562a4d-3e48-4379-a9c5-0f119a830d2e", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(5643), "teacher2@example.com", true, "Teacher2", (byte)1, null, "User", false, null, "TEACHER2@EXAMPLE.COM", "TEACHER2", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(5644), "teacher2" },
                    { new Guid("bd52a710-92d4-49f4-8f08-fd55a4c5a43d"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b6186480-e42b-40b4-ad1f-19e62024b0fb", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7417), "teacher7@example.com", true, "Teacher7", (byte)1, null, "User", false, null, "TEACHER7@EXAMPLE.COM", "TEACHER7", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7428), "teacher7" },
                    { new Guid("c0173fa1-a2c8-402a-9fec-bc2f0f9a0113"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "95876dc9-21c7-457e-be4e-d5ecf9948930", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7739), "teacher10@example.com", true, "Teacher10", (byte)1, null, "User", false, null, "TEACHER10@EXAMPLE.COM", "TEACHER10", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7739), "teacher10" },
                    { new Guid("df9f3af1-aa5b-4c62-968e-c351bdd6ba18"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "22835d6c-5848-4391-b19d-845e8a74ee14", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(5870), "teacher4@example.com", true, "Teacher4", (byte)1, null, "User", false, null, "TEACHER4@EXAMPLE.COM", "TEACHER4", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(5871), "teacher4" },
                    { new Guid("e41a9e36-1fb2-4f3c-97a5-f4436c5cf158"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a45ba32c-c858-4bd2-ab19-17d9539befce", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7677), "teacher9@example.com", true, "Teacher9", (byte)1, null, "User", false, null, "TEACHER9@EXAMPLE.COM", "TEACHER9", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7677), "teacher9" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("0936b8aa-2e91-4506-a69a-1848ef9ed8c1"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "568a9313-8172-4c58-bae6-2ec1c37b8bad", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8069), "user4@example.com", true, "UserFirstName4", (byte)1, null, "UserLastName4", false, null, "USER4@EXAMPLE.COM", "USER4", null, null, false, "refresh_token_4", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8069), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8070), "user4" },
                    { new Guid("15ef872e-d8f7-456f-b449-6026b162ca83"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "028fce45-f3bf-4e5e-ba82-3d08d5cac575", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8260), "user7@example.com", true, "UserFirstName7", (byte)1, null, "UserLastName7", false, null, "USER7@EXAMPLE.COM", "USER7", null, null, false, "refresh_token_7", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8259), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8260), "user7" },
                    { new Guid("1805203f-0b4c-42c6-807b-de4622fe6baf"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5c30d787-e229-4117-a6b1-1fe22e39f990", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8854), "user18@example.com", true, "UserFirstName18", (byte)1, null, "UserLastName18", false, null, "USER18@EXAMPLE.COM", "USER18", null, null, false, "refresh_token_18", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8853), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8854), "user18" },
                    { new Guid("2559b95a-c8c5-496f-bb02-efdccc3f0f58"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d17cfb30-3ac6-4eb9-ab78-4f3881858d4b", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5201), "user28@example.com", true, "UserFirstName28", (byte)1, null, "UserLastName28", false, null, "USER28@EXAMPLE.COM", "USER28", null, null, false, "refresh_token_28", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5200), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5201), "user28" },
                    { new Guid("2c3ae6d9-da07-43d3-9996-7be6e7719e42"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eb15c63d-267b-456a-a4b2-5b935de28381", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8772), "user16@example.com", true, "UserFirstName16", (byte)1, null, "UserLastName16", false, null, "USER16@EXAMPLE.COM", "USER16", null, null, false, "refresh_token_16", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8772), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8773), "user16" },
                    { new Guid("45df22c4-9ff1-488a-ad25-486ac5d41381"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c62aff03-41a5-4b2a-bdd9-68dfaaa1a8cb", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8811), "user17@example.com", true, "UserFirstName17", (byte)1, null, "UserLastName17", false, null, "USER17@EXAMPLE.COM", "USER17", null, null, false, "refresh_token_17", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8811), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8811), "user17" },
                    { new Guid("48f622f2-c86a-4bc9-9df6-8879682e2251"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7a3ea47f-37e2-4bac-8ac6-1dcd1a9c1fa3", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7854), "user1@example.com", true, "UserFirstName1", (byte)1, null, "UserLastName1", false, null, "USER1@EXAMPLE.COM", "USER1", null, null, false, "refresh_token_1", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7827), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7855), "user1" },
                    { new Guid("4a5bb3f4-4474-4998-a75c-229863d941a5"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e142ba1b-27e1-4234-a3ac-9b58bb168dca", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8000), "user3@example.com", true, "UserFirstName3", (byte)1, null, "UserLastName3", false, null, "USER3@EXAMPLE.COM", "USER3", null, null, false, "refresh_token_3", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8000), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8001), "user3" },
                    { new Guid("4c975796-53f6-4a3e-bee2-bb1828a15bb3"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fce4e7ea-32d3-4758-9560-79c9cb319acd", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4930), "user21@example.com", true, "UserFirstName21", (byte)1, null, "UserLastName21", false, null, "USER21@EXAMPLE.COM", "USER21", null, null, false, "refresh_token_21", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4930), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4931), "user21" },
                    { new Guid("6b617dd8-620e-4151-913b-ade9b5ff4025"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dc1fd07c-98b9-4ffb-ad65-67552e6a1131", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5233), "user29@example.com", true, "UserFirstName29", (byte)1, null, "UserLastName29", false, null, "USER29@EXAMPLE.COM", "USER29", null, null, false, "refresh_token_29", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5232), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5233), "user29" },
                    { new Guid("6df298a5-7fc9-405a-971e-40c769aa648b"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a1f42eb-01ea-4424-8694-2e3711ce5993", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8568), "user11@example.com", true, "UserFirstName11", (byte)1, null, "UserLastName11", false, null, "USER11@EXAMPLE.COM", "USER11", null, null, false, "refresh_token_11", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8568), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8569), "user11" },
                    { new Guid("76bc427f-8ac4-4d0d-ace6-2a775a34f7d1"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f4556ffe-5acb-4314-b463-8494313e6a5a", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5129), "user26@example.com", true, "UserFirstName26", (byte)1, null, "UserLastName26", false, null, "USER26@EXAMPLE.COM", "USER26", null, null, false, "refresh_token_26", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5129), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5130), "user26" },
                    { new Guid("77de27ae-d777-46dc-aaad-dc93da3d807c"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "66d3825e-9fe5-4224-9c26-a13018d2e807", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5165), "user27@example.com", true, "UserFirstName27", (byte)1, null, "UserLastName27", false, null, "USER27@EXAMPLE.COM", "USER27", null, null, false, "refresh_token_27", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5164), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5165), "user27" },
                    { new Guid("78836550-dbba-4367-921c-38cb502fb5a6"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4b244f17-050e-4818-b097-44577a769f55", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8478), "user9@example.com", true, "UserFirstName9", (byte)1, null, "UserLastName9", false, null, "USER9@EXAMPLE.COM", "USER9", null, null, false, "refresh_token_9", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8477), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8478), "user9" },
                    { new Guid("7a402ab8-8c66-41b0-b468-7ff46a0baf10"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5f963f8c-a877-4e6e-af98-956a13fa930e", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8209), "user6@example.com", true, "UserFirstName6", (byte)1, null, "UserLastName6", false, null, "USER6@EXAMPLE.COM", "USER6", null, null, false, "refresh_token_6", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8208), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8209), "user6" },
                    { new Guid("7c3df089-0008-49da-8cf0-c384f48cabe4"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d8558e5f-3ab8-4531-aee2-fc1143351e08", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8605), "user12@example.com", true, "UserFirstName12", (byte)1, null, "UserLastName12", false, null, "USER12@EXAMPLE.COM", "USER12", null, null, false, "refresh_token_12", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8605), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8605), "user12" },
                    { new Guid("7d326f55-98c3-4633-b278-354547634903"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7e826986-f548-442b-8f05-25c06b0f7cd4", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4731), "user19@example.com", true, "UserFirstName19", (byte)1, null, "UserLastName19", false, null, "USER19@EXAMPLE.COM", "USER19", null, null, false, "refresh_token_19", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4728), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4731), "user19" },
                    { new Guid("886601fc-94a8-4596-932e-9d7d419d6534"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "694f43c5-fe89-44cf-adf7-184e1a352399", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8529), "user10@example.com", true, "UserFirstName10", (byte)1, null, "UserLastName10", false, null, "USER10@EXAMPLE.COM", "USER10", null, null, false, "refresh_token_10", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8528), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8529), "user10" },
                    { new Guid("904737ed-0e8c-4572-b644-4e5acb2d0a0b"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ae49192c-0b74-4557-b077-98f844e41aa7", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8154), "user5@example.com", true, "UserFirstName5", (byte)1, null, "UserLastName5", false, null, "USER5@EXAMPLE.COM", "USER5", null, null, false, "refresh_token_5", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8153), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8154), "user5" },
                    { new Guid("9077bcbb-5dbb-4f7a-b2ff-40ac7a1e5584"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "17807433-6cfe-46ba-bbd3-2ea30d93063a", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8297), "user8@example.com", true, "UserFirstName8", (byte)1, null, "UserLastName8", false, null, "USER8@EXAMPLE.COM", "USER8", null, null, false, "refresh_token_8", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8297), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8298), "user8" },
                    { new Guid("984ca89c-8a60-4f42-9335-c734bbf7b1b6"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8833e600-87cd-4fee-b985-5d7a2def1d37", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8730), "user15@example.com", true, "UserFirstName15", (byte)1, null, "UserLastName15", false, null, "USER15@EXAMPLE.COM", "USER15", null, null, false, "refresh_token_15", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8729), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8730), "user15" },
                    { new Guid("a0a15df6-7842-451b-8631-7e8d931c30e2"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "83f7fcb9-a260-4cad-b64c-e7d114f7a34b", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8686), "user14@example.com", true, "UserFirstName14", (byte)1, null, "UserLastName14", false, null, "USER14@EXAMPLE.COM", "USER14", null, null, false, "refresh_token_14", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8686), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8687), "user14" },
                    { new Guid("a7458ddc-f7f4-4a9c-8313-a1273557e2aa"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "28d64d93-0fe9-4d38-a9d2-0c98e8e0318a", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5271), "user30@example.com", true, "UserFirstName30", (byte)1, null, "UserLastName30", false, null, "USER30@EXAMPLE.COM", "USER30", null, null, false, "refresh_token_30", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5263), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5271), "user30" },
                    { new Guid("c1b0e3f1-2b95-4f4d-a02b-bc372557e4b9"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a27684bc-ab76-4420-ab6c-37bfd2a9fd65", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8646), "user13@example.com", true, "UserFirstName13", (byte)1, null, "UserLastName13", false, null, "USER13@EXAMPLE.COM", "USER13", null, null, false, "refresh_token_13", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8645), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(8646), "user13" },
                    { new Guid("c92707e6-9316-4ada-ab9b-1c9e2ac1eede"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6203f082-c14c-48bc-be1b-bf9821a5cec4", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5002), "user23@example.com", true, "UserFirstName23", (byte)1, null, "UserLastName23", false, null, "USER23@EXAMPLE.COM", "USER23", null, null, false, "refresh_token_23", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5002), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5003), "user23" },
                    { new Guid("d417222d-119f-4547-874b-f713c567a96e"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0d826964-8689-4ba2-9a7d-6d3f5ffb7118", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5048), "user24@example.com", true, "UserFirstName24", (byte)1, null, "UserLastName24", false, null, "USER24@EXAMPLE.COM", "USER24", null, null, false, "refresh_token_24", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5048), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5049), "user24" },
                    { new Guid("e7f5a4ea-4949-4427-959d-30368714167b"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ffdf9beb-875c-4edc-91da-195559480daf", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4967), "user22@example.com", true, "UserFirstName22", (byte)1, null, "UserLastName22", false, null, "USER22@EXAMPLE.COM", "USER22", null, null, false, "refresh_token_22", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4967), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4968), "user22" },
                    { new Guid("eccf73c2-a551-452b-9a9e-f600e4f4e6fe"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a95ab39d-4004-4530-b1b7-9b6494371071", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4882), "user20@example.com", true, "UserFirstName20", (byte)1, null, "UserLastName20", false, null, "USER20@EXAMPLE.COM", "USER20", null, null, false, "refresh_token_20", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4882), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(4883), "user20" },
                    { new Guid("ed22c4fd-5894-480e-bb3f-c37aa95fa4bc"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5a27e39c-284f-43bb-8043-207f59d8273b", new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7939), "user2@example.com", true, "UserFirstName2", (byte)1, null, "UserLastName2", false, null, "USER2@EXAMPLE.COM", "USER2", null, null, false, "refresh_token_2", new DateTime(2024, 10, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7937), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 837, DateTimeKind.Local).AddTicks(7940), "user2" },
                    { new Guid("f659691a-11c6-4517-9b56-e3428f7b26ee"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "92dfa931-fb66-4346-af14-80146998c2b9", new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5090), "user25@example.com", true, "UserFirstName25", (byte)1, null, "UserLastName25", false, null, "USER25@EXAMPLE.COM", "USER25", null, null, false, "refresh_token_25", new DateTime(2024, 10, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5090), null, null, false, new DateTime(2024, 9, 30, 8, 47, 58, 838, DateTimeKind.Local).AddTicks(5091), "user25" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1451b12d-9c03-4088-9934-5603483c1acf") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("28259c6d-5f55-4f75-9964-11b5079153c8") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("28259c6d-5f55-4f75-9964-11b5079153c8") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("2952c90a-1718-4c77-b66c-a40c2292a710") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("3b6b8489-4075-4625-9689-06d4884cd027") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("801e660c-638e-40b1-83f2-fe550965a213") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("8d7aac49-009d-497e-a303-2bbb1b31c3c9") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("9780ac73-137e-45b8-9870-789bd2878e35") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("b29fa928-0d73-4260-bed8-9ebd2a637177") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("bd52a710-92d4-49f4-8f08-fd55a4c5a43d") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c0173fa1-a2c8-402a-9fec-bc2f0f9a0113") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("df9f3af1-aa5b-4c62-968e-c351bdd6ba18") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("e41a9e36-1fb2-4f3c-97a5-f4436c5cf158") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "AdminId", "Content", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 8", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 8", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 9", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 9", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 10", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 10", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 11", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 11", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 12", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 12", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 13", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 13", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 14", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 14", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 15", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 15", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 16", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 16", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 17", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 17", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 18", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 18", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 19", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 19", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 20", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 20", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 21", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 21", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 22", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 22", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 23", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 23", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 25", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 25", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 26", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 26", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 27", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 27", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 28", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 28", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 29", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 29", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"), "This is the content of news 30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0936b8aa-2e91-4506-a69a-1848ef9ed8c1"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("15ef872e-d8f7-456f-b449-6026b162ca83"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1805203f-0b4c-42c6-807b-de4622fe6baf"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2559b95a-c8c5-496f-bb02-efdccc3f0f58"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c3ae6d9-da07-43d3-9996-7be6e7719e42"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45df22c4-9ff1-488a-ad25-486ac5d41381"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("48f622f2-c86a-4bc9-9df6-8879682e2251"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4a5bb3f4-4474-4998-a75c-229863d941a5"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c975796-53f6-4a3e-bee2-bb1828a15bb3"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b617dd8-620e-4151-913b-ade9b5ff4025"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6df298a5-7fc9-405a-971e-40c769aa648b"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("76bc427f-8ac4-4d0d-ace6-2a775a34f7d1"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("77de27ae-d777-46dc-aaad-dc93da3d807c"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("78836550-dbba-4367-921c-38cb502fb5a6"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a402ab8-8c66-41b0-b468-7ff46a0baf10"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c3df089-0008-49da-8cf0-c384f48cabe4"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d326f55-98c3-4633-b278-354547634903"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("886601fc-94a8-4596-932e-9d7d419d6534"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("904737ed-0e8c-4572-b644-4e5acb2d0a0b"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9077bcbb-5dbb-4f7a-b2ff-40ac7a1e5584"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("984ca89c-8a60-4f42-9335-c734bbf7b1b6"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0a15df6-7842-451b-8631-7e8d931c30e2"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a7458ddc-f7f4-4a9c-8313-a1273557e2aa"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1b0e3f1-2b95-4f4d-a02b-bc372557e4b9"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c92707e6-9316-4ada-ab9b-1c9e2ac1eede"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d417222d-119f-4547-874b-f713c567a96e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7f5a4ea-4949-4427-959d-30368714167b"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("eccf73c2-a551-452b-9a9e-f600e4f4e6fe"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed22c4fd-5894-480e-bb3f-c37aa95fa4bc"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f659691a-11c6-4517-9b56-e3428f7b26ee"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1451b12d-9c03-4088-9934-5603483c1acf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("28259c6d-5f55-4f75-9964-11b5079153c8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("28259c6d-5f55-4f75-9964-11b5079153c8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("2952c90a-1718-4c77-b66c-a40c2292a710") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("3b6b8489-4075-4625-9689-06d4884cd027") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("801e660c-638e-40b1-83f2-fe550965a213") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("8d7aac49-009d-497e-a303-2bbb1b31c3c9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("9780ac73-137e-45b8-9870-789bd2878e35") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("b29fa928-0d73-4260-bed8-9ebd2a637177") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("bd52a710-92d4-49f4-8f08-fd55a4c5a43d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c0173fa1-a2c8-402a-9fec-bc2f0f9a0113") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("df9f3af1-aa5b-4c62-968e-c351bdd6ba18") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("e41a9e36-1fb2-4f3c-97a5-f4436c5cf158") });

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1451b12d-9c03-4088-9934-5603483c1acf"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2952c90a-1718-4c77-b66c-a40c2292a710"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("3b6b8489-4075-4625-9689-06d4884cd027"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("801e660c-638e-40b1-83f2-fe550965a213"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("8d7aac49-009d-497e-a303-2bbb1b31c3c9"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("9780ac73-137e-45b8-9870-789bd2878e35"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b29fa928-0d73-4260-bed8-9ebd2a637177"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("bd52a710-92d4-49f4-8f08-fd55a4c5a43d"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c0173fa1-a2c8-402a-9fec-bc2f0f9a0113"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("df9f3af1-aa5b-4c62-968e-c351bdd6ba18"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e41a9e36-1fb2-4f3c-97a5-f4436c5cf158"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("093952f0-3c99-4d7f-a55c-044a439c2a80"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc734d18-477a-4187-ac47-d9f868182ae1", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2559), "teacher10@example.com", true, "Teacher10", (byte)1, null, "User", false, null, "TEACHER10@EXAMPLE.COM", "TEACHER10", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2559), "teacher10" },
                    { new Guid("1550609e-55b1-41fb-95fc-f97130414df0"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "53114206-d80c-4747-8b54-93662166803d", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2102), "teacher1@example.com", true, "Teacher1", (byte)1, null, "User", false, null, "TEACHER1@EXAMPLE.COM", "TEACHER1", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2102), "teacher1" },
                    { new Guid("17dda6d3-9ee2-4730-96a8-eeb4808ecc1c"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1795e845-ba78-4a32-be9b-035b235f705f", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2356), "teacher5@example.com", true, "Teacher5", (byte)1, null, "User", false, null, "TEACHER5@EXAMPLE.COM", "TEACHER5", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2357), "teacher5" },
                    { new Guid("27b4f856-9c33-4973-8a7f-eaf4e0f309b0"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "228307c3-3f1e-451d-9758-3519a446f1d9", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2204), "teacher3@example.com", true, "Teacher3", (byte)1, null, "User", false, null, "TEACHER3@EXAMPLE.COM", "TEACHER3", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2205), "teacher3" },
                    { new Guid("2930efdc-a6f1-4f2c-87ef-d3578be79c85"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cbf32e0e-cd5e-4ef7-83f1-b9afda193bbc", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2311), "teacher4@example.com", true, "Teacher4", (byte)1, null, "User", false, null, "TEACHER4@EXAMPLE.COM", "TEACHER4", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2312), "teacher4" },
                    { new Guid("30c1f7a5-9a4b-437c-ab10-6c2dfb149288"), 0, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "876799ca-8356-45f3-972a-d6d41499fd78", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(1556), "admin2@example.com", true, "SecondAdmin", (byte)1, null, "Admin", false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2", "AQAAAAIAAYagAAAAEHFBwjBzUOJpPOydmdRSsYU2d4DgW4MZVdBlWP/b7zmHiujyAhci8wn0V3v9NoWMDg==", null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(1572), "admin2" },
                    { new Guid("4b34ce73-b81a-4c7f-aea2-dfafddb0a77e"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5089bca5-2e3a-447d-a04e-73319b752c8b", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2517), "teacher9@example.com", true, "Teacher9", (byte)1, null, "User", false, null, "TEACHER9@EXAMPLE.COM", "TEACHER9", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2517), "teacher9" },
                    { new Guid("9aafc0a1-b895-4469-820a-a30cb85555f3"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5b3512a2-660c-4b51-9b23-fc3761d0106e", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2477), "teacher8@example.com", true, "Teacher8", (byte)1, null, "User", false, null, "TEACHER8@EXAMPLE.COM", "TEACHER8", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2477), "teacher8" },
                    { new Guid("c3ab4ebd-6d78-4936-8f48-2a82bf4b506e"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ec55f904-97ff-4cb9-ab81-86d0cc476d5a", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2154), "teacher2@example.com", true, "Teacher2", (byte)1, null, "User", false, null, "TEACHER2@EXAMPLE.COM", "TEACHER2", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2154), "teacher2" },
                    { new Guid("ca0c920b-977c-4271-9888-c1255caf2aef"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d6da3697-a5b2-4e3e-a195-a9f22f8cc6b1", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2437), "teacher7@example.com", true, "Teacher7", (byte)1, null, "User", false, null, "TEACHER7@EXAMPLE.COM", "TEACHER7", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2438), "teacher7" },
                    { new Guid("cad48058-ec90-425f-906d-c5b558b028b4"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4fc8e33a-4700-4ab4-90ab-9684c5ef21a3", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2396), "teacher6@example.com", true, "Teacher6", (byte)1, null, "User", false, null, "TEACHER6@EXAMPLE.COM", "TEACHER6", null, null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2396), "teacher6" },
                    { new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d8378dda-2e85-41bf-8282-21792dfbca32", new DateTime(2024, 9, 30, 8, 43, 6, 410, DateTimeKind.Local).AddTicks(2258), "admin1@example.com", true, "FirstAdmin", (byte)1, null, "Admin", false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1", "AQAAAAIAAYagAAAAEJg0Hm706NAK/ucn+eN1D8/AiPxCkJNVV0YKpmWSluQINDaSoZVmeSEy4JOLVMzN2Q==", null, false, null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 410, DateTimeKind.Local).AddTicks(2273), "admin1" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("02e843dd-92e9-43f3-a932-ef3f56427a69"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "199911e8-af1a-4189-8a92-803b120951d6", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3411), "user22@example.com", true, "UserFirstName22", (byte)1, null, "UserLastName22", false, null, "USER22@EXAMPLE.COM", "USER22", null, null, false, "refresh_token_22", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3411), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3412), "user22" },
                    { new Guid("0f0ed550-eb5a-41e3-9541-2a33ac99e89b"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bfa0d95-d87e-4eab-aab1-8c6a23b65ed5", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2734), "user4@example.com", true, "UserFirstName4", (byte)1, null, "UserLastName4", false, null, "USER4@EXAMPLE.COM", "USER4", null, null, false, "refresh_token_4", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2734), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2735), "user4" },
                    { new Guid("1e03e8c8-2d17-43ce-9cf3-13ef6b3898a0"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "75907853-e2ae-46e4-ba42-3b79c342c484", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3441), "user23@example.com", true, "UserFirstName23", (byte)1, null, "UserLastName23", false, null, "USER23@EXAMPLE.COM", "USER23", null, null, false, "refresh_token_23", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3441), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3442), "user23" },
                    { new Guid("20e2b281-fc38-4459-b833-3cd4c18c64f4"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "88f8ee39-b962-4534-bb66-643df62314e9", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2763), "user5@example.com", true, "UserFirstName5", (byte)1, null, "UserLastName5", false, null, "USER5@EXAMPLE.COM", "USER5", null, null, false, "refresh_token_5", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2762), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2763), "user5" },
                    { new Guid("291c475f-1188-40bd-8d1f-848ec8fd2f72"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "460e3848-9326-43b7-8e11-2a20d2a54b28", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3060), "user15@example.com", true, "UserFirstName15", (byte)1, null, "UserLastName15", false, null, "USER15@EXAMPLE.COM", "USER15", null, null, false, "refresh_token_15", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3059), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3060), "user15" },
                    { new Guid("2e91cc36-60ac-4a6c-9465-5a3e5c03214f"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7d1f0485-bbb2-4c93-8a26-2daba9ea04d5", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2973), "user12@example.com", true, "UserFirstName12", (byte)1, null, "UserLastName12", false, null, "USER12@EXAMPLE.COM", "USER12", null, null, false, "refresh_token_12", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2972), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2973), "user12" },
                    { new Guid("3d3d1804-cdd2-4b07-884c-548f1a2bd42e"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a1a099c9-5b43-436b-ae0c-923b1aebe42f", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2636), "user1@example.com", true, "UserFirstName1", (byte)1, null, "UserLastName1", false, null, "USER1@EXAMPLE.COM", "USER1", null, null, false, "refresh_token_1", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2629), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2637), "user1" },
                    { new Guid("3e2ff54a-8a44-4f94-bd60-de2934648168"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ab3107f-c302-49ef-8dd1-b1e745684d53", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2794), "user6@example.com", true, "UserFirstName6", (byte)1, null, "UserLastName6", false, null, "USER6@EXAMPLE.COM", "USER6", null, null, false, "refresh_token_6", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2793), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2794), "user6" },
                    { new Guid("3fb5a876-044c-4d8b-892f-7d4185058516"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b5a1e892-c10c-44e4-8ea7-f39898d0e353", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3118), "user17@example.com", true, "UserFirstName17", (byte)1, null, "UserLastName17", false, null, "USER17@EXAMPLE.COM", "USER17", null, null, false, "refresh_token_17", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3117), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3118), "user17" },
                    { new Guid("41d5900b-4705-437a-920e-d7d2de3cc5c4"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "915744c0-536d-4052-a6c0-a2c5f7fb0b95", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3556), "user27@example.com", true, "UserFirstName27", (byte)1, null, "UserLastName27", false, null, "USER27@EXAMPLE.COM", "USER27", null, null, false, "refresh_token_27", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3555), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3556), "user27" },
                    { new Guid("5202a525-6d58-47dd-96b9-43a0364665f0"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2c0ef9cc-5217-4c01-8b88-7a40c31665db", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3384), "user21@example.com", true, "UserFirstName21", (byte)1, null, "UserLastName21", false, null, "USER21@EXAMPLE.COM", "USER21", null, null, false, "refresh_token_21", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3383), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3384), "user21" },
                    { new Guid("57d43eb2-5286-40ae-82c3-8b2cf3022c52"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cba66902-74d5-43d6-b658-a208b0d2d9da", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3593), "user28@example.com", true, "UserFirstName28", (byte)1, null, "UserLastName28", false, null, "USER28@EXAMPLE.COM", "USER28", null, null, false, "refresh_token_28", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3592), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3593), "user28" },
                    { new Guid("67fb050c-8840-432e-99a4-62cfcf9428c6"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "97243307-6241-4b62-9da3-a4da2bb2b4a2", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2825), "user7@example.com", true, "UserFirstName7", (byte)1, null, "UserLastName7", false, null, "USER7@EXAMPLE.COM", "USER7", null, null, false, "refresh_token_7", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2824), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2825), "user7" },
                    { new Guid("6b56437c-c0d5-4ac3-8b22-99dc6e58ae12"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bea6c8c0-289f-4e05-9fda-346dadffb5b6", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3028), "user14@example.com", true, "UserFirstName14", (byte)1, null, "UserLastName14", false, null, "USER14@EXAMPLE.COM", "USER14", null, null, false, "refresh_token_14", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3028), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3029), "user14" },
                    { new Guid("7a6e0abe-53d8-4f4e-9e04-b4040315f3f3"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ecbec0ff-f0e4-4759-835e-2522a9862244", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3356), "user20@example.com", true, "UserFirstName20", (byte)1, null, "UserLastName20", false, null, "USER20@EXAMPLE.COM", "USER20", null, null, false, "refresh_token_20", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3356), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3357), "user20" },
                    { new Guid("7f104f9d-883a-4cb9-9c83-5394e42832de"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bdcd42f6-f49c-488c-9ef1-157991223af1", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2879), "user9@example.com", true, "UserFirstName9", (byte)1, null, "UserLastName9", false, null, "USER9@EXAMPLE.COM", "USER9", null, null, false, "refresh_token_9", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2878), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2879), "user9" },
                    { new Guid("84898997-ae7a-4859-ac0a-8fca696418ae"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eb05c1d6-f64c-4a17-a74c-30f539570116", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3526), "user26@example.com", true, "UserFirstName26", (byte)1, null, "UserLastName26", false, null, "USER26@EXAMPLE.COM", "USER26", null, null, false, "refresh_token_26", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3525), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3526), "user26" },
                    { new Guid("85c9159e-49e5-459f-a672-942d420f526e"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2da0d517-b9a2-426b-b4b8-3878b884dfa2", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2708), "user3@example.com", true, "UserFirstName3", (byte)1, null, "UserLastName3", false, null, "USER3@EXAMPLE.COM", "USER3", null, null, false, "refresh_token_3", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2707), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2708), "user3" },
                    { new Guid("9eaafbaa-8370-4193-a434-bc13ee746054"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0590e1a2-1310-46f7-9a0c-b41eb3e64dcd", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2909), "user10@example.com", true, "UserFirstName10", (byte)1, null, "UserLastName10", false, null, "USER10@EXAMPLE.COM", "USER10", null, null, false, "refresh_token_10", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2909), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2910), "user10" },
                    { new Guid("9fcc1a2d-3f79-402e-87ae-13511370048c"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b13c0c2b-97c3-4dfc-82cc-db74c5f5dcaf", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2851), "user8@example.com", true, "UserFirstName8", (byte)1, null, "UserLastName8", false, null, "USER8@EXAMPLE.COM", "USER8", null, null, false, "refresh_token_8", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2851), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2852), "user8" },
                    { new Guid("a3245e28-dad6-4ae4-bb62-46c355c4cd4d"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7d597e71-dc0b-4b52-8909-391a0f596a4a", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3327), "user19@example.com", true, "UserFirstName19", (byte)1, null, "UserLastName19", false, null, "USER19@EXAMPLE.COM", "USER19", null, null, false, "refresh_token_19", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3326), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3327), "user19" },
                    { new Guid("bab0ba44-6a0d-44be-8a3a-cb3c3ba3e964"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b24df753-da64-4a83-bb42-8aeb4d4739d3", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3621), "user29@example.com", true, "UserFirstName29", (byte)1, null, "UserLastName29", false, null, "USER29@EXAMPLE.COM", "USER29", null, null, false, "refresh_token_29", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3621), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3622), "user29" },
                    { new Guid("be84443b-68c0-40b5-9a1f-bc17a850df1d"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "422306cc-5677-46aa-b45e-7bfe67ce0ae9", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3088), "user16@example.com", true, "UserFirstName16", (byte)1, null, "UserLastName16", false, null, "USER16@EXAMPLE.COM", "USER16", null, null, false, "refresh_token_16", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3087), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3088), "user16" },
                    { new Guid("ca4dc07d-0476-4e05-98b1-b088531d7c95"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4b20ae86-6943-40a0-8e8d-f8d90061ee6e", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2945), "user11@example.com", true, "UserFirstName11", (byte)1, null, "UserLastName11", false, null, "USER11@EXAMPLE.COM", "USER11", null, null, false, "refresh_token_11", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2944), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2945), "user11" },
                    { new Guid("d08a39a6-4f77-42df-b8be-94645d050582"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f0ab3ad2-f06b-4618-9661-635991e2ac8e", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3148), "user18@example.com", true, "UserFirstName18", (byte)1, null, "UserLastName18", false, null, "USER18@EXAMPLE.COM", "USER18", null, null, false, "refresh_token_18", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3147), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3148), "user18" },
                    { new Guid("dce6d8d3-81eb-49c8-93f2-25c66ba15c7e"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0789b626-ebcb-4795-8b52-bc15899870b7", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3001), "user13@example.com", true, "UserFirstName13", (byte)1, null, "UserLastName13", false, null, "USER13@EXAMPLE.COM", "USER13", null, null, false, "refresh_token_13", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3000), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3001), "user13" },
                    { new Guid("e37c15a7-b7ea-4c87-a281-8c8819887d23"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "60374f5d-ceb8-4f80-b775-ef2390d9b4d7", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2676), "user2@example.com", true, "UserFirstName2", (byte)1, null, "UserLastName2", false, null, "USER2@EXAMPLE.COM", "USER2", null, null, false, "refresh_token_2", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2676), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(2677), "user2" },
                    { new Guid("ef317eca-b069-42cd-b2ee-7bbb7647d976"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d8084056-7139-463e-ae09-602bec5f43c9", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3497), "user25@example.com", true, "UserFirstName25", (byte)1, null, "UserLastName25", false, null, "USER25@EXAMPLE.COM", "USER25", null, null, false, "refresh_token_25", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3496), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3497), "user25" },
                    { new Guid("f1157ee5-f369-4999-9f53-b774a31f083a"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "49f7117e-2fd5-40e9-a182-b5397711a215", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3470), "user24@example.com", true, "UserFirstName24", (byte)1, null, "UserLastName24", false, null, "USER24@EXAMPLE.COM", "USER24", null, null, false, "refresh_token_24", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3469), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3470), "user24" },
                    { new Guid("fd908cd0-6885-4cb1-9b24-f643e6986dbb"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7998cd22-04f3-40c0-bcc0-7887756970ce", new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3650), "user30@example.com", true, "UserFirstName30", (byte)1, null, "UserLastName30", false, null, "USER30@EXAMPLE.COM", "USER30", null, null, false, "refresh_token_30", new DateTime(2024, 10, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3650), null, null, false, new DateTime(2024, 9, 30, 8, 43, 6, 488, DateTimeKind.Local).AddTicks(3651), "user30" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("093952f0-3c99-4d7f-a55c-044a439c2a80") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1550609e-55b1-41fb-95fc-f97130414df0") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("17dda6d3-9ee2-4730-96a8-eeb4808ecc1c") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("27b4f856-9c33-4973-8a7f-eaf4e0f309b0") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("2930efdc-a6f1-4f2c-87ef-d3578be79c85") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("30c1f7a5-9a4b-437c-ab10-6c2dfb149288") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("4b34ce73-b81a-4c7f-aea2-dfafddb0a77e") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("9aafc0a1-b895-4469-820a-a30cb85555f3") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c3ab4ebd-6d78-4936-8f48-2a82bf4b506e") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("ca0c920b-977c-4271-9888-c1255caf2aef") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("cad48058-ec90-425f-906d-c5b558b028b4") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("d2601590-4a39-48b4-be4b-df5b36edc175") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("d2601590-4a39-48b4-be4b-df5b36edc175") }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "AdminId", "Content", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { -30, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -29, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 29", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 29", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -28, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 28", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 28", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -27, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 27", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 27", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -26, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 26", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 26", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -25, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 25", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 25", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -24, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -23, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 23", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 23", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -22, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 22", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 22", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -21, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 21", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 21", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -20, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 20", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 20", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -19, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 19", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 19", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -18, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 18", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 18", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -17, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 17", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 17", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -16, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 16", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 16", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -15, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 15", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 15", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -14, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 14", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 14", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -13, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 13", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 13", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -12, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 12", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 12", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -11, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 11", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 11", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -10, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 10", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 10", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -9, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 9", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 9", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -8, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 8", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 8", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -7, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -6, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -5, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -4, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -3, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -2, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -1, new Guid("d2601590-4a39-48b4-be4b-df5b36edc175"), "This is the content of news 1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "News Title 1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
