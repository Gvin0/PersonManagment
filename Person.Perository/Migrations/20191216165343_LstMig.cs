using Microsoft.EntityFrameworkCore.Migrations;

namespace Person.Repository.Migrations
{
    public partial class LstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "FromId", "ToId", "RelationType" },
                values: new object[] { 4, 1, 0 });

            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "FromId", "ToId", "RelationType" },
                values: new object[] { 2, 5, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 4, 1 });
        }
    }
}
