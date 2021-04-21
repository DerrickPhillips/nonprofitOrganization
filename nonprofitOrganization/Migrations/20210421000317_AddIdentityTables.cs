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
                value: "8eae66b9-efc8-450c-80b5-d3a1f298e436");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2dc554ec-ebc2-4a21-bf00-a00f215f69f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2e8f1017-6ea3-4bbc-a96e-e37cdf0e748d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "98335af2-de28-4a07-bb22-3044e5c7b54c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66b6f372-5442-45e7-ac3c-ebceb7e1c8f7", "AQAAAAEAACcQAAAAECQKgzcRhwMUcffTwWaU8MzpFiDgL0WF2vAJ9Uh3MZovg4DH2EW0f42AukurXBbvnQ==", "00d8907c-f634-4ae7-9eff-16fe690c5021" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "410af307-05fc-40c7-9258-847ffb5f72ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a4706d82-d7db-49b3-8810-71f02e36037d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ef06ac23-6015-414b-8bfc-4089b876abf4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "07bd6820-fe59-40da-b1ec-9341523c430c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7fae812-deee-46ff-a2d4-1e5d80d3f0a1", "AQAAAAEAACcQAAAAEBEWF59t+k3irHvUM6J0vuXjYjuNvZZYPOuhOm1GwY5vyF/i/Db9jB24bPxK9iXPGg==", "d1f9d4e2-9fc7-46a5-b106-abf61cc25d47" });
        }
    }
}
