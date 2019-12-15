using Microsoft.EntityFrameworkCore.Migrations;

namespace Person.Repository.Migrations
{
    public partial class Fake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "FromId", "ToId", "RelationType" },
                values: new object[] { 1, 1, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 1, 1 });
        }
    }
}
