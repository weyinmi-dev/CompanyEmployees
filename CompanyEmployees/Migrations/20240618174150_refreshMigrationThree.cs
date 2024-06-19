using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class refreshMigrationThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e5b7310-223d-4df2-addb-3f95ae549526");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fae79848-42f4-41ce-97a0-a410a3a6a010");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "350a3101-e2cc-4d05-a605-d64350442a9f", "a263f5c0-06e9-4232-b7fe-be8274b451b9", "Administrator", "ADMINSITRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ce4670c-f35c-46b7-b661-3fa7ca35e5cb", "97fa25a0-6089-4913-9348-131caa08502d", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "350a3101-e2cc-4d05-a605-d64350442a9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ce4670c-f35c-46b7-b661-3fa7ca35e5cb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e5b7310-223d-4df2-addb-3f95ae549526", "354051c9-f53a-4a57-92ed-81eb6961cb5f", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fae79848-42f4-41ce-97a0-a410a3a6a010", "77e7bb7a-b445-4723-af9a-c893d1a56ab5", "Administrator", "ADMINSITRATOR" });
        }
    }
}
