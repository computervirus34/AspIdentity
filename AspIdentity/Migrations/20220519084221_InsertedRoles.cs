using Microsoft.EntityFrameworkCore.Migrations;

namespace AspIdentity.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "696bb18e-82ae-41cf-a2ac-67eb019f66bb", "49376db4-cfc3-42f2-a02a-e743976db79b", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8b9a4da-8bb8-438b-96af-4accbf933291", "a012b3e6-39ed-4ace-8fd3-f5c698120e14", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "696bb18e-82ae-41cf-a2ac-67eb019f66bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8b9a4da-8bb8-438b-96af-4accbf933291");
        }
    }
}
