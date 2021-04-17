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
                value: "84214484-8251-4ef4-83e3-23fd0ba53e1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a0a56cbd-6411-493a-8e1d-3cb7b7a8b683");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5f2bacbd-a184-4db1-a83a-6fc4ca93f7db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "e15830fa-72f4-418c-9b6e-7143c77abc95");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bdc3094-1578-4376-a33d-3b74e6d5c709", "AQAAAAEAACcQAAAAECsb3pgfpnECby7GplJkgxLPL0TOmR1DOgpnNtu6zWVTPhAm2YgM94gACodXkhVZrw==", "826bddf8-7d06-4102-815f-6a5965d58ed6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e7905ce7-f59b-40c6-9413-3c78a1c0e62d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0ee8ffd5-c439-4de6-805a-878bd858aed7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b21919ae-3281-423d-95ca-827fffed283d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "83fa9e6e-118a-4728-a9b3-04cfda7b394a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "983e56b8-98f1-4834-874e-cf107216d049", "AQAAAAEAACcQAAAAEBXtOwtDJ2dFEhSmQxDGkOOWM+ZgsRHq+BmiJGLNz3/hRqCSi+GOrk38XP9yKihmoA==", "f119f06b-8b69-4ecf-b7d8-0c1f5572703a" });
        }
    }
}
