using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class userRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53932fa2-ffda-41b3-a91a-8e193b419e02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c050c478-37a9-4ac1-b9bd-3da4dc9c6dc8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ea1d321-4d62-43ab-a408-a51e717f82f4", "52e7a4d6-21b4-43f7-945b-6dd202aefe49", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a52e42d5-7442-490e-bb27-4dc1f007343a", "6a0e1fbc-746d-4cca-949d-afc0f76829c1", "Administrator", "ADMINSITRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "53932fa2-ffda-41b3-a91a-8e193b419e02", "9fa74143-6742-4ed8-a92b-141f15db0aa6", "Administrator", "ADMINSITRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c050c478-37a9-4ac1-b9bd-3da4dc9c6dc8", "af68e72e-4b94-4958-9443-a52d992ceada", "Manager", "MANAGER" });
        }
    }
}
