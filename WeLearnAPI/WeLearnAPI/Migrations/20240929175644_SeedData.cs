using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeLearnAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0c16cfb7-fd51-4154-b40a-67ed92072c06"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("11c56f09-677c-4d4e-b2bb-e2457805f572"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1470d501-e3b4-4c04-ae96-8a798729e9bd"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("20a4601e-fc94-4322-8bad-54377a5228f5"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("26b14c5b-f5c8-4c6d-bb1c-6ccb1a0f27b2"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2bb7d785-daed-4692-bad6-b526e3a66431"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd6d446-aa5e-4046-b4b3-ffa502011d48"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2da4595f-5c6d-4bd1-98af-71dfc50bc26e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("306280c0-bc81-4244-95ed-9022e5b167d7"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("44104e10-8924-4024-b324-e8a49bb2fada"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4dfe02b7-7f7f-49ed-ae30-2e7293774d69"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("593f7629-8615-4799-85d7-ba2b7f9155cc"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5c0a90ff-c47b-4997-8806-b4bd9d15631c"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5c659b7f-4cf3-4333-aef5-8a8db9a30ef5"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5def6130-076d-49bc-959b-f19666b91ddb"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("625e6cdc-600a-4d8b-a508-0787c0f09433"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("71b8a5ca-28e1-49b1-a770-250ede179489"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("74b55018-c772-4f45-a4a9-680160aee1e8"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("79388952-9003-4189-8788-69488c9721a1"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7b5f6184-023a-421b-bdd6-9d3d86036bc5"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7fde9d52-6abc-4259-8f7d-d6c276354d5a"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("89f58279-8983-435f-96db-1c4e960c518d"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3cbfb4b-a469-4e6b-a3cb-5c2ea743162b"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b33363d8-11ad-4f83-9186-6d01766fddf7"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c43d7046-1890-4f06-bde9-4ca2a617601b"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35ae035-f551-4cb6-a222-da4840ca4502"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d514cd32-4c2c-4c1b-bc99-7eaa08edc97b"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2b224b0-e1f5-48f2-8969-4ab92e7a6cab"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e40bbe9e-156b-4402-aeb4-3e688a764033"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fe5228ba-f4b9-4e4e-9132-946e1dd85c29"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("389fa39d-7f20-4968-aa99-ee23d0fa1af7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("4202791a-08f3-49a3-a608-5b164f4ec205") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("58ffb7e3-8d60-4bf6-ada2-aa285aec65e4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("5d50fcc9-3d62-4e6c-ba76-491b7b5e35a6") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("71a6216c-0b98-49a2-bb36-b1a5c04bcbe7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("98efeb56-bf99-44f2-bfde-dc03bef4e7c1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("a409714f-a455-4910-83e7-540e7748859a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("aab11a7d-043d-486b-bcd0-f2fa33fc362d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("bc2d6faa-4a9d-4bb2-8213-c1aa5cfaa2c3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c91774bd-1148-42fc-8b79-ca03738a1238") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("ce37fb19-4cd7-4318-8a9f-89675745bd79") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("efbe853d-34c4-4d05-82ac-64b584266517") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("efbe853d-34c4-4d05-82ac-64b584266517") });

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("389fa39d-7f20-4968-aa99-ee23d0fa1af7"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("4202791a-08f3-49a3-a608-5b164f4ec205"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("58ffb7e3-8d60-4bf6-ada2-aa285aec65e4"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("5d50fcc9-3d62-4e6c-ba76-491b7b5e35a6"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("71a6216c-0b98-49a2-bb36-b1a5c04bcbe7"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("98efeb56-bf99-44f2-bfde-dc03bef4e7c1"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a409714f-a455-4910-83e7-540e7748859a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("aab11a7d-043d-486b-bcd0-f2fa33fc362d"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("bc2d6faa-4a9d-4bb2-8213-c1aa5cfaa2c3"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c91774bd-1148-42fc-8b79-ca03738a1238"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ce37fb19-4cd7-4318-8a9f-89675745bd79"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("efbe853d-34c4-4d05-82ac-64b584266517"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("165f561f-927b-44ea-afb7-10b0282b518f"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dbbe9e4b-412e-4159-9539-a9ecf415a66d", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4496), "teacher7@example.com", true, "Teacher7", (byte)1, null, "User", false, null, "TEACHER7@EXAMPLE.COM", "TEACHER7", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4512), "teacher7" },
                    { new Guid("21e6e157-5847-45f7-96c3-727101718958"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3d38996e-beef-413f-81ad-2bbb1bda76da", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4905), "teacher9@example.com", true, "Teacher9", (byte)1, null, "User", false, null, "TEACHER9@EXAMPLE.COM", "TEACHER9", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4906), "teacher9" },
                    { new Guid("33912ce4-146d-4713-ab34-7b015d454cdf"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f7bf98e-5006-4c49-b85d-90fda2fecde7", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4044), "teacher4@example.com", true, "Teacher4", (byte)1, null, "User", false, null, "TEACHER4@EXAMPLE.COM", "TEACHER4", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4045), "teacher4" },
                    { new Guid("6bb560ed-4e70-4278-9927-01a2887adb95"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f9950c4-a2d4-46f8-9181-7ce2ed8f66df", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5035), "teacher10@example.com", true, "Teacher10", (byte)1, null, "User", false, null, "TEACHER10@EXAMPLE.COM", "TEACHER10", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5036), "teacher10" },
                    { new Guid("7853fe73-9cd1-4e9e-906a-8f70159e0ebb"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "feb4b649-1edd-42a6-b3ea-adfb83aa695d", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4379), "teacher6@example.com", true, "Teacher6", (byte)1, null, "User", false, null, "TEACHER6@EXAMPLE.COM", "TEACHER6", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4380), "teacher6" },
                    { new Guid("805a2744-d048-47e8-af7a-e4c9cef6817c"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8ba71723-f8ff-46da-9e89-3075d1f61009", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(3931), "teacher3@example.com", true, "Teacher3", (byte)1, null, "User", false, null, "TEACHER3@EXAMPLE.COM", "TEACHER3", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(3931), "teacher3" },
                    { new Guid("93ed089d-9645-4d8e-af7d-ad520bc5437f"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "82a35ed4-1686-4bd5-bd1e-01c125a31469", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(3271), "teacher1@example.com", true, "Teacher1", (byte)1, null, "User", false, null, "TEACHER1@EXAMPLE.COM", "TEACHER1", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(3273), "teacher1" },
                    { new Guid("a0e60fe6-ec4e-4847-8728-bf9faa1ebbf0"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fedab6d2-934d-4038-8865-ec18441f1f0c", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4777), "teacher8@example.com", true, "Teacher8", (byte)1, null, "User", false, null, "TEACHER8@EXAMPLE.COM", "TEACHER8", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4778), "teacher8" },
                    { new Guid("a5be4496-7f22-4681-b842-a3c60634d448"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6734c18e-8bef-44df-8f2f-f7300860ef5d", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4225), "teacher5@example.com", true, "Teacher5", (byte)1, null, "User", false, null, "TEACHER5@EXAMPLE.COM", "TEACHER5", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(4226), "teacher5" },
                    { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e210dbcb-cda2-4bd7-812c-ea11dfeb3bbe", new DateTime(2024, 9, 30, 0, 56, 43, 361, DateTimeKind.Local).AddTicks(348), "admin1@example.com", true, "FirstAdmin", (byte)1, null, "Admin", false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1", "AQAAAAIAAYagAAAAELGjoHDMUmcGZ84hJTwl3P0Pwx+oVQDUHCxGWnPVMgHGHnRA/BKdDJyQSfqG7nZaxA==", null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 361, DateTimeKind.Local).AddTicks(364), "admin1" },
                    { new Guid("d81b8ed9-be68-4a35-a361-c010670a1d5a"), 0, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "878a1961-a7a3-4d6b-9bc9-55dbc1f466f8", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(2135), "admin2@example.com", true, "SecondAdmin", (byte)1, null, "Admin", false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2", "AQAAAAIAAYagAAAAEBj3XRS6XJvNG/ymPDSKPdBDQWeYyG7b13y1fJ8yADzua/9HGbg8tgPFzdrW5sYGZA==", null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(2158), "admin2" },
                    { new Guid("e30185c9-c3c0-436f-805b-4d90246be632"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f6213f2f-1715-4fc7-86a7-1f2a42356cff", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(3699), "teacher2@example.com", true, "Teacher2", (byte)1, null, "User", false, null, "TEACHER2@EXAMPLE.COM", "TEACHER2", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(3701), "teacher2" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("11a0014d-01b4-41f8-a1ae-533358367328"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "be3ac9e7-d732-45da-ad9f-dfb42bdb9d99", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6333), "user14@example.com", true, "UserFirstName14", (byte)1, null, "UserLastName14", false, null, "USER14@EXAMPLE.COM", "USER14", null, null, false, "refresh_token_14", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6331), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6333), "user14" },
                    { new Guid("127933d9-4fc3-4af1-a638-27494a1f5d7f"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "690828a4-48a5-435b-85a2-19c4a05e912a", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7804), "user26@example.com", true, "UserFirstName26", (byte)1, null, "UserLastName26", false, null, "USER26@EXAMPLE.COM", "USER26", null, null, false, "refresh_token_26", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7803), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7805), "user26" },
                    { new Guid("170a9f79-05f7-4802-988c-cab6a3b0c564"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9017eda8-c3dc-4105-8f39-e0a5ea8878e7", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6148), "user11@example.com", true, "UserFirstName11", (byte)1, null, "UserLastName11", false, null, "USER11@EXAMPLE.COM", "USER11", null, null, false, "refresh_token_11", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6146), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6148), "user11" },
                    { new Guid("18dae43f-238f-4d22-9b89-55c1f59ff407"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "07b840a8-12d4-4b11-bc14-6478004c5cb7", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6397), "user15@example.com", true, "UserFirstName15", (byte)1, null, "UserLastName15", false, null, "USER15@EXAMPLE.COM", "USER15", null, null, false, "refresh_token_15", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6396), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6398), "user15" },
                    { new Guid("2805fb17-bcb1-41d7-881b-015fb0420699"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7968a1e1-208c-4bbb-87a4-2177fa03adf2", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7363), "user22@example.com", true, "UserFirstName22", (byte)1, null, "UserLastName22", false, null, "USER22@EXAMPLE.COM", "USER22", null, null, false, "refresh_token_22", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7361), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7363), "user22" },
                    { new Guid("2ca2216d-2d56-41e1-a61f-724d334dcb14"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "04f26627-13c3-4b00-b182-15a4dc4a68d0", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8011), "user29@example.com", true, "UserFirstName29", (byte)1, null, "UserLastName29", false, null, "USER29@EXAMPLE.COM", "USER29", null, null, false, "refresh_token_29", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8010), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8012), "user29" },
                    { new Guid("3f648733-399a-4e10-a50d-a2b0d9927c5f"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bae6d8e7-e5e4-461a-9761-ad9b4080cd5c", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6000), "user9@example.com", true, "UserFirstName9", (byte)1, null, "UserLastName9", false, null, "USER9@EXAMPLE.COM", "USER9", null, null, false, "refresh_token_9", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5999), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6001), "user9" },
                    { new Guid("3f6e801e-dd53-45bb-b3bd-8ce58c6593e0"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eb25896c-6009-40fe-bda9-cd6afbe59b2e", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5545), "user5@example.com", true, "UserFirstName5", (byte)1, null, "UserLastName5", false, null, "USER5@EXAMPLE.COM", "USER5", null, null, false, "refresh_token_5", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5543), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5545), "user5" },
                    { new Guid("49d620fe-1634-4f0e-b43d-712ae8c54c68"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "436c88a3-9e56-4c32-86e6-eb20fe59068f", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7875), "user27@example.com", true, "UserFirstName27", (byte)1, null, "UserLastName27", false, null, "USER27@EXAMPLE.COM", "USER27", null, null, false, "refresh_token_27", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7874), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7876), "user27" },
                    { new Guid("4bd71b57-d5c9-4a83-a878-9e3916827215"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eb4295a-c47c-47ff-a68c-1b43214e9a94", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7655), "user24@example.com", true, "UserFirstName24", (byte)1, null, "UserLastName24", false, null, "USER24@EXAMPLE.COM", "USER24", null, null, false, "refresh_token_24", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7654), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7656), "user24" },
                    { new Guid("6781f40c-e891-446e-a29a-9e035570217e"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c437e4a4-edcf-4979-b424-43f3386f0d95", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7053), "user19@example.com", true, "UserFirstName19", (byte)1, null, "UserLastName19", false, null, "USER19@EXAMPLE.COM", "USER19", null, null, false, "refresh_token_19", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7051), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7054), "user19" },
                    { new Guid("7a8e8e68-d4c4-4a1f-ac34-6dda2370af99"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bcdfdb8c-f65c-4e1c-a7bc-db40ac98d025", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5316), "user2@example.com", true, "UserFirstName2", (byte)1, null, "UserLastName2", false, null, "USER2@EXAMPLE.COM", "USER2", null, null, false, "refresh_token_2", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5315), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5316), "user2" },
                    { new Guid("8140604d-4428-49c8-ad32-b05a1c10cae3"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1eb49235-cdf3-45c7-bbd6-e8352fa9ff0c", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6271), "user13@example.com", true, "UserFirstName13", (byte)1, null, "UserLastName13", false, null, "USER13@EXAMPLE.COM", "USER13", null, null, false, "refresh_token_13", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6270), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6272), "user13" },
                    { new Guid("851da6ff-a17b-4bda-912e-109b117ae4dd"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dac002f2-dd3d-428c-a879-1e63204b89d3", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5379), "user3@example.com", true, "UserFirstName3", (byte)1, null, "UserLastName3", false, null, "USER3@EXAMPLE.COM", "USER3", null, null, false, "refresh_token_3", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5377), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5379), "user3" },
                    { new Guid("8a79ad02-66bc-454c-98a5-ef1b333b1d24"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bfe98cf9-25a7-49b7-9d59-83f45e7acaf0", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7951), "user28@example.com", true, "UserFirstName28", (byte)1, null, "UserLastName28", false, null, "USER28@EXAMPLE.COM", "USER28", null, null, false, "refresh_token_28", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7949), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7951), "user28" },
                    { new Guid("8e84e041-0d87-42ff-a1d6-3ac817b8efd9"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "97d1c119-d0f3-4c12-aaf8-ba22b10862f5", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5471), "user4@example.com", true, "UserFirstName4", (byte)1, null, "UserLastName4", false, null, "USER4@EXAMPLE.COM", "USER4", null, null, false, "refresh_token_4", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5469), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5471), "user4" },
                    { new Guid("91ad9c77-f7c4-479d-8a7e-e7259bcdbab6"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eb86f050-e59a-47ce-89e6-7739dfeb33ed", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6468), "user16@example.com", true, "UserFirstName16", (byte)1, null, "UserLastName16", false, null, "USER16@EXAMPLE.COM", "USER16", null, null, false, "refresh_token_16", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6467), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6469), "user16" },
                    { new Guid("991655f9-768e-46f2-af99-7130a14e632c"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ba9fa3a9-0261-491c-ad19-c8d8582d7e55", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7722), "user25@example.com", true, "UserFirstName25", (byte)1, null, "UserLastName25", false, null, "USER25@EXAMPLE.COM", "USER25", null, null, false, "refresh_token_25", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7721), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7723), "user25" },
                    { new Guid("9e2c3fb7-a5f9-45ca-83fa-9e89d1255ef7"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f4fc409-cc8e-4cad-97d9-e90722b02dcc", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5685), "user7@example.com", true, "UserFirstName7", (byte)1, null, "UserLastName7", false, null, "USER7@EXAMPLE.COM", "USER7", null, null, false, "refresh_token_7", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5684), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5686), "user7" },
                    { new Guid("a27442ee-2ad7-4598-b444-2281b620b234"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "372f856c-b773-47de-96d5-9bbac19c0134", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7579), "user23@example.com", true, "UserFirstName23", (byte)1, null, "UserLastName23", false, null, "USER23@EXAMPLE.COM", "USER23", null, null, false, "refresh_token_23", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7577), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7580), "user23" },
                    { new Guid("bf7dc463-bcb3-43ee-b569-04ea3d961cba"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e506f231-da12-4d66-aaf9-02091601ed16", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6529), "user17@example.com", true, "UserFirstName17", (byte)1, null, "UserLastName17", false, null, "USER17@EXAMPLE.COM", "USER17", null, null, false, "refresh_token_17", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6528), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6530), "user17" },
                    { new Guid("c2e78182-02a0-48ba-9f67-1cad88b7e329"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "808df78a-102e-4894-a439-df0b7936a2ac", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5618), "user6@example.com", true, "UserFirstName6", (byte)1, null, "UserLastName6", false, null, "USER6@EXAMPLE.COM", "USER6", null, null, false, "refresh_token_6", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5617), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5618), "user6" },
                    { new Guid("cb842099-8e6e-406e-a95d-0906f2442a33"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4d3cd539-fde3-411c-b681-f805fac3d8f4", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7296), "user21@example.com", true, "UserFirstName21", (byte)1, null, "UserLastName21", false, null, "USER21@EXAMPLE.COM", "USER21", null, null, false, "refresh_token_21", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7295), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7297), "user21" },
                    { new Guid("cea6bc37-0fa2-4db4-aa23-b0d4c8e3de59"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dfa69b37-8415-4840-ae0b-d89ceb73e85e", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6083), "user10@example.com", true, "UserFirstName10", (byte)1, null, "UserLastName10", false, null, "USER10@EXAMPLE.COM", "USER10", null, null, false, "refresh_token_10", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6082), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6084), "user10" },
                    { new Guid("d03b2e02-1997-405d-804c-b3b0cc19fe59"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bb92af9e-d0d8-4e04-8b8a-cd3188c79653", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5752), "user8@example.com", true, "UserFirstName8", (byte)1, null, "UserLastName8", false, null, "USER8@EXAMPLE.COM", "USER8", null, null, false, "refresh_token_8", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5750), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5752), "user8" },
                    { new Guid("d8877b08-be6c-4841-8f55-dba9c764a839"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cecce020-e874-4dde-b34c-becfab5ecb90", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5229), "user1@example.com", true, "UserFirstName1", (byte)1, null, "UserLastName1", false, null, "USER1@EXAMPLE.COM", "USER1", null, null, false, "refresh_token_1", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5177), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(5231), "user1" },
                    { new Guid("d91144e9-02dd-4551-9e8c-8a0f37767585"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cd1e6dc-3ecb-46cd-8976-fbfbce7de820", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8082), "user30@example.com", true, "UserFirstName30", (byte)1, null, "UserLastName30", false, null, "USER30@EXAMPLE.COM", "USER30", null, null, false, "refresh_token_30", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8071), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8082), "user30" },
                    { new Guid("f4cfd463-920d-4471-99e3-65ef1421ccb7"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d3a8217b-b4dd-4bf4-998a-c5e88ad4c9b4", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6614), "user18@example.com", true, "UserFirstName18", (byte)1, null, "UserLastName18", false, null, "USER18@EXAMPLE.COM", "USER18", null, null, false, "refresh_token_18", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6613), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6615), "user18" },
                    { new Guid("f5229fb3-a700-486e-be0a-42b44cdb226e"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f63b8b7e-b8e0-4990-8ab8-f32646dc7893", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7219), "user20@example.com", true, "UserFirstName20", (byte)1, null, "UserLastName20", false, null, "USER20@EXAMPLE.COM", "USER20", null, null, false, "refresh_token_20", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7218), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(7220), "user20" },
                    { new Guid("f966c00b-0d7c-42b2-9918-d19ba977c278"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4b0b459c-38d2-4936-b93d-bd429bffd477", new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6213), "user12@example.com", true, "UserFirstName12", (byte)1, null, "UserLastName12", false, null, "USER12@EXAMPLE.COM", "USER12", null, null, false, "refresh_token_12", new DateTime(2024, 10, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6212), null, null, false, new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(6214), "user12" }
                });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"), new DateTime(2024, 9, 30, 0, 56, 43, 490, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("165f561f-927b-44ea-afb7-10b0282b518f") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("21e6e157-5847-45f7-96c3-727101718958") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("33912ce4-146d-4713-ab34-7b015d454cdf") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("6bb560ed-4e70-4278-9927-01a2887adb95") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("7853fe73-9cd1-4e9e-906a-8f70159e0ebb") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("805a2744-d048-47e8-af7a-e4c9cef6817c") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("93ed089d-9645-4d8e-af7d-ad520bc5437f") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("a0e60fe6-ec4e-4847-8728-bf9faa1ebbf0") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("a5be4496-7f22-4681-b842-a3c60634d448") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("d81b8ed9-be68-4a35-a361-c010670a1d5a") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("e30185c9-c3c0-436f-805b-4d90246be632") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("11a0014d-01b4-41f8-a1ae-533358367328"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("127933d9-4fc3-4af1-a638-27494a1f5d7f"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("170a9f79-05f7-4802-988c-cab6a3b0c564"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("18dae43f-238f-4d22-9b89-55c1f59ff407"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2805fb17-bcb1-41d7-881b-015fb0420699"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2ca2216d-2d56-41e1-a61f-724d334dcb14"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3f648733-399a-4e10-a50d-a2b0d9927c5f"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3f6e801e-dd53-45bb-b3bd-8ce58c6593e0"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("49d620fe-1634-4f0e-b43d-712ae8c54c68"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4bd71b57-d5c9-4a83-a878-9e3916827215"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6781f40c-e891-446e-a29a-9e035570217e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a8e8e68-d4c4-4a1f-ac34-6dda2370af99"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8140604d-4428-49c8-ad32-b05a1c10cae3"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("851da6ff-a17b-4bda-912e-109b117ae4dd"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a79ad02-66bc-454c-98a5-ef1b333b1d24"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e84e041-0d87-42ff-a1d6-3ac817b8efd9"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("91ad9c77-f7c4-479d-8a7e-e7259bcdbab6"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("991655f9-768e-46f2-af99-7130a14e632c"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e2c3fb7-a5f9-45ca-83fa-9e89d1255ef7"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a27442ee-2ad7-4598-b444-2281b620b234"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf7dc463-bcb3-43ee-b569-04ea3d961cba"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2e78182-02a0-48ba-9f67-1cad88b7e329"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb842099-8e6e-406e-a95d-0906f2442a33"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("cea6bc37-0fa2-4db4-aa23-b0d4c8e3de59"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d03b2e02-1997-405d-804c-b3b0cc19fe59"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8877b08-be6c-4841-8f55-dba9c764a839"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d91144e9-02dd-4551-9e8c-8a0f37767585"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4cfd463-920d-4471-99e3-65ef1421ccb7"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f5229fb3-a700-486e-be0a-42b44cdb226e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f966c00b-0d7c-42b2-9918-d19ba977c278"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("165f561f-927b-44ea-afb7-10b0282b518f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("21e6e157-5847-45f7-96c3-727101718958") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("33912ce4-146d-4713-ab34-7b015d454cdf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("6bb560ed-4e70-4278-9927-01a2887adb95") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("7853fe73-9cd1-4e9e-906a-8f70159e0ebb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("805a2744-d048-47e8-af7a-e4c9cef6817c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("93ed089d-9645-4d8e-af7d-ad520bc5437f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("a0e60fe6-ec4e-4847-8728-bf9faa1ebbf0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("a5be4496-7f22-4681-b842-a3c60634d448") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("d81b8ed9-be68-4a35-a361-c010670a1d5a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("e30185c9-c3c0-436f-805b-4d90246be632") });

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("165f561f-927b-44ea-afb7-10b0282b518f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("21e6e157-5847-45f7-96c3-727101718958"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("33912ce4-146d-4713-ab34-7b015d454cdf"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("6bb560ed-4e70-4278-9927-01a2887adb95"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7853fe73-9cd1-4e9e-906a-8f70159e0ebb"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("805a2744-d048-47e8-af7a-e4c9cef6817c"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("93ed089d-9645-4d8e-af7d-ad520bc5437f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a0e60fe6-ec4e-4847-8728-bf9faa1ebbf0"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a5be4496-7f22-4681-b842-a3c60634d448"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("cbbaa534-5ddf-46b3-908e-260ed43740ea"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d81b8ed9-be68-4a35-a361-c010670a1d5a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e30185c9-c3c0-436f-805b-4d90246be632"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("389fa39d-7f20-4968-aa99-ee23d0fa1af7"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "637cc156-b4a6-4450-a67d-fb71a3e15eb8", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8060), "teacher3@example.com", true, "Teacher3", (byte)1, null, "User", false, null, "TEACHER3@EXAMPLE.COM", "TEACHER3", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8060), "teacher3" },
                    { new Guid("4202791a-08f3-49a3-a608-5b164f4ec205"), 0, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3ed4390f-f2a6-4548-b78e-1d98fa7dc938", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(7781), "admin2@example.com", true, "SecondAdmin", (byte)1, null, "Admin", false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(7783), "admin2" },
                    { new Guid("58ffb7e3-8d60-4bf6-ada2-aa285aec65e4"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1882a412-b180-4b71-bcfb-048afac9983b", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8304), "teacher6@example.com", true, "Teacher6", (byte)1, null, "User", false, null, "TEACHER6@EXAMPLE.COM", "TEACHER6", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8305), "teacher6" },
                    { new Guid("5d50fcc9-3d62-4e6c-ba76-491b7b5e35a6"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e2257f15-fd39-4a1f-8d68-f13f26ebf27c", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8569), "teacher10@example.com", true, "Teacher10", (byte)1, null, "User", false, null, "TEACHER10@EXAMPLE.COM", "TEACHER10", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8569), "teacher10" },
                    { new Guid("71a6216c-0b98-49a2-bb36-b1a5c04bcbe7"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9854563f-22f8-4102-97f0-0f93bf794fb9", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(7922), "teacher1@example.com", true, "Teacher1", (byte)1, null, "User", false, null, "TEACHER1@EXAMPLE.COM", "TEACHER1", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(7923), "teacher1" },
                    { new Guid("98efeb56-bf99-44f2-bfde-dc03bef4e7c1"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "68168533-a4f1-40da-9d20-7ec4cfc0c346", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8181), "teacher4@example.com", true, "Teacher4", (byte)1, null, "User", false, null, "TEACHER4@EXAMPLE.COM", "TEACHER4", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8181), "teacher4" },
                    { new Guid("a409714f-a455-4910-83e7-540e7748859a"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "95543483-b77d-4134-a668-13a46ff6c4c2", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8244), "teacher5@example.com", true, "Teacher5", (byte)1, null, "User", false, null, "TEACHER5@EXAMPLE.COM", "TEACHER5", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8244), "teacher5" },
                    { new Guid("aab11a7d-043d-486b-bcd0-f2fa33fc362d"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "77494883-93d0-4a2e-a56e-2ed1d4568937", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8502), "teacher9@example.com", true, "Teacher9", (byte)1, null, "User", false, null, "TEACHER9@EXAMPLE.COM", "TEACHER9", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8502), "teacher9" },
                    { new Guid("bc2d6faa-4a9d-4bb2-8213-c1aa5cfaa2c3"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "50672d07-5b62-4176-9a31-6c51e750cb2a", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(7991), "teacher2@example.com", true, "Teacher2", (byte)1, null, "User", false, null, "TEACHER2@EXAMPLE.COM", "TEACHER2", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(7992), "teacher2" },
                    { new Guid("c91774bd-1148-42fc-8b79-ca03738a1238"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6de83e8a-26a8-4539-998d-557754b5df5b", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8375), "teacher7@example.com", true, "Teacher7", (byte)1, null, "User", false, null, "TEACHER7@EXAMPLE.COM", "TEACHER7", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8376), "teacher7" },
                    { new Guid("ce37fb19-4cd7-4318-8a9f-89675745bd79"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "53fb2c0f-46a3-4a83-9d88-db2316bcc73d", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8442), "teacher8@example.com", true, "Teacher8", (byte)1, null, "User", false, null, "TEACHER8@EXAMPLE.COM", "TEACHER8", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8443), "teacher8" },
                    { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f0d12066-506a-4f5f-a421-ba33d950b811", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(7743), "admin1@example.com", true, "FirstAdmin", (byte)1, null, "Admin", false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1", null, null, false, null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(7744), "admin1" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("0c16cfb7-fd51-4154-b40a-67ed92072c06"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9eebf156-e762-4b64-bd34-790bfea24901", new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(136), "user28@example.com", true, "UserFirstName28", (byte)1, null, "UserLastName28", false, null, "USER28@EXAMPLE.COM", "USER28", null, null, false, "refresh_token_28", new DateTime(2024, 10, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(135), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(137), "user28" },
                    { new Guid("11c56f09-677c-4d4e-b2bb-e2457805f572"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "45011c48-79b3-436d-b364-2184e1c2a8ed", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9017), "user8@example.com", true, "UserFirstName8", (byte)1, null, "UserLastName8", false, null, "USER8@EXAMPLE.COM", "USER8", null, null, false, "refresh_token_8", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9016), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9018), "user8" },
                    { new Guid("1470d501-e3b4-4c04-ae96-8a798729e9bd"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "facb7d39-6839-4c36-87d8-f32fb25f8eff", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8780), "user3@example.com", true, "UserFirstName3", (byte)1, null, "UserLastName3", false, null, "USER3@EXAMPLE.COM", "USER3", null, null, false, "refresh_token_3", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8779), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8781), "user3" },
                    { new Guid("20a4601e-fc94-4322-8bad-54377a5228f5"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "63caf3c5-6f89-4ac1-88bf-0eba3fbeadb4", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8731), "user2@example.com", true, "UserFirstName2", (byte)1, null, "UserLastName2", false, null, "USER2@EXAMPLE.COM", "USER2", null, null, false, "refresh_token_2", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8730), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8732), "user2" },
                    { new Guid("26b14c5b-f5c8-4c6d-bb1c-6ccb1a0f27b2"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7b148c44-28b0-44b2-a548-660fa65e7ea3", new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(225), "user30@example.com", true, "UserFirstName30", (byte)1, null, "UserLastName30", false, null, "USER30@EXAMPLE.COM", "USER30", null, null, false, "refresh_token_30", new DateTime(2024, 10, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(224), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(225), "user30" },
                    { new Guid("2bb7d785-daed-4692-bad6-b526e3a66431"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3a526c1b-0605-4be1-862e-79601c21822f", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9241), "user13@example.com", true, "UserFirstName13", (byte)1, null, "UserLastName13", false, null, "USER13@EXAMPLE.COM", "USER13", null, null, false, "refresh_token_13", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9240), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9242), "user13" },
                    { new Guid("2cd6d446-aa5e-4046-b4b3-ffa502011d48"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8ce978d-12df-4213-9970-254c82235bf4", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9910), "user23@example.com", true, "UserFirstName23", (byte)1, null, "UserLastName23", false, null, "USER23@EXAMPLE.COM", "USER23", null, null, false, "refresh_token_23", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9909), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9910), "user23" },
                    { new Guid("2da4595f-5c6d-4bd1-98af-71dfc50bc26e"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3654c01c-6263-421c-a1cf-dd7b18a9425f", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9340), "user15@example.com", true, "UserFirstName15", (byte)1, null, "UserLastName15", false, null, "USER15@EXAMPLE.COM", "USER15", null, null, false, "refresh_token_15", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9340), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9341), "user15" },
                    { new Guid("306280c0-bc81-4244-95ed-9022e5b167d7"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4302c60c-2f49-4146-8686-1f7bd5ca2bec", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9954), "user24@example.com", true, "UserFirstName24", (byte)1, null, "UserLastName24", false, null, "USER24@EXAMPLE.COM", "USER24", null, null, false, "refresh_token_24", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9953), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9954), "user24" },
                    { new Guid("44104e10-8924-4024-b324-e8a49bb2fada"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "26dc5c8b-219d-4107-ad9c-f60eded9aa67", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8879), "user5@example.com", true, "UserFirstName5", (byte)1, null, "UserLastName5", false, null, "USER5@EXAMPLE.COM", "USER5", null, null, false, "refresh_token_5", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8878), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8879), "user5" },
                    { new Guid("4dfe02b7-7f7f-49ed-ae30-2e7293774d69"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "14ebfafc-bd07-499e-9773-909990bb08d5", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9804), "user21@example.com", true, "UserFirstName21", (byte)1, null, "UserLastName21", false, null, "USER21@EXAMPLE.COM", "USER21", null, null, false, "refresh_token_21", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9803), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9805), "user21" },
                    { new Guid("593f7629-8615-4799-85d7-ba2b7f9155cc"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "27dd34c6-a36f-4d02-a803-f7b580a597d2", new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local), "user25@example.com", true, "UserFirstName25", (byte)1, null, "UserLastName25", false, null, "USER25@EXAMPLE.COM", "USER25", null, null, false, "refresh_token_25", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9999), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(1), "user25" },
                    { new Guid("5c0a90ff-c47b-4997-8806-b4bd9d15631c"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0bb488cf-247b-4ebb-9421-ac59e7141094", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9712), "user19@example.com", true, "UserFirstName19", (byte)1, null, "UserLastName19", false, null, "USER19@EXAMPLE.COM", "USER19", null, null, false, "refresh_token_19", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9711), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9713), "user19" },
                    { new Guid("5c659b7f-4cf3-4333-aef5-8a8db9a30ef5"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "47144efa-b424-4def-89da-e96a07b06ae1", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9385), "user16@example.com", true, "UserFirstName16", (byte)1, null, "UserLastName16", false, null, "USER16@EXAMPLE.COM", "USER16", null, null, false, "refresh_token_16", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9384), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9385), "user16" },
                    { new Guid("5def6130-076d-49bc-959b-f19666b91ddb"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ae774a03-ec15-4cf9-8ba4-577966ae14fd", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9428), "user17@example.com", true, "UserFirstName17", (byte)1, null, "UserLastName17", false, null, "USER17@EXAMPLE.COM", "USER17", null, null, false, "refresh_token_17", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9427), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9429), "user17" },
                    { new Guid("625e6cdc-600a-4d8b-a508-0787c0f09433"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bae4dbf4-b8ec-4837-9514-91f4f5b67791", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9295), "user14@example.com", true, "UserFirstName14", (byte)1, null, "UserLastName14", false, null, "USER14@EXAMPLE.COM", "USER14", null, null, false, "refresh_token_14", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9294), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9296), "user14" },
                    { new Guid("71b8a5ca-28e1-49b1-a770-250ede179489"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4eb32dfc-221d-451c-9051-cf2ce56a0fb9", new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(92), "user27@example.com", true, "UserFirstName27", (byte)1, null, "UserLastName27", false, null, "USER27@EXAMPLE.COM", "USER27", null, null, false, "refresh_token_27", new DateTime(2024, 10, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(91), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(92), "user27" },
                    { new Guid("74b55018-c772-4f45-a4a9-680160aee1e8"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0d0836d3-5f5f-4136-9fa4-5cad9895ff28", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9061), "user9@example.com", true, "UserFirstName9", (byte)1, null, "UserLastName9", false, null, "USER9@EXAMPLE.COM", "USER9", null, null, false, "refresh_token_9", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9060), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9061), "user9" },
                    { new Guid("79388952-9003-4189-8788-69488c9721a1"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b349d512-c48d-4373-8370-e2fc37ce13b1", new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(178), "user29@example.com", true, "UserFirstName29", (byte)1, null, "UserLastName29", false, null, "USER29@EXAMPLE.COM", "USER29", null, null, false, "refresh_token_29", new DateTime(2024, 10, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(177), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(179), "user29" },
                    { new Guid("7b5f6184-023a-421b-bdd6-9d3d86036bc5"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f9778bc0-b7f1-4eb9-95cd-3d19af0c4205", new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(49), "user26@example.com", true, "UserFirstName26", (byte)1, null, "UserLastName26", false, null, "USER26@EXAMPLE.COM", "USER26", null, null, false, "refresh_token_26", new DateTime(2024, 10, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(48), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(49), "user26" },
                    { new Guid("7fde9d52-6abc-4259-8f7d-d6c276354d5a"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c45769d6-aa2f-4ded-b3a1-12ae152c2473", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9198), "user12@example.com", true, "UserFirstName12", (byte)1, null, "UserLastName12", false, null, "USER12@EXAMPLE.COM", "USER12", null, null, false, "refresh_token_12", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9197), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9199), "user12" },
                    { new Guid("89f58279-8983-435f-96db-1c4e960c518d"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3ac6bea6-e558-4b71-99cb-b5d2fc013a33", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8826), "user4@example.com", true, "UserFirstName4", (byte)1, null, "UserLastName4", false, null, "USER4@EXAMPLE.COM", "USER4", null, null, false, "refresh_token_4", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8825), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8826), "user4" },
                    { new Guid("a3cbfb4b-a469-4e6b-a3cb-5c2ea743162b"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "901af67f-48f1-4f50-a434-a73408104af2", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8674), "user1@example.com", true, "UserFirstName1", (byte)1, null, "UserLastName1", false, null, "USER1@EXAMPLE.COM", "USER1", null, null, false, "refresh_token_1", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8662), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8675), "user1" },
                    { new Guid("b33363d8-11ad-4f83-9186-6d01766fddf7"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "98dccd64-78f8-4b56-8cad-272ba4548501", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8973), "user7@example.com", true, "UserFirstName7", (byte)1, null, "UserLastName7", false, null, "USER7@EXAMPLE.COM", "USER7", null, null, false, "refresh_token_7", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8972), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8974), "user7" },
                    { new Guid("c43d7046-1890-4f06-bde9-4ca2a617601b"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "006b583f-7f68-4c10-9161-843cc47c20d5", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9866), "user22@example.com", true, "UserFirstName22", (byte)1, null, "UserLastName22", false, null, "USER22@EXAMPLE.COM", "USER22", null, null, false, "refresh_token_22", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9865), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9866), "user22" },
                    { new Guid("d35ae035-f551-4cb6-a222-da4840ca4502"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "be6583e5-132c-4e12-8bfd-8602da21cec0", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9110), "user10@example.com", true, "UserFirstName10", (byte)1, null, "UserLastName10", false, null, "USER10@EXAMPLE.COM", "USER10", null, null, false, "refresh_token_10", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9109), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9111), "user10" },
                    { new Guid("d514cd32-4c2c-4c1b-bc99-7eaa08edc97b"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a4187f02-5fea-47c1-a486-cc3b42b4073f", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9478), "user18@example.com", true, "UserFirstName18", (byte)1, null, "UserLastName18", false, null, "USER18@EXAMPLE.COM", "USER18", null, null, false, "refresh_token_18", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9477), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9478), "user18" },
                    { new Guid("e2b224b0-e1f5-48f2-8969-4ab92e7a6cab"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e7e36d54-0260-4f84-ba65-5fc02e7a6336", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9154), "user11@example.com", true, "UserFirstName11", (byte)1, null, "UserLastName11", false, null, "USER11@EXAMPLE.COM", "USER11", null, null, false, "refresh_token_11", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9153), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9155), "user11" },
                    { new Guid("e40bbe9e-156b-4402-aeb4-3e688a764033"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "77fb59c2-4a0f-4d07-9f67-8833d5e58e54", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8929), "user6@example.com", true, "UserFirstName6", (byte)1, null, "UserLastName6", false, null, "USER6@EXAMPLE.COM", "USER6", null, null, false, "refresh_token_6", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8928), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(8930), "user6" },
                    { new Guid("fe5228ba-f4b9-4e4e-9132-946e1dd85c29"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "818f463d-d51c-44ae-9055-8547c2f43e7f", new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9758), "user20@example.com", true, "UserFirstName20", (byte)1, null, "UserLastName20", false, null, "USER20@EXAMPLE.COM", "USER20", null, null, false, "refresh_token_20", new DateTime(2024, 10, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9756), null, null, false, new DateTime(2024, 9, 30, 0, 49, 6, 15, DateTimeKind.Local).AddTicks(9758), "user20" }
                });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AdminId", "CreatedAt" },
                values: new object[] { new Guid("efbe853d-34c4-4d05-82ac-64b584266517"), new DateTime(2024, 9, 30, 0, 49, 6, 16, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("389fa39d-7f20-4968-aa99-ee23d0fa1af7") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("4202791a-08f3-49a3-a608-5b164f4ec205") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("58ffb7e3-8d60-4bf6-ada2-aa285aec65e4") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("5d50fcc9-3d62-4e6c-ba76-491b7b5e35a6") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("71a6216c-0b98-49a2-bb36-b1a5c04bcbe7") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("98efeb56-bf99-44f2-bfde-dc03bef4e7c1") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("a409714f-a455-4910-83e7-540e7748859a") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("aab11a7d-043d-486b-bcd0-f2fa33fc362d") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("bc2d6faa-4a9d-4bb2-8213-c1aa5cfaa2c3") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c91774bd-1148-42fc-8b79-ca03738a1238") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("ce37fb19-4cd7-4318-8a9f-89675745bd79") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("efbe853d-34c4-4d05-82ac-64b584266517") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("efbe853d-34c4-4d05-82ac-64b584266517") }
                });
        }
    }
}
