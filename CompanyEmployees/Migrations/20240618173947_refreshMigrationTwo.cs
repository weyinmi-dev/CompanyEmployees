using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class refreshMigrationTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7601fdc0-f0a5-4411-b774-cd2d879f70be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e152e19-63aa-435d-a656-a69b00cf67fa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e5b7310-223d-4df2-addb-3f95ae549526", "354051c9-f53a-4a57-92ed-81eb6961cb5f", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fae79848-42f4-41ce-97a0-a410a3a6a010", "77e7bb7a-b445-4723-af9a-c893d1a56ab5", "Administrator", "ADMINSITRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7601fdc0-f0a5-4411-b774-cd2d879f70be", "b4aa5f6b-4ed4-4b43-b3f5-764ef789d2d0", "Administrator", "ADMINSITRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e152e19-63aa-435d-a656-a69b00cf67fa", "dc3a361e-4897-4588-ab45-3a2eb72d1cb4", "Manager", "MANAGER" });
        }
    }
}
