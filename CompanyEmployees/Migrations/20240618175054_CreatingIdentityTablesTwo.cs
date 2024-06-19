using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class CreatingIdentityTablesTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4b98c189-3f90-4354-94b6-f8e757b4de52", "2792c894-efb5-415e-93aa-21f7fc2f987f", "Administrator", "ADMINSITRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8cad038d-61ec-43cf-a053-14cabfc1638a", "31edf530-8647-41de-aa8b-8af018d12be1", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b98c189-3f90-4354-94b6-f8e757b4de52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cad038d-61ec-43cf-a053-14cabfc1638a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "350a3101-e2cc-4d05-a605-d64350442a9f", "a263f5c0-06e9-4232-b7fe-be8274b451b9", "Administrator", "ADMINSITRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ce4670c-f35c-46b7-b661-3fa7ca35e5cb", "97fa25a0-6089-4913-9348-131caa08502d", "Manager", "MANAGER" });
        }
    }
}
