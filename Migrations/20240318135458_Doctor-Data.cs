using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class DoctorData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bbbab47-0c85-47e7-9a6c-4e70e9dec39a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5614ecbe-3968-47b1-b382-74b101c26e80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "643f2447-330e-491b-93d4-eeac6e7785c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03508db8-1e70-4570-b9a3-4f63a648eb06", null, "Patient", "PATIENT" },
                    { "31ad2f83-3800-40b9-9629-9198a0605acc", null, "Doctor", "DOCTOR" },
                    { "9d4eb6a0-4e2d-4db2-abf9-1609da01717a", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ContactInfo", "Name", "Specialization" },
                values: new object[] { 1, 9696655411L, "Ram", "Physician" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03508db8-1e70-4570-b9a3-4f63a648eb06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31ad2f83-3800-40b9-9629-9198a0605acc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d4eb6a0-4e2d-4db2-abf9-1609da01717a");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bbbab47-0c85-47e7-9a6c-4e70e9dec39a", null, "Patient", "PATIENT" },
                    { "5614ecbe-3968-47b1-b382-74b101c26e80", null, "Doctor", "DOCTOR" },
                    { "643f2447-330e-491b-93d4-eeac6e7785c0", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
