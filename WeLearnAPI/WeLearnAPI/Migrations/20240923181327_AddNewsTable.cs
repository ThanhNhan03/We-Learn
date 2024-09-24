using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeLearnAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNewsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("013121bd-f11a-4f5b-84e3-11c5fdca3196") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("05d2230a-9679-422e-8eb5-457004957602") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("085ddcca-d8d2-484b-a2ba-a1c473c58eed") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("09e4ec4d-7a7b-4243-bb4f-becce258a04a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("0e11cc21-9d2e-468e-98ad-15f71abcc1ed") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1629c4af-3689-43c2-bda2-5828c3bbc6ec") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1813d049-65f4-49eb-ada8-4052a3ce3237") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("19ebdca8-5718-4b33-ab3a-30b5d595424b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("2ef8934b-3efd-4341-971b-2cb691fca3cf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("38f8bed2-5d69-4ab5-9757-5c2adc1aad54") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("3e010aeb-6106-4935-b3c7-05a76eff0f2d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("45c3635e-d7ef-436b-8cf0-19d1e255e28e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("482f4242-f6d2-4f9d-b4c8-9c5bdbb83f67") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("6109a8dd-7722-4966-a93c-7118ff03f2d7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("65752996-b4bf-43e0-b3b3-eab9c99547dc") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("683fa88e-4846-4fab-8782-87a832b9366d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("7aa801ba-9100-418a-9b62-b83ca2e727cf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("7f29d230-c98c-4625-8a6a-983f8cef1996") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("81c49abe-a5dc-4cf2-8082-a695fac2daeb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("8a650a83-d6be-4dee-a1c6-4dfb3d2e9418") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("9015c1d4-f00c-47f2-b1d8-d2e595c139ce") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("96f5e944-9c27-4a58-b72f-6016d7774652") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("9dc05b4c-9cd9-4fe4-be9b-5166f92cf040") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("a6350713-f2de-4b21-893c-0b3fc47f7e20") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("b96f0c3a-b972-4712-a13b-02e8c180d00e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("be322a52-07a3-4e9f-9bc2-8f0b798fe830") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c00c9d45-3d9d-4cb5-a266-355989853c7a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c04bf58c-9dfe-47d6-b777-84c461434410") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c1d3a4c5-171a-484b-b064-687bd8b4ec44") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("ce60c704-d916-4d70-8337-b2510e85c2ff") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("db300226-5196-4167-a988-1e39cb8e63a7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("f41cae83-7f2e-4e25-8e79-ab226d10482d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("fe219fd4-4f7c-4d7f-b27b-d6999f11073d") });

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("013121bd-f11a-4f5b-84e3-11c5fdca3196"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("05d2230a-9679-422e-8eb5-457004957602"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("085ddcca-d8d2-484b-a2ba-a1c473c58eed"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("09e4ec4d-7a7b-4243-bb4f-becce258a04a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("0e11cc21-9d2e-468e-98ad-15f71abcc1ed"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1629c4af-3689-43c2-bda2-5828c3bbc6ec"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1813d049-65f4-49eb-ada8-4052a3ce3237"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("19ebdca8-5718-4b33-ab3a-30b5d595424b"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2ef8934b-3efd-4341-971b-2cb691fca3cf"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("38f8bed2-5d69-4ab5-9757-5c2adc1aad54"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("3e010aeb-6106-4935-b3c7-05a76eff0f2d"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("45c3635e-d7ef-436b-8cf0-19d1e255e28e"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("482f4242-f6d2-4f9d-b4c8-9c5bdbb83f67"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("6109a8dd-7722-4966-a93c-7118ff03f2d7"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("65752996-b4bf-43e0-b3b3-eab9c99547dc"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("683fa88e-4846-4fab-8782-87a832b9366d"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7aa801ba-9100-418a-9b62-b83ca2e727cf"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7f29d230-c98c-4625-8a6a-983f8cef1996"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("81c49abe-a5dc-4cf2-8082-a695fac2daeb"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("8a650a83-d6be-4dee-a1c6-4dfb3d2e9418"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("9015c1d4-f00c-47f2-b1d8-d2e595c139ce"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("96f5e944-9c27-4a58-b72f-6016d7774652"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("9dc05b4c-9cd9-4fe4-be9b-5166f92cf040"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a6350713-f2de-4b21-893c-0b3fc47f7e20"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b96f0c3a-b972-4712-a13b-02e8c180d00e"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("be322a52-07a3-4e9f-9bc2-8f0b798fe830"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c00c9d45-3d9d-4cb5-a266-355989853c7a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c04bf58c-9dfe-47d6-b777-84c461434410"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c1d3a4c5-171a-484b-b064-687bd8b4ec44"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ce60c704-d916-4d70-8337-b2510e85c2ff"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("db300226-5196-4167-a988-1e39cb8e63a7"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("f41cae83-7f2e-4e25-8e79-ab226d10482d"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("fe219fd4-4f7c-4d7f-b27b-d6999f11073d"));

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_AdminId",
                table: "News",
                column: "AdminId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "EmailConfirmed", "FirstName", "Gender", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberToken", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("013121bd-f11a-4f5b-84e3-11c5fdca3196"), 0, null, "86406693-469d-4e3c-867c-2c72745171c5", new DateTime(2024, 9, 23, 22, 51, 52, 354, DateTimeKind.Local).AddTicks(3538), new Guid("6f628c81-787d-4696-8666-f4060ef537cc"), null, "teacher6@example.com", true, "TeacherFirstName6", null, null, "TeacherLastName6", false, null, null, "TEACHER6@EXAMPLE.COM", "TEACHER6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOwX0i/XJOII+8tJ9GoekORIyhIvonV22isQImaHB2cwklMCCD7Fp4DvHR7PIAW5Mw==", null, false, null, "88590d3c-298d-4339-8803-b62155d1d5e6", false, new DateTime(2024, 9, 23, 22, 51, 52, 354, DateTimeKind.Local).AddTicks(3551), "teacher6@example.com" },
                    { new Guid("05d2230a-9679-422e-8eb5-457004957602"), 0, null, "8dcee566-9364-4423-a394-438cd22cac34", new DateTime(2024, 9, 23, 22, 51, 51, 729, DateTimeKind.Local).AddTicks(2359), new Guid("b1fed083-ed03-4927-baae-2f18755cc413"), null, "teacher1@example.com", true, "TeacherFirstName1", null, null, "TeacherLastName1", false, null, null, "TEACHER1@EXAMPLE.COM", "TEACHER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEekujZPgBsKle0U88bV3BKO8GO9Vy/QooaNkCPQPML75YPLBZfOShsBZEto81vo8A==", null, false, null, "256178b7-2b25-459f-a593-8340ce82d8e9", false, new DateTime(2024, 9, 23, 22, 51, 51, 729, DateTimeKind.Local).AddTicks(2364), "teacher1@example.com" },
                    { new Guid("085ddcca-d8d2-484b-a2ba-a1c473c58eed"), 0, null, "6661fc1b-9927-4b03-b4c6-d84285200781", new DateTime(2024, 9, 23, 22, 51, 54, 192, DateTimeKind.Local).AddTicks(1709), new Guid("4bfe6190-1164-4e1f-80a4-cdfd0d00247f"), null, "teacher21@example.com", true, "TeacherFirstName21", null, null, "TeacherLastName21", false, null, null, "TEACHER21@EXAMPLE.COM", "TEACHER21@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGmsp/iqlYvTcsaGiJPt3+DPrx1/AKxh4AdPwhiAdBvpC95Steik8jlpnum2+pHhOg==", null, false, null, "5b677192-dbb1-4e31-b975-a8a30aa85e59", false, new DateTime(2024, 9, 23, 22, 51, 54, 192, DateTimeKind.Local).AddTicks(1726), "teacher21@example.com" },
                    { new Guid("09e4ec4d-7a7b-4243-bb4f-becce258a04a"), 0, null, "e990e889-5c3a-48a1-9976-408ead551236", new DateTime(2024, 9, 23, 22, 51, 53, 671, DateTimeKind.Local).AddTicks(8298), new Guid("cb972ba5-0ae7-484c-8217-7da0011adc95"), null, "teacher16@example.com", true, "TeacherFirstName16", null, null, "TeacherLastName16", false, null, null, "TEACHER16@EXAMPLE.COM", "TEACHER16@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDb1XDxEdBLBtwxi9YInS40kHw0suJ8zcoEClRHQzW7IrOvxgtjYzkLLkOBvk6kgmA==", null, false, null, "b7daf07c-b2ea-4b50-9955-625e219ad582", false, new DateTime(2024, 9, 23, 22, 51, 53, 671, DateTimeKind.Local).AddTicks(8310), "teacher16@example.com" },
                    { new Guid("0e11cc21-9d2e-468e-98ad-15f71abcc1ed"), 0, null, "c20ec210-b4c8-4184-be3f-2d52eb318b95", new DateTime(2024, 9, 23, 22, 51, 55, 71, DateTimeKind.Local).AddTicks(3584), new Guid("cc49f8c1-0daf-4909-8d2e-bb1b500ae1b5"), null, "teacher30@example.com", true, "TeacherFirstName30", null, null, "TeacherLastName30", false, null, null, "TEACHER30@EXAMPLE.COM", "TEACHER30@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFBbXeGPJJbuO1A+VVk/uoPFutAFcKMpr5hUPb6z2AK5OHhdFJPwKqh0fUDQOuqJfQ==", null, false, null, "9238dc0a-bc21-4a2a-8275-b65b2eb3a261", false, new DateTime(2024, 9, 23, 22, 51, 55, 71, DateTimeKind.Local).AddTicks(3595), "teacher30@example.com" },
                    { new Guid("1629c4af-3689-43c2-bda2-5828c3bbc6ec"), 0, null, "1c3a4584-d36b-40a2-a413-f48294e79cf9", new DateTime(2024, 9, 23, 22, 51, 54, 770, DateTimeKind.Local).AddTicks(1872), new Guid("12224610-f395-4fb1-9d98-023cf2d9bad8"), null, "teacher27@example.com", true, "TeacherFirstName27", null, null, "TeacherLastName27", false, null, null, "TEACHER27@EXAMPLE.COM", "TEACHER27@EXAMPLE.COM", "AQAAAAIAAYagAAAAECvSaOacoKvJp5DCm7C5dQH8E6U5stOxU08kE8CoOg6Pgj4N58M2oyhEDaF1F117yg==", null, false, null, "a546d46a-1fc8-4740-9348-97d99cc34a7b", false, new DateTime(2024, 9, 23, 22, 51, 54, 770, DateTimeKind.Local).AddTicks(1883), "teacher27@example.com" },
                    { new Guid("1813d049-65f4-49eb-ada8-4052a3ce3237"), 0, null, "2292df78-eb76-410f-9d40-44b12c2341d3", new DateTime(2024, 9, 23, 22, 51, 54, 377, DateTimeKind.Local).AddTicks(606), new Guid("30d8e72b-34e6-468d-8d66-710eda4bcad7"), null, "teacher23@example.com", true, "TeacherFirstName23", null, null, "TeacherLastName23", false, null, null, "TEACHER23@EXAMPLE.COM", "TEACHER23@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJpOYJvM3j0CelZKQgCwioqFaoteUul6DACgcY/IRkdss9hEfSdyeqIBdzS9mFdpvQ==", null, false, null, "aa68f3a9-0c0c-45c8-b5c6-26e0640e5a4b", false, new DateTime(2024, 9, 23, 22, 51, 54, 377, DateTimeKind.Local).AddTicks(672), "teacher23@example.com" },
                    { new Guid("19ebdca8-5718-4b33-ab3a-30b5d595424b"), 0, null, "0aff5f80-617e-4773-a1c4-10cde8805ac1", new DateTime(2024, 9, 23, 22, 51, 53, 350, DateTimeKind.Local).AddTicks(5388), new Guid("7e20ae5f-6db5-4939-a6c3-55cc402e8dcd"), null, "teacher13@example.com", true, "TeacherFirstName13", null, null, "TeacherLastName13", false, null, null, "TEACHER13@EXAMPLE.COM", "TEACHER13@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM2afXuc4tv/eFU1HRa5fNP3lnvidjzItby7YGBbpREp8DjyR7/k4oMs0o9Vv1cHKA==", null, false, null, "9dc87b83-cd1c-4d1c-bb98-802b0cb52b56", false, new DateTime(2024, 9, 23, 22, 51, 53, 350, DateTimeKind.Local).AddTicks(5398), "teacher13@example.com" },
                    { new Guid("2ef8934b-3efd-4341-971b-2cb691fca3cf"), 0, null, "0de314fb-0618-49bb-b415-54e76dc80c04", new DateTime(2024, 9, 23, 22, 51, 53, 979, DateTimeKind.Local).AddTicks(5251), new Guid("a96b857a-4c32-47fc-93cc-0a0210856b1e"), null, "teacher19@example.com", true, "TeacherFirstName19", null, null, "TeacherLastName19", false, null, null, "TEACHER19@EXAMPLE.COM", "TEACHER19@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIbFErmeTzByTea4aUcBSqlT7oij1sl/Vx3ZILl176SqZo1uO0y0VnpwTDxo086H0A==", null, false, null, "8ddb9559-240d-4e77-8c83-52dae2fac30e", false, new DateTime(2024, 9, 23, 22, 51, 53, 979, DateTimeKind.Local).AddTicks(5262), "teacher19@example.com" },
                    { new Guid("38f8bed2-5d69-4ab5-9757-5c2adc1aad54"), 0, null, "dd2f6093-9eb7-476a-96d9-e45ef44a6ad1", new DateTime(2024, 9, 23, 22, 51, 54, 93, DateTimeKind.Local).AddTicks(2389), new Guid("93d0c0d7-eda3-41b1-a29a-9897dfc64a69"), null, "teacher20@example.com", true, "TeacherFirstName20", null, null, "TeacherLastName20", false, null, null, "TEACHER20@EXAMPLE.COM", "TEACHER20@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI390IaWFS1fzZ/Nj4SxMkWV6NSKydY5FluHCnsnmXgwW3S+PJOpkiDECvfuEGdbcg==", null, false, null, "93c2d969-475f-4c8e-a3ef-41d9bd1e573d", false, new DateTime(2024, 9, 23, 22, 51, 54, 93, DateTimeKind.Local).AddTicks(2399), "teacher20@example.com" },
                    { new Guid("3e010aeb-6106-4935-b3c7-05a76eff0f2d"), 0, null, "c12f9bc5-d52c-47a8-a709-1ae4499062c2", new DateTime(2024, 9, 23, 22, 51, 51, 482, DateTimeKind.Local).AddTicks(3048), new Guid("871a2632-3e7d-46c0-843d-fd9e5d779a7f"), null, "admin2@example.com", true, "Admin", null, null, "Two", false, null, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH52PHAhQD5gBePxPmvQkd4taKQNyiI9NTsuH2N2Wv38lvAtRdhIrWfllQ0NSBIaBw==", null, false, null, "96cc4323-ef00-4881-8756-70d8851ad43f", false, new DateTime(2024, 9, 23, 22, 51, 51, 482, DateTimeKind.Local).AddTicks(3063), "admin2@example.com" },
                    { new Guid("45c3635e-d7ef-436b-8cf0-19d1e255e28e"), 0, null, "da10f87e-db50-4530-878f-918bcb7b7706", new DateTime(2024, 9, 23, 22, 51, 52, 19, DateTimeKind.Local).AddTicks(737), new Guid("937c2785-3a1a-410e-b303-e9e9bcdd3b03"), null, "teacher3@example.com", true, "TeacherFirstName3", null, null, "TeacherLastName3", false, null, null, "TEACHER3@EXAMPLE.COM", "TEACHER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG2fXyqpw8aD3Jp7mNHb5YnIdDSd8/xdpl5TliZn4z+PRlpOsmcvuk34VXvmfbBlAA==", null, false, null, "6a5176ed-9861-4374-b8af-5c2c42917d77", false, new DateTime(2024, 9, 23, 22, 51, 52, 19, DateTimeKind.Local).AddTicks(753), "teacher3@example.com" },
                    { new Guid("482f4242-f6d2-4f9d-b4c8-9c5bdbb83f67"), 0, null, "ecaf5f79-f38b-4a29-99bb-e453c07bb65f", new DateTime(2024, 9, 23, 22, 51, 54, 482, DateTimeKind.Local).AddTicks(5556), new Guid("e3c3cb44-e116-40ed-bc4d-1a202b7f7def"), null, "teacher24@example.com", true, "TeacherFirstName24", null, null, "TeacherLastName24", false, null, null, "TEACHER24@EXAMPLE.COM", "TEACHER24@EXAMPLE.COM", "AQAAAAIAAYagAAAAEONOI9TS8slVT82avCKlLHHACmq/o/tl6Ym/GlwJgCHD22m8atTyMY5oJYSLjHvBZg==", null, false, null, "c3021ef2-ca4b-4d3a-9704-722d4a5ad2b8", false, new DateTime(2024, 9, 23, 22, 51, 54, 482, DateTimeKind.Local).AddTicks(5566), "teacher24@example.com" },
                    { new Guid("6109a8dd-7722-4966-a93c-7118ff03f2d7"), 0, null, "aa91b4ef-5494-4f1f-8c61-a5df003f44eb", new DateTime(2024, 9, 23, 22, 51, 51, 382, DateTimeKind.Local).AddTicks(5340), new Guid("af0be411-7060-4a19-bf7f-3f2e711cb15b"), null, "admin1@example.com", true, "Admin", null, null, "One", false, null, null, "ADMIN1@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJNHItMckn3M0eFfI4rMD/1m/Tl326uXwldf/2zp/ljUHL3L7JSAdXf3Ue6cEBck8g==", null, false, null, "d43cb8e2-3a1c-443f-916b-720607bfc063", false, new DateTime(2024, 9, 23, 22, 51, 51, 382, DateTimeKind.Local).AddTicks(5348), "admin1@example.com" },
                    { new Guid("65752996-b4bf-43e0-b3b3-eab9c99547dc"), 0, null, "c7f5f9e8-2ca6-4f28-9036-f3d1245051a2", new DateTime(2024, 9, 23, 22, 51, 53, 205, DateTimeKind.Local).AddTicks(6145), new Guid("71f3f39a-8a6f-4d8b-b721-9c6400b2e22b"), null, "teacher12@example.com", true, "TeacherFirstName12", null, null, "TeacherLastName12", false, null, null, "TEACHER12@EXAMPLE.COM", "TEACHER12@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKM/NyPZqAhD378S3X+ABVTNjymzVIrby91hFEFu3sW6UcXRgs02Y+CM1bkyW6jMGg==", null, false, null, "63a7370d-a5f6-4925-abd0-5ebf46461375", false, new DateTime(2024, 9, 23, 22, 51, 53, 205, DateTimeKind.Local).AddTicks(6155), "teacher12@example.com" },
                    { new Guid("683fa88e-4846-4fab-8782-87a832b9366d"), 0, null, "1d839882-2ea4-4cf4-bc34-ce9f832aaeff", new DateTime(2024, 9, 23, 22, 51, 51, 883, DateTimeKind.Local).AddTicks(9596), new Guid("d7ba056f-6217-4494-8eb5-b5e6e1d47d0d"), null, "teacher2@example.com", true, "TeacherFirstName2", null, null, "TeacherLastName2", false, null, null, "TEACHER2@EXAMPLE.COM", "TEACHER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC/tVjYdM4MbSiBTS11G3pOQKCZ7stZXRizyUsceTw4gFsPPGefbEv+DEc8OP06xmw==", null, false, null, "ce8b0608-234b-4c4e-ba06-6a2caca1f7a0", false, new DateTime(2024, 9, 23, 22, 51, 51, 883, DateTimeKind.Local).AddTicks(9602), "teacher2@example.com" },
                    { new Guid("7aa801ba-9100-418a-9b62-b83ca2e727cf"), 0, null, "001d8253-e8b3-45a6-8f01-e4509cd4948c", new DateTime(2024, 9, 23, 22, 51, 51, 598, DateTimeKind.Local).AddTicks(5052), new Guid("021f6223-e49c-4939-9862-91a46388172c"), null, "admin3@example.com", true, "Admin", null, null, "Three", false, null, null, "ADMIN3@EXAMPLE.COM", "ADMIN3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFt0/myiieOYwVun+LEMI/bhLYD+dcBNZiy7wVn7KjjB2L6UUz2HkRVI4R6xPAIwEg==", null, false, null, "602c2c95-1695-490d-9a0d-3208a8b5489a", false, new DateTime(2024, 9, 23, 22, 51, 51, 598, DateTimeKind.Local).AddTicks(5068), "admin3@example.com" },
                    { new Guid("7f29d230-c98c-4625-8a6a-983f8cef1996"), 0, null, "f5fdc771-b86a-4e2a-b6fa-aafe8efa5c28", new DateTime(2024, 9, 23, 22, 51, 54, 969, DateTimeKind.Local).AddTicks(7725), new Guid("92c7755c-e41a-4bc4-ba3a-4a41866a1709"), null, "teacher29@example.com", true, "TeacherFirstName29", null, null, "TeacherLastName29", false, null, null, "TEACHER29@EXAMPLE.COM", "TEACHER29@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN7vaWzUuNoobzdp3Sf+Xt8GFt1JqkxvrNApqdp30ZurGXCfxcYxuDBHPRRjXDIuAw==", null, false, null, "5378e374-744c-413a-b612-5960c03b6f4d", false, new DateTime(2024, 9, 23, 22, 51, 54, 969, DateTimeKind.Local).AddTicks(7737), "teacher29@example.com" },
                    { new Guid("81c49abe-a5dc-4cf2-8082-a695fac2daeb"), 0, null, "82b74ab5-30ba-479b-8ca3-e0dae5f3524e", new DateTime(2024, 9, 23, 22, 51, 52, 485, DateTimeKind.Local).AddTicks(2797), new Guid("6dbf4753-a627-459d-aff9-7414fa4407cf"), null, "teacher7@example.com", true, "TeacherFirstName7", null, null, "TeacherLastName7", false, null, null, "TEACHER7@EXAMPLE.COM", "TEACHER7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM4kiBV9cINCSpeX4eZR+7q3pKwrpSt/rOnyJXBZDyQpHVbPQBYpvP7E92Ni+slyIg==", null, false, null, "4e310207-e721-40ad-98a1-28f28459f28a", false, new DateTime(2024, 9, 23, 22, 51, 52, 485, DateTimeKind.Local).AddTicks(2809), "teacher7@example.com" },
                    { new Guid("8a650a83-d6be-4dee-a1c6-4dfb3d2e9418"), 0, null, "49a55905-1541-41ef-839a-9785c8b302e0", new DateTime(2024, 9, 23, 22, 51, 52, 135, DateTimeKind.Local).AddTicks(6238), new Guid("66ab06db-f83b-4357-8684-e86771bb600c"), null, "teacher4@example.com", true, "TeacherFirstName4", null, null, "TeacherLastName4", false, null, null, "TEACHER4@EXAMPLE.COM", "TEACHER4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH+MTeDhLwr1SUrN7Qi3g59BpkgBJ5VsnVcMDJkEngRZGwCDZAa8YpwwqL/6w5QBTA==", null, false, null, "f8d6798e-5f9a-4cc8-957c-f883e2508b44", false, new DateTime(2024, 9, 23, 22, 51, 52, 135, DateTimeKind.Local).AddTicks(6248), "teacher4@example.com" },
                    { new Guid("9015c1d4-f00c-47f2-b1d8-d2e595c139ce"), 0, null, "b66d7edd-a271-4449-9f04-16c4af168f6a", new DateTime(2024, 9, 23, 22, 51, 52, 878, DateTimeKind.Local).AddTicks(8304), new Guid("624887b7-2f57-4749-9a01-851a9bab2ffb"), null, "teacher10@example.com", true, "TeacherFirstName10", null, null, "TeacherLastName10", false, null, null, "TEACHER10@EXAMPLE.COM", "TEACHER10@EXAMPLE.COM", "AQAAAAIAAYagAAAAECb8d0Bp0dYt1NaABSkKkVbgAAe+EG8TJeF/5TMnIxN/pvYPTBw4jA64BhOIwGXbUQ==", null, false, null, "5a262fa6-bc31-4610-8636-8a9c34849c66", false, new DateTime(2024, 9, 23, 22, 51, 52, 878, DateTimeKind.Local).AddTicks(8311), "teacher10@example.com" },
                    { new Guid("96f5e944-9c27-4a58-b72f-6016d7774652"), 0, null, "32a42c48-d837-45f3-9b9c-0eaff62f2685", new DateTime(2024, 9, 23, 22, 51, 53, 863, DateTimeKind.Local).AddTicks(9147), new Guid("42e31f5b-a2b0-4502-a51b-e9eee3fe86b1"), null, "teacher18@example.com", true, "TeacherFirstName18", null, null, "TeacherLastName18", false, null, null, "TEACHER18@EXAMPLE.COM", "TEACHER18@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDhPSXDk8r3/iui+U0ZO20ymbBy76Fp1ZHaTDn19OXWJR40oO3jklO/+rjSJEo3xKg==", null, false, null, "aa320da3-77cf-42a9-acc1-05fb0a039972", false, new DateTime(2024, 9, 23, 22, 51, 53, 863, DateTimeKind.Local).AddTicks(9165), "teacher18@example.com" },
                    { new Guid("9dc05b4c-9cd9-4fe4-be9b-5166f92cf040"), 0, null, "f0c47b97-064b-492b-bfb7-9c202f57c93b", new DateTime(2024, 9, 23, 22, 51, 54, 288, DateTimeKind.Local).AddTicks(5592), new Guid("1ea230af-2ecd-4520-9e6e-5835d2ac8c08"), null, "teacher22@example.com", true, "TeacherFirstName22", null, null, "TeacherLastName22", false, null, null, "TEACHER22@EXAMPLE.COM", "TEACHER22@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAh/RsgwsVvRDdCNvXvEGyKJGJ3cY/CNrUN9moopPdpS5Hm++G+FDeVjJWdBlmaC9g==", null, false, null, "268b8591-8590-4054-bfd5-68bf46708265", false, new DateTime(2024, 9, 23, 22, 51, 54, 288, DateTimeKind.Local).AddTicks(5602), "teacher22@example.com" },
                    { new Guid("a6350713-f2de-4b21-893c-0b3fc47f7e20"), 0, null, "af17f6cb-a758-4341-9477-1bd035a76278", new DateTime(2024, 9, 23, 22, 51, 53, 578, DateTimeKind.Local).AddTicks(5152), new Guid("566c1270-e1f1-4deb-8d92-97397a400620"), null, "teacher15@example.com", true, "TeacherFirstName15", null, null, "TeacherLastName15", false, null, null, "TEACHER15@EXAMPLE.COM", "TEACHER15@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ5DefI6zx1bhTDaNiALRcDnClsmFeLUULa0muuCTJpZSdRUGkLzBnxxxZTbt/lD5g==", null, false, null, "97008b31-159c-4f18-9df5-893866f1d8a7", false, new DateTime(2024, 9, 23, 22, 51, 53, 578, DateTimeKind.Local).AddTicks(5164), "teacher15@example.com" },
                    { new Guid("b96f0c3a-b972-4712-a13b-02e8c180d00e"), 0, null, "78a730de-60ee-4cdc-976c-6423fbdcc089", new DateTime(2024, 9, 23, 22, 51, 54, 572, DateTimeKind.Local).AddTicks(2345), new Guid("5fbfa5ae-e784-494d-b310-8cb1d4d55a8e"), null, "teacher25@example.com", true, "TeacherFirstName25", null, null, "TeacherLastName25", false, null, null, "TEACHER25@EXAMPLE.COM", "TEACHER25@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAGQQo9ok69aIQmjOrz9fNvMCg7UOvdYOjcwZxpYfgioZ7NjwTK1r/NsY+SFp9ADzg==", null, false, null, "7ee6b7d5-9aca-411d-955b-e27b5782eb65", false, new DateTime(2024, 9, 23, 22, 51, 54, 572, DateTimeKind.Local).AddTicks(2351), "teacher25@example.com" },
                    { new Guid("be322a52-07a3-4e9f-9bc2-8f0b798fe830"), 0, null, "93fb6b25-87bb-4591-a9fd-62c9702515e7", new DateTime(2024, 9, 23, 22, 51, 52, 251, DateTimeKind.Local).AddTicks(1008), new Guid("54dc38fe-6c70-4172-b547-9449bc5f1249"), null, "teacher5@example.com", true, "TeacherFirstName5", null, null, "TeacherLastName5", false, null, null, "TEACHER5@EXAMPLE.COM", "TEACHER5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF0G4QCtETE7nwGnTz96tw7tTd1g5SvKN2zO80TWrTKp4ZL3VNDICvReY3DWeSxKFA==", null, false, null, "5dc34567-0451-4c0f-bcb2-e4d9324634ae", false, new DateTime(2024, 9, 23, 22, 51, 52, 251, DateTimeKind.Local).AddTicks(1020), "teacher5@example.com" },
                    { new Guid("c00c9d45-3d9d-4cb5-a266-355989853c7a"), 0, null, "c44597df-1ea6-4cab-a93d-bf90af2e67c3", new DateTime(2024, 9, 23, 22, 51, 53, 481, DateTimeKind.Local).AddTicks(519), new Guid("16fd9253-61ab-4ff9-b461-f02a1fd26655"), null, "teacher14@example.com", true, "TeacherFirstName14", null, null, "TeacherLastName14", false, null, null, "TEACHER14@EXAMPLE.COM", "TEACHER14@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDkxSrSB3sy/vSgfSearqvURwOuE/QI3hqg0KfeRpS9zx12JlRiQlKU2RUqnEUg1MA==", null, false, null, "c2f69419-57c4-4947-85cf-08523013351e", false, new DateTime(2024, 9, 23, 22, 51, 53, 481, DateTimeKind.Local).AddTicks(582), "teacher14@example.com" },
                    { new Guid("c04bf58c-9dfe-47d6-b777-84c461434410"), 0, null, "b128d6b8-8403-42c3-bade-35bc64bd1f74", new DateTime(2024, 9, 23, 22, 51, 54, 871, DateTimeKind.Local).AddTicks(1250), new Guid("de49ca1e-77bf-4b01-99e1-aac2a4a76c42"), null, "teacher28@example.com", true, "TeacherFirstName28", null, null, "TeacherLastName28", false, null, null, "TEACHER28@EXAMPLE.COM", "TEACHER28@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB7ANA4Z+iz8qs0LQaUKVF0+w3oRe/xERMlB9TI8MQBBSj2PTQJML9Ml5VqlRpO1UA==", null, false, null, "6e186a35-673f-4e10-a8ab-dd669f91c180", false, new DateTime(2024, 9, 23, 22, 51, 54, 871, DateTimeKind.Local).AddTicks(1263), "teacher28@example.com" },
                    { new Guid("c1d3a4c5-171a-484b-b064-687bd8b4ec44"), 0, null, "7a7d9da6-292a-444b-98b8-479278a61938", new DateTime(2024, 9, 23, 22, 51, 52, 600, DateTimeKind.Local).AddTicks(7270), new Guid("c2d34b86-17c6-44d2-85b5-f93135470a0b"), null, "teacher8@example.com", true, "TeacherFirstName8", null, null, "TeacherLastName8", false, null, null, "TEACHER8@EXAMPLE.COM", "TEACHER8@EXAMPLE.COM", "AQAAAAIAAYagAAAAENaTJunppAl5MlZSQj9jQ0zo1xA68pB34fkBEoUlM67ZPeHQAr2mzItQNTG2i53qKg==", null, false, null, "c33cccd0-89cf-4d34-9f5c-edbe90b92336", false, new DateTime(2024, 9, 23, 22, 51, 52, 600, DateTimeKind.Local).AddTicks(7278), "teacher8@example.com" },
                    { new Guid("ce60c704-d916-4d70-8337-b2510e85c2ff"), 0, null, "122747ea-be1e-4e02-bf8a-0e38a6748d4c", new DateTime(2024, 9, 23, 22, 51, 53, 56, DateTimeKind.Local).AddTicks(5146), new Guid("e6f740d5-fc2b-42ac-8dc0-dad6bb9fea9f"), null, "teacher11@example.com", true, "TeacherFirstName11", null, null, "TeacherLastName11", false, null, null, "TEACHER11@EXAMPLE.COM", "TEACHER11@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDcAJsxjw5ua6CM3oMw5+eXj9XGPiUmOnrjL51BwX42gnNCWT/sAOlOzc2tejJRoow==", null, false, null, "f09f1830-5507-4711-9a6e-71059ee678bc", false, new DateTime(2024, 9, 23, 22, 51, 53, 56, DateTimeKind.Local).AddTicks(5158), "teacher11@example.com" },
                    { new Guid("db300226-5196-4167-a988-1e39cb8e63a7"), 0, null, "78253a85-c797-4690-b9da-21c7f650496b", new DateTime(2024, 9, 23, 22, 51, 53, 771, DateTimeKind.Local).AddTicks(2893), new Guid("a8b195d0-9764-41c6-901f-78c1975dee7f"), null, "teacher17@example.com", true, "TeacherFirstName17", null, null, "TeacherLastName17", false, null, null, "TEACHER17@EXAMPLE.COM", "TEACHER17@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPjWdRVgLBgo3tY96DbsnOhocz9BCVqj3g2RGFgN1dfVPFdO9oiadm+e5GG7lIcl3g==", null, false, null, "b4c3b8ad-8f4b-49af-b7c3-e8a776fff2e3", false, new DateTime(2024, 9, 23, 22, 51, 53, 771, DateTimeKind.Local).AddTicks(2898), "teacher17@example.com" },
                    { new Guid("f41cae83-7f2e-4e25-8e79-ab226d10482d"), 0, null, "29809f5b-c324-4b19-9e2f-eb4f9063adbc", new DateTime(2024, 9, 23, 22, 51, 54, 668, DateTimeKind.Local).AddTicks(1354), new Guid("07b32077-2cce-446e-9b88-89273886b2af"), null, "teacher26@example.com", true, "TeacherFirstName26", null, null, "TeacherLastName26", false, null, null, "TEACHER26@EXAMPLE.COM", "TEACHER26@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDh2A0ybZIVHnYt2KYuamSoZsBikNdRXpCvSiuAdosVDfkHU2M+MkzvNC7Hz0+1nig==", null, false, null, "03f12342-5628-4d9c-a61e-e53c9e8f64e3", false, new DateTime(2024, 9, 23, 22, 51, 54, 668, DateTimeKind.Local).AddTicks(1371), "teacher26@example.com" },
                    { new Guid("fe219fd4-4f7c-4d7f-b27b-d6999f11073d"), 0, null, "3ae879b4-3feb-4489-a1f0-72d24334d25a", new DateTime(2024, 9, 23, 22, 51, 52, 704, DateTimeKind.Local).AddTicks(2148), new Guid("38c0d490-2d6c-4eb8-bf3f-51c108caa75a"), null, "teacher9@example.com", true, "TeacherFirstName9", null, null, "TeacherLastName9", false, null, null, "TEACHER9@EXAMPLE.COM", "TEACHER9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL5H4l7bOU5OSJnvaHWv1BMHs5ArBWuSOEv/Yt9StzbUEV9aG1BRUxuM5VAMLCiWsQ==", null, false, null, "86c54e98-1c66-492f-a8ba-d3ac18e7c55b", false, new DateTime(2024, 9, 23, 22, 51, 52, 704, DateTimeKind.Local).AddTicks(2161), "teacher9@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("013121bd-f11a-4f5b-84e3-11c5fdca3196") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("05d2230a-9679-422e-8eb5-457004957602") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("085ddcca-d8d2-484b-a2ba-a1c473c58eed") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("09e4ec4d-7a7b-4243-bb4f-becce258a04a") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("0e11cc21-9d2e-468e-98ad-15f71abcc1ed") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1629c4af-3689-43c2-bda2-5828c3bbc6ec") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("1813d049-65f4-49eb-ada8-4052a3ce3237") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("19ebdca8-5718-4b33-ab3a-30b5d595424b") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("2ef8934b-3efd-4341-971b-2cb691fca3cf") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("38f8bed2-5d69-4ab5-9757-5c2adc1aad54") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("3e010aeb-6106-4935-b3c7-05a76eff0f2d") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("45c3635e-d7ef-436b-8cf0-19d1e255e28e") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("482f4242-f6d2-4f9d-b4c8-9c5bdbb83f67") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("6109a8dd-7722-4966-a93c-7118ff03f2d7") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("65752996-b4bf-43e0-b3b3-eab9c99547dc") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("683fa88e-4846-4fab-8782-87a832b9366d") },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), new Guid("7aa801ba-9100-418a-9b62-b83ca2e727cf") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("7f29d230-c98c-4625-8a6a-983f8cef1996") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("81c49abe-a5dc-4cf2-8082-a695fac2daeb") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("8a650a83-d6be-4dee-a1c6-4dfb3d2e9418") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("9015c1d4-f00c-47f2-b1d8-d2e595c139ce") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("96f5e944-9c27-4a58-b72f-6016d7774652") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("9dc05b4c-9cd9-4fe4-be9b-5166f92cf040") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("a6350713-f2de-4b21-893c-0b3fc47f7e20") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("b96f0c3a-b972-4712-a13b-02e8c180d00e") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("be322a52-07a3-4e9f-9bc2-8f0b798fe830") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c00c9d45-3d9d-4cb5-a266-355989853c7a") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c04bf58c-9dfe-47d6-b777-84c461434410") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("c1d3a4c5-171a-484b-b064-687bd8b4ec44") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("ce60c704-d916-4d70-8337-b2510e85c2ff") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("db300226-5196-4167-a988-1e39cb8e63a7") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("f41cae83-7f2e-4e25-8e79-ab226d10482d") },
                    { new Guid("0da24f70-3cc9-44b1-a48e-aa9d93635514"), new Guid("fe219fd4-4f7c-4d7f-b27b-d6999f11073d") }
                });
        }
    }
}
