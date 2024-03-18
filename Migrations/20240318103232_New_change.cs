using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class New_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ea2e13b-83f3-4a92-8126-2df2a96437ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "756c2354-2e70-46ba-ac7f-351361048c93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed625d83-8bfd-46de-8678-b6d13048183b");

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "Patient",
                newName: "ContactInfo");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patient",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "54e18a67-4561-4454-851d-8820c6b37ba6", null, "Administrator", "ADMINISTRATOR" },
                    { "991a2fec-5222-4dc2-9b00-449858bf2a3a", null, "Patient", "PATIENT" },
                    { "d64cfa9b-9312-4ecc-b58b-83f867d893eb", null, "Doctor", "DOCTOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54e18a67-4561-4454-851d-8820c6b37ba6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "991a2fec-5222-4dc2-9b00-449858bf2a3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64cfa9b-9312-4ecc-b58b-83f867d893eb");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "ContactInfo",
                table: "Patient",
                newName: "MobileNumber");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ea2e13b-83f3-4a92-8126-2df2a96437ab", null, "Doctor", "DOCTOR" },
                    { "756c2354-2e70-46ba-ac7f-351361048c93", null, "Patient", "PATIENT" },
                    { "ed625d83-8bfd-46de-8678-b6d13048183b", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Address", "Gender", "MobileNumber", "Name" },
                values: new object[,]
                {
                    { 1, "Hyderabad", "Male", 6365633655L, "Ajay" },
                    { 2, "Kolkata", "Male", 6365633655L, "Anjay" }
                });
        }
    }
}
