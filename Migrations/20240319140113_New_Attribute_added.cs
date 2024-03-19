using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class New_Attribute_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sessions",
                newName: "SessionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patient",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctors",
                newName: "DoctorId");

            migrationBuilder.CreateTable(
                name: "Consultations",
                columns: table => new
                {
                    ConsultationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Prescription = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultations", x => x.ConsultationId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "371d5699-4ea9-422f-a37b-86c7d5692b1c", null, "Administrator", "ADMINISTRATOR" },
                    { "4da3b569-fc48-4ca9-972e-58a34b4a9c00", null, "Patient", "PATIENT" },
                    { "64f9def1-60c3-4146-ba52-57e1b6ccfed7", null, "Doctor", "DOCTOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "371d5699-4ea9-422f-a37b-86c7d5692b1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4da3b569-fc48-4ca9-972e-58a34b4a9c00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64f9def1-60c3-4146-ba52-57e1b6ccfed7");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "Sessions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Patient",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Doctors",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05199f91-d29e-4e1e-b9a7-e41e598be415", null, "Patient", "PATIENT" },
                    { "61fc887f-a5b5-49f8-a568-df801ab6cd39", null, "Administrator", "ADMINISTRATOR" },
                    { "bd7fabcf-d36f-4861-b5f9-3bd431c119c7", null, "Doctor", "DOCTOR" }
                });
        }
    }
}
