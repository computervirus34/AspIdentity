using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspIdentity.Migrations
{
    public partial class EmployeeConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "696bb18e-82ae-41cf-a2ac-67eb019f66bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8b9a4da-8bb8-438b-96af-4accbf933291");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "adb5d9c9-bd75-4bca-bc7f-ac30e1e66d8b", "33ab357f-e6d2-4c02-a538-34eca4342277", "Admin", "ADMIN" },
                    { "8b7c5b4d-338a-4ef7-ae10-666aecf6b366", "7807ab11-fe9e-40f9-a290-ee1ee030fa1f", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("c00e6427-a712-4042-b197-d84641a63383"), "34", "Ahsan Habib", "Software Developer" },
                    { new Guid("94cb60ed-2d7c-4dad-b878-d1634fd16277"), "34", "Test Name", "Software Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b7c5b4d-338a-4ef7-ae10-666aecf6b366");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adb5d9c9-bd75-4bca-bc7f-ac30e1e66d8b");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "696bb18e-82ae-41cf-a2ac-67eb019f66bb", "49376db4-cfc3-42f2-a02a-e743976db79b", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8b9a4da-8bb8-438b-96af-4accbf933291", "a012b3e6-39ed-4ace-8fd3-f5c698120e14", "Administrator", "ADMINISTRATOR" });
        }
    }
}
