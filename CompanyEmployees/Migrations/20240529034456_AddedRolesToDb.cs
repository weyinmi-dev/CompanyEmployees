using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53932fa2-ffda-41b3-a91a-8e193b419e02", "9fa74143-6742-4ed8-a92b-141f15db0aa6", "Administrator", "ADMINSITRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c050c478-37a9-4ac1-b9bd-3da4dc9c6dc8", "af68e72e-4b94-4958-9443-a52d992ceada", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53932fa2-ffda-41b3-a91a-8e193b419e02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c050c478-37a9-4ac1-b9bd-3da4dc9c6dc8");
        }
    }
}
