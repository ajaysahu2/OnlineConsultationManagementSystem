using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class New_Appointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorsDoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    SessionId = table.Column<int>(type: "INTEGER", nullable: false),
                    SessionsSessionId = table.Column<int>(type: "INTEGER", nullable: false),
                    ConsultationId = table.Column<int>(type: "INTEGER", nullable: false),
                    ConsultationsConsultationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Consultations_ConsultationsConsultationId",
                        column: x => x.ConsultationsConsultationId,
                        principalTable: "Consultations",
                        principalColumn: "ConsultationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorsDoctorId",
                        column: x => x.DoctorsDoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Sessions_SessionsSessionId",
                        column: x => x.SessionsSessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b524832-e756-46ad-a8b6-26868574bf0a", null, "Doctor", "DOCTOR" },
                    { "d8e9b01e-b6d5-4408-97f3-b726316b1c5f", null, "Administrator", "ADMINISTRATOR" },
                    { "df63ef11-7864-480b-996e-2cc6bd468b6d", null, "Patient", "PATIENT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ConsultationsConsultationId",
                table: "Appointments",
                column: "ConsultationsConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorsDoctorId",
                table: "Appointments",
                column: "DoctorsDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SessionsSessionId",
                table: "Appointments",
                column: "SessionsSessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b524832-e756-46ad-a8b6-26868574bf0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8e9b01e-b6d5-4408-97f3-b726316b1c5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df63ef11-7864-480b-996e-2cc6bd468b6d");

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
    }
}
