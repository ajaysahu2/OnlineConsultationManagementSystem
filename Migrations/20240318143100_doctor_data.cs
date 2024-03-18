using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class doctor_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "483637b0-5a64-4b52-a909-7203a03354f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b63d65d-f256-431e-a32f-0c0e80434607");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e164782e-f60e-4474-a71f-dff7558abdd4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05199f91-d29e-4e1e-b9a7-e41e598be415", null, "Patient", "PATIENT" },
                    { "61fc887f-a5b5-49f8-a568-df801ab6cd39", null, "Administrator", "ADMINISTRATOR" },
                    { "bd7fabcf-d36f-4861-b5f9-3bd431c119c7", null, "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ContactInfo", "Name", "Specialization" },
                values: new object[] { 1, 9696655411L, "Ram", "Physician" });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Address", "ContactInfo", "DateOfBirth", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, "Hyderabad", 6365633655L, new DateOnly(1993, 12, 1), "Male", "Ajay" },
                    { 2, "Kolkata", 6365633655L, new DateOnly(1990, 12, 1), "Male", "Anjay" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05199f91-d29e-4e1e-b9a7-e41e598be415");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61fc887f-a5b5-49f8-a568-df801ab6cd39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd7fabcf-d36f-4861-b5f9-3bd431c119c7");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "483637b0-5a64-4b52-a909-7203a03354f3", null, "Patient", "PATIENT" },
                    { "4b63d65d-f256-431e-a32f-0c0e80434607", null, "Doctor", "DOCTOR" },
                    { "e164782e-f60e-4474-a71f-dff7558abdd4", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
