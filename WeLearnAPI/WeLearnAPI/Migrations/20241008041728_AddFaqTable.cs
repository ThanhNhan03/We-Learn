using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeLearnAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFaqTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaqQuestion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaqAnswer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FaqCategories = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faqs_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("0a20099b-1efb-4078-96bc-2b0f91d12636"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbf20cb3-5123-4457-a5fc-432c22f211bc", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(4161), "teacher2@example.com", true, "Teacher2", (byte)1, null, "User", false, null, "TEACHER2@EXAMPLE.COM", "TEACHER2", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(4162), "teacher2" },
                    { new Guid("1783e535-b8f1-4819-8986-9f90ee126504"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "44a05360-6881-4cf0-928e-93a7ad304924", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6256), "teacher6@example.com", true, "Teacher6", (byte)1, null, "User", false, null, "TEACHER6@EXAMPLE.COM", "TEACHER6", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6270), "teacher6" },
                    { new Guid("3866db57-8ec1-49b4-846d-9c74af8d00a5"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18336efe-ec5a-415d-a157-0d23198d8f82", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6090), "teacher5@example.com", true, "Teacher5", (byte)1, null, "User", false, null, "TEACHER5@EXAMPLE.COM", "TEACHER5", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6091), "teacher5" },
                    { new Guid("3b5b4d96-b5fb-4286-a210-5a396160a4a9"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "32d9934e-fd39-4094-8f12-e8590fad1028", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(5635), "teacher3@example.com", true, "Teacher3", (byte)1, null, "User", false, null, "TEACHER3@EXAMPLE.COM", "TEACHER3", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(5636), "teacher3" },
                    { new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"), 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e015efd6-69bc-41ad-b461-b09aca02b9e8", new DateTime(2024, 10, 8, 11, 17, 26, 622, DateTimeKind.Local).AddTicks(3021), "admin1@example.com", true, "FirstAdmin", (byte)1, null, "Admin", false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1", "AQAAAAIAAYagAAAAEMX1lLw3YfPEMkzW0xAPitqnpWSad6sNFio4PC3PvA4A3ouh6WLIfU83dJfqoRtNuQ==", null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 622, DateTimeKind.Local).AddTicks(3041), "admin1" },
                    { new Guid("558c71b4-8510-45b8-a873-80f1227451b1"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0ab5a5f9-12fe-489b-bef9-580d00f71bc5", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6804), "teacher8@example.com", true, "Teacher8", (byte)1, null, "User", false, null, "TEACHER8@EXAMPLE.COM", "TEACHER8", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6806), "teacher8" },
                    { new Guid("62237c2b-729b-453f-8518-26a97578a0fa"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3136524e-ee52-419c-90a7-7482073c5afe", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7015), "teacher10@example.com", true, "Teacher10", (byte)1, null, "User", false, null, "TEACHER10@EXAMPLE.COM", "TEACHER10", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7016), "teacher10" },
                    { new Guid("75c84fed-881c-4b05-8a7c-293ee0d5ca1a"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5128e356-757a-45f8-a834-ba08ad48b16b", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(3815), "teacher1@example.com", true, "Teacher1", (byte)1, null, "User", false, null, "TEACHER1@EXAMPLE.COM", "TEACHER1", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(3816), "teacher1" },
                    { new Guid("9df864a0-89fd-4ef2-9db7-8f0eca88b715"), 0, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f47b95b6-6df5-41a9-bd72-e19a88206ae1", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(2768), "admin2@example.com", true, "SecondAdmin", (byte)1, null, "Admin", false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2", "AQAAAAIAAYagAAAAEIZUUSnXQSuX6nwQppRJ1FIwMOymSNr/8oPIfwkyVKsvmANgYbW8NG41Zeml8iEMkA==", null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(2787), "admin2" },
                    { new Guid("d0fbe324-efff-4c70-9a68-2323d2e28404"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d92eab57-2893-4270-b754-97ec1c7d1ace", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6442), "teacher7@example.com", true, "Teacher7", (byte)1, null, "User", false, null, "TEACHER7@EXAMPLE.COM", "TEACHER7", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6443), "teacher7" },
                    { new Guid("e4c5a420-944e-4e60-a278-f48dc059a7b8"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "89bec4c9-ecff-4db5-93df-e5ea629e44e2", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6919), "teacher9@example.com", true, "Teacher9", (byte)1, null, "User", false, null, "TEACHER9@EXAMPLE.COM", "TEACHER9", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(6920), "teacher9" },
                    { new Guid("f4c13c04-9473-4080-99f9-91c535d40268"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "59845610-1065-4336-b78b-81d74b59056d", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(5890), "teacher4@example.com", true, "Teacher4", (byte)1, null, "User", false, null, "TEACHER4@EXAMPLE.COM", "TEACHER4", null, null, false, null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(5891), "teacher4" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("0557590d-3ece-465b-8d28-e8e1139dacf2"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8fba55b5-7fb6-431c-ae82-52a24a17e05e", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8168), "user12@example.com", true, "UserFirstName12", (byte)1, null, "UserLastName12", false, null, "USER12@EXAMPLE.COM", "USER12", null, null, false, "refresh_token_12", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8167), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8169), "user12" },
                    { new Guid("07a1f555-ee10-4f4c-a75f-55df23757012"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4b8c1a9e-de14-4ac8-88c5-351849d292e0", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9062), "user19@example.com", true, "UserFirstName19", (byte)1, null, "UserLastName19", false, null, "USER19@EXAMPLE.COM", "USER19", null, null, false, "refresh_token_19", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9061), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9063), "user19" },
                    { new Guid("098ccd75-ab19-4417-834d-ba26a65eef9b"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "337a9cae-4a61-48b8-9fbb-25a872e2a14f", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9740), "user29@example.com", true, "UserFirstName29", (byte)1, null, "UserLastName29", false, null, "USER29@EXAMPLE.COM", "USER29", null, null, false, "refresh_token_29", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9739), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9740), "user29" },
                    { new Guid("09fc9263-49ce-4735-b492-c1d9e153b1ee"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bce99b55-edbd-4445-b774-3754aba3b317", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7952), "user9@example.com", true, "UserFirstName9", (byte)1, null, "UserLastName9", false, null, "USER9@EXAMPLE.COM", "USER9", null, null, false, "refresh_token_9", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7951), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7953), "user9" },
                    { new Guid("0f541998-4b6d-46d2-98b5-007e58a2a1ed"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "75bfb9dc-99ae-4d88-8bf9-eebfdcb68d93", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8030), "user10@example.com", true, "UserFirstName10", (byte)1, null, "UserLastName10", false, null, "USER10@EXAMPLE.COM", "USER10", null, null, false, "refresh_token_10", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8029), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8031), "user10" },
                    { new Guid("221e090f-69f2-4fc5-8458-62cc3e371cc1"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a74f1c22-979b-4c22-bfc2-0973bced5e1c", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9677), "user28@example.com", true, "UserFirstName28", (byte)1, null, "UserLastName28", false, null, "USER28@EXAMPLE.COM", "USER28", null, null, false, "refresh_token_28", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9676), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9678), "user28" },
                    { new Guid("32858fbe-81e5-4a20-a177-8cd520fae065"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "278bf457-d14b-4690-88bd-96ec2e8a1916", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9548), "user26@example.com", true, "UserFirstName26", (byte)1, null, "UserLastName26", false, null, "USER26@EXAMPLE.COM", "USER26", null, null, false, "refresh_token_26", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9548), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9549), "user26" },
                    { new Guid("3792a79f-a280-4a25-a279-056e4191ab81"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a7464e17-f61c-4ff6-acbd-f0260a9e4c66", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8452), "user16@example.com", true, "UserFirstName16", (byte)1, null, "UserLastName16", false, null, "USER16@EXAMPLE.COM", "USER16", null, null, false, "refresh_token_16", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8451), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8453), "user16" },
                    { new Guid("46bf95f4-4b70-4aec-bb75-18f050c4f557"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6760bfbe-9fa6-482f-8cb3-4908bc95ff3a", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8712), "user18@example.com", true, "UserFirstName18", (byte)1, null, "UserLastName18", false, null, "USER18@EXAMPLE.COM", "USER18", null, null, false, "refresh_token_18", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8711), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8713), "user18" },
                    { new Guid("4a02f9e3-9916-45ed-aba6-fe244e7b7e19"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1b2f6f8d-9575-489d-8e1c-9ed3f47354f0", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8311), "user14@example.com", true, "UserFirstName14", (byte)1, null, "UserLastName14", false, null, "USER14@EXAMPLE.COM", "USER14", null, null, false, "refresh_token_14", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8310), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8311), "user14" },
                    { new Guid("54401a8e-2c6c-42a6-83ea-2a893be654c2"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4be72342-853f-435d-9933-63c78b910f9f", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7320), "user3@example.com", true, "UserFirstName3", (byte)1, null, "UserLastName3", false, null, "USER3@EXAMPLE.COM", "USER3", null, null, false, "refresh_token_3", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7319), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7321), "user3" },
                    { new Guid("6063a043-e497-4c9e-9a87-d9a3a646bee7"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8efa1872-21ca-47e8-8195-e1e747c29fa1", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7144), "user1@example.com", true, "UserFirstName1", (byte)1, null, "UserLastName1", false, null, "USER1@EXAMPLE.COM", "USER1", null, null, false, "refresh_token_1", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7135), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7145), "user1" },
                    { new Guid("71b0c668-654d-4832-a878-f08944e4838d"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d1ca9818-6b69-4d8c-b5eb-c5548cf1da60", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9219), "user21@example.com", true, "UserFirstName21", (byte)1, null, "UserLastName21", false, null, "USER21@EXAMPLE.COM", "USER21", null, null, false, "refresh_token_21", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9218), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9220), "user21" },
                    { new Guid("7acd7894-4bfd-47fe-9cba-75328d5cbc62"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6659acb6-fcff-4228-aca7-30289d022308", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9814), "user30@example.com", true, "UserFirstName30", (byte)1, null, "UserLastName30", false, null, "USER30@EXAMPLE.COM", "USER30", null, null, false, "refresh_token_30", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9802), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9815), "user30" },
                    { new Guid("8a881069-5b0c-48b1-92f5-c95d2a550acd"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "58539623-0e03-4122-925c-00a0cd7f8d8e", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9489), "user25@example.com", true, "UserFirstName25", (byte)1, null, "UserLastName25", false, null, "USER25@EXAMPLE.COM", "USER25", null, null, false, "refresh_token_25", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9488), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9490), "user25" },
                    { new Guid("980156aa-7e34-4f87-b86f-1b76985f31f9"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4b0a3039-4c4e-45cd-b9a0-3a879ccfbccf", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9365), "user23@example.com", true, "UserFirstName23", (byte)1, null, "UserLastName23", false, null, "USER23@EXAMPLE.COM", "USER23", null, null, false, "refresh_token_23", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9364), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9366), "user23" },
                    { new Guid("9bc72c30-441e-46b7-8eac-d8d61d29d80f"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "513a2b64-4ef3-468d-bae5-38fd51431b9f", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7400), "user4@example.com", true, "UserFirstName4", (byte)1, null, "UserLastName4", false, null, "USER4@EXAMPLE.COM", "USER4", null, null, false, "refresh_token_4", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7399), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7400), "user4" },
                    { new Guid("9c4a095a-2509-4fc3-ac52-1b76e38b3320"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dc55a8d3-6a7b-4717-925a-3f73e28d3596", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9147), "user20@example.com", true, "UserFirstName20", (byte)1, null, "UserLastName20", false, null, "USER20@EXAMPLE.COM", "USER20", null, null, false, "refresh_token_20", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9146), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9147), "user20" },
                    { new Guid("a0b374a4-65e8-4f3f-bdc3-1360bfd1efaf"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbf569a2-43e0-4a77-9bb3-7f20931c6244", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8246), "user13@example.com", true, "UserFirstName13", (byte)1, null, "UserLastName13", false, null, "USER13@EXAMPLE.COM", "USER13", null, null, false, "refresh_token_13", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8245), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8247), "user13" },
                    { new Guid("a3ae6d0e-b787-4423-8c53-eb06a741e54f"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "60f5788a-3257-4a3d-9221-dff6163dd98c", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9428), "user24@example.com", true, "UserFirstName24", (byte)1, null, "UserLastName24", false, null, "USER24@EXAMPLE.COM", "USER24", null, null, false, "refresh_token_24", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9428), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9429), "user24" },
                    { new Guid("add4edea-beda-4a5f-a16d-d6eb8fe46025"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "29442d0a-d0fb-4534-815a-48bf6f1b0735", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7619), "user7@example.com", true, "UserFirstName7", (byte)1, null, "UserLastName7", false, null, "USER7@EXAMPLE.COM", "USER7", null, null, false, "refresh_token_7", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7618), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7619), "user7" },
                    { new Guid("b0eeec38-30e6-4c94-bd2f-f1fa4722c534"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3b7e833b-1d12-4a92-b996-2262d1eb07e5", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8381), "user15@example.com", true, "UserFirstName15", (byte)1, null, "UserLastName15", false, null, "USER15@EXAMPLE.COM", "USER15", null, null, false, "refresh_token_15", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8380), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8382), "user15" },
                    { new Guid("bc3c99eb-9244-4e09-936c-65c11059ca1d"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4e723566-94a9-44c7-91d6-b3e672097a37", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7474), "user5@example.com", true, "UserFirstName5", (byte)1, null, "UserLastName5", false, null, "USER5@EXAMPLE.COM", "USER5", null, null, false, "refresh_token_5", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7474), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7475), "user5" },
                    { new Guid("bee317e5-fbee-4303-b14a-cc70272bfd40"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cc50435-96e5-4f6d-9b72-3c0d9d53813b", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9616), "user27@example.com", true, "UserFirstName27", (byte)1, null, "UserLastName27", false, null, "USER27@EXAMPLE.COM", "USER27", null, null, false, "refresh_token_27", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9615), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9618), "user27" },
                    { new Guid("cddd6b2a-b10c-4421-af40-aeba79364fc3"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e4723d98-78f2-4c25-8e33-cb2aa75bfc3c", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8517), "user17@example.com", true, "UserFirstName17", (byte)1, null, "UserLastName17", false, null, "USER17@EXAMPLE.COM", "USER17", null, null, false, "refresh_token_17", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8516), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8518), "user17" },
                    { new Guid("cfb08966-9ace-4896-afcf-48679c023566"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc5e918b-97ee-41ee-96ea-eb83af3e42f5", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7687), "user8@example.com", true, "UserFirstName8", (byte)1, null, "UserLastName8", false, null, "USER8@EXAMPLE.COM", "USER8", null, null, false, "refresh_token_8", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7686), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7687), "user8" },
                    { new Guid("e03a13a3-f06b-408c-a70b-2d7ea6153e08"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d222df0c-776b-48dd-a4f4-af3481eea967", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9297), "user22@example.com", true, "UserFirstName22", (byte)1, null, "UserLastName22", false, null, "USER22@EXAMPLE.COM", "USER22", null, null, false, "refresh_token_22", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9296), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(9297), "user22" },
                    { new Guid("e1a6f1b5-2c6b-44df-86d3-79277d57ebc4"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eb39cc30-d0b7-4a47-9964-9a1914218548", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7552), "user6@example.com", true, "UserFirstName6", (byte)1, null, "UserLastName6", false, null, "USER6@EXAMPLE.COM", "USER6", null, null, false, "refresh_token_6", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7551), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7552), "user6" },
                    { new Guid("e4afeb22-da63-4500-ba14-21d5ae632241"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3753f144-35a0-439c-ad49-16b3ce8090e8", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8099), "user11@example.com", true, "UserFirstName11", (byte)1, null, "UserLastName11", false, null, "USER11@EXAMPLE.COM", "USER11", null, null, false, "refresh_token_11", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8098), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(8099), "user11" },
                    { new Guid("ea89e2f7-224a-44f2-a1bb-e8b6461b5c08"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0fdf77e0-9c4e-45e3-b571-3dbf9051f24c", new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7221), "user2@example.com", true, "UserFirstName2", (byte)1, null, "UserLastName2", false, null, "USER2@EXAMPLE.COM", "USER2", null, null, false, "refresh_token_2", new DateTime(2024, 11, 7, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7220), null, null, false, new DateTime(2024, 10, 8, 11, 17, 26, 727, DateTimeKind.Local).AddTicks(7221), "user2" }
                });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 13,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 14,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 15,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 16,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 17,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 18,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 19,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 20,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 21,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 22,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 23,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 24,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 25,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 26,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 27,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 28,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 29,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 30,
                column: "AdminId",
                value: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("0a20099b-1efb-4078-96bc-2b0f91d12636") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1783e535-b8f1-4819-8986-9f90ee126504") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("3866db57-8ec1-49b4-846d-9c74af8d00a5") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("3b5b4d96-b5fb-4286-a210-5a396160a4a9") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("558c71b4-8510-45b8-a873-80f1227451b1") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("62237c2b-729b-453f-8518-26a97578a0fa") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("75c84fed-881c-4b05-8a7c-293ee0d5ca1a") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("9df864a0-89fd-4ef2-9db7-8f0eca88b715") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("d0fbe324-efff-4c70-9a68-2323d2e28404") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("e4c5a420-944e-4e60-a278-f48dc059a7b8") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("f4c13c04-9473-4080-99f9-91c535d40268") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_AdminId",
                table: "Faqs",
                column: "AdminId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0557590d-3ece-465b-8d28-e8e1139dacf2"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("07a1f555-ee10-4f4c-a75f-55df23757012"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("098ccd75-ab19-4417-834d-ba26a65eef9b"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("09fc9263-49ce-4735-b492-c1d9e153b1ee"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f541998-4b6d-46d2-98b5-007e58a2a1ed"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("221e090f-69f2-4fc5-8458-62cc3e371cc1"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("32858fbe-81e5-4a20-a177-8cd520fae065"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3792a79f-a280-4a25-a279-056e4191ab81"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("46bf95f4-4b70-4aec-bb75-18f050c4f557"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4a02f9e3-9916-45ed-aba6-fe244e7b7e19"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("54401a8e-2c6c-42a6-83ea-2a893be654c2"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6063a043-e497-4c9e-9a87-d9a3a646bee7"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("71b0c668-654d-4832-a878-f08944e4838d"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7acd7894-4bfd-47fe-9cba-75328d5cbc62"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a881069-5b0c-48b1-92f5-c95d2a550acd"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("980156aa-7e34-4f87-b86f-1b76985f31f9"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9bc72c30-441e-46b7-8eac-d8d61d29d80f"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c4a095a-2509-4fc3-ac52-1b76e38b3320"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0b374a4-65e8-4f3f-bdc3-1360bfd1efaf"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3ae6d0e-b787-4423-8c53-eb06a741e54f"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("add4edea-beda-4a5f-a16d-d6eb8fe46025"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0eeec38-30e6-4c94-bd2f-f1fa4722c534"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc3c99eb-9244-4e09-936c-65c11059ca1d"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bee317e5-fbee-4303-b14a-cc70272bfd40"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("cddd6b2a-b10c-4421-af40-aeba79364fc3"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("cfb08966-9ace-4896-afcf-48679c023566"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e03a13a3-f06b-408c-a70b-2d7ea6153e08"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e1a6f1b5-2c6b-44df-86d3-79277d57ebc4"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e4afeb22-da63-4500-ba14-21d5ae632241"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea89e2f7-224a-44f2-a1bb-e8b6461b5c08"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("0a20099b-1efb-4078-96bc-2b0f91d12636") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1783e535-b8f1-4819-8986-9f90ee126504") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("3866db57-8ec1-49b4-846d-9c74af8d00a5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("3b5b4d96-b5fb-4286-a210-5a396160a4a9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("558c71b4-8510-45b8-a873-80f1227451b1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("62237c2b-729b-453f-8518-26a97578a0fa") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("75c84fed-881c-4b05-8a7c-293ee0d5ca1a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("9df864a0-89fd-4ef2-9db7-8f0eca88b715") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("d0fbe324-efff-4c70-9a68-2323d2e28404") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("e4c5a420-944e-4e60-a278-f48dc059a7b8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("f4c13c04-9473-4080-99f9-91c535d40268") });

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("0a20099b-1efb-4078-96bc-2b0f91d12636"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1783e535-b8f1-4819-8986-9f90ee126504"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("3866db57-8ec1-49b4-846d-9c74af8d00a5"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("3b5b4d96-b5fb-4286-a210-5a396160a4a9"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("442d2b8e-1764-4631-bb67-76e05b0ef67d"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("558c71b4-8510-45b8-a873-80f1227451b1"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("62237c2b-729b-453f-8518-26a97578a0fa"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("75c84fed-881c-4b05-8a7c-293ee0d5ca1a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("9df864a0-89fd-4ef2-9db7-8f0eca88b715"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d0fbe324-efff-4c70-9a68-2323d2e28404"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e4c5a420-944e-4e60-a278-f48dc059a7b8"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("f4c13c04-9473-4080-99f9-91c535d40268"));

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

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 13,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 14,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 15,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 16,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 17,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 18,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 19,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 20,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 21,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 22,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 23,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 24,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 25,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 26,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 27,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 28,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 29,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 30,
                column: "AdminId",
                value: new Guid("28259c6d-5f55-4f75-9964-11b5079153c8"));

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
        }
    }
}
