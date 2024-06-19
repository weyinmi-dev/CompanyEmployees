using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class refreshMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ea1d321-4d62-43ab-a408-a51e717f82f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a52e42d5-7442-490e-bb27-4dc1f007343a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7601fdc0-f0a5-4411-b774-cd2d879f70be", "b4aa5f6b-4ed4-4b43-b3f5-764ef789d2d0", "Administrator", "ADMINSITRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e152e19-63aa-435d-a656-a69b00cf67fa", "dc3a361e-4897-4588-ab45-3a2eb72d1cb4", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2ea1d321-4d62-43ab-a408-a51e717f82f4", "52e7a4d6-21b4-43f7-945b-6dd202aefe49", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a52e42d5-7442-490e-bb27-4dc1f007343a", "6a0e1fbc-746d-4cca-949d-afc0f76829c1", "Administrator", "ADMINSITRATOR" });
        }
    }
}
