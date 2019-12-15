using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Person.Repository.Migrations
{
    public partial class AddRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthDate", "City", "FirstName", "Gender", "LastName", "PhotoPath", "PrivateNumber" },
                values: new object[] { 3, new DateTime(1994, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tbilisi", "Sssssssss", 0, "Keti", null, "3333333" });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "Number", "NumberType", "PersonId" },
                values: new object[] { 4, "888888", 2, 2 });

            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "FromId", "ToId", "RelationType" },
                values: new object[] { 1, 2, 2 });

            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "FromId", "ToId", "RelationType" },
                values: new object[] { 1, 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
