using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7827300c-6959-4554-b0a5-ec21f55031c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b0b7129-aac1-4b13-91c1-9c3a978ba794");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceb9a311-73f9-4c38-a505-49b865f82109");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7827300c-6959-4554-b0a5-ec21f55031c5", null, "Administrator", "ADMINISTRATOR" },
                    { "8b0b7129-aac1-4b13-91c1-9c3a978ba794", null, "Patient", "PATIENT" },
                    { "ceb9a311-73f9-4c38-a505-49b865f82109", null, "Doctor", "DOCTOR" }
                });
        }
    }
}
