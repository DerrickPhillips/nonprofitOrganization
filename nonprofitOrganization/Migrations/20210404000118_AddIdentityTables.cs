using Microsoft.EntityFrameworkCore.Migrations;

namespace nonprofitOrganization.Migrations
{
    public partial class AddIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "748bfb18-ac48-416c-81a5-41cc4757b944");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "de996fcd-86ad-4557-8148-a6c23357fa61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4049b0a2-2f6a-407e-a67a-8629dcb98579");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "65d51704-de1d-4234-aa1b-a0c431a83fda");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a8acf83-c64c-421a-ade6-81cfc582e3cb", "AQAAAAEAACcQAAAAENGDJzn8SLcGIYSG0sUj8j0poHGgKayctIovs6HiQQF1PY19W+OXdggOM4C4oqxNeQ==", "f0aa1f9b-683b-47bb-8f4d-adec40d06d2e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b14eb6f6-5087-410b-9197-beccd9f22b05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "33613fa6-a3a1-4f5b-a599-ac21752d5d7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c801c33c-2040-4b2c-8e78-2e796fdab84d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "abad8dec-91b7-4f32-9e9c-f0309026cc5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dc59662-f846-4eaf-94eb-65c1c613a35d", "AQAAAAEAACcQAAAAEGQuWo67JfdSx7THeTUk0ReVA7q6fE0PHRRn2khUIQl4T1F21KAQBXyARXq7lbBkAQ==", "1f6e9044-38fa-4483-9e3a-7dd8ca2afe4c" });
        }
    }
}
