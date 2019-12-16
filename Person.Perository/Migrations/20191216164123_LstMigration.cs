using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Person.Repository.Migrations
{
    public partial class LstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "FirstName", "LastName" },
                values: new object[] { "Test1", "Test1", "Test1" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "City", "FirstName", "LastName" },
                values: new object[] { new DateTime(1995, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tbl", "Test2", "Test2" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "PrivateNumber" },
                values: new object[] { "Test3", "Test3", "11111111111" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthDate", "City", "FirstName", "Gender", "LastName", "PhotoPath", "PrivateNumber" },
                values: new object[,]
                {
                    { 4, new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test3", "Test4", 0, "Test4", null, "11111111111" },
                    { 5, new DateTime(2000, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test3", "Test5", 0, "Test5", null, "11111111111" },
                    { 6, new DateTime(2000, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test6", "Test6", 0, "Test6", null, "11111111111" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "Number", "NumberType", "PersonId" },
                values: new object[] { 5, "55555555", 2, 3 });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "Number", "NumberType", "PersonId" },
                values: new object[,]
                {
                    { 6, "66666666", 0, 4 },
                    { 7, "77777777", 1, 5 },
                    { 8, "77777777", 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "FromId", "ToId", "RelationType" },
                values: new object[,]
                {
                    { 3, 4, 3 },
                    { 5, 1, 0 },
                    { 3, 6, 3 },
                    { 6, 2, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "FirstName", "LastName" },
                values: new object[] { "Tbilisi", "Gviniashvili", "Levani" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "City", "FirstName", "LastName" },
                values: new object[] { new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tbilisi", "Gviniashvilii", "Levaniii" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "PrivateNumber" },
                values: new object[] { "Sssssssss", "Keti", "3333333" });

            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "FromId", "ToId", "RelationType" },
                values: new object[,]
                {
                    { 3, 1, 3 },
                    { 1, 1, 0 }
                });
        }
    }
}
