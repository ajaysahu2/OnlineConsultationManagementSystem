using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class PatientWithDataDataApplicationContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b6e3919-5da7-4421-8425-6683a75e3220");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5d6b261-ee4d-4390-801e-bcd0ba2c3f80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff4a92b0-8709-421f-8bd7-83f710a8c7d3");

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    MobileNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient");

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
                    { "9b6e3919-5da7-4421-8425-6683a75e3220", "987ad257-e97b-477b-8eda-954660678c98", "Patient", "PATIENT" },
                    { "d5d6b261-ee4d-4390-801e-bcd0ba2c3f80", "1843bb91-4247-4126-92b7-2847f775551e", "Doctor", "DOCTOR" },
                    { "ff4a92b0-8709-421f-8bd7-83f710a8c7d3", "e02d2013-bdd7-40c4-b21a-02b9cd95f9f6", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
