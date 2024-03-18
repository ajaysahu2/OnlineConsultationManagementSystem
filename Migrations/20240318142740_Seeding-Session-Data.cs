using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedingSessionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57938fb5-497b-40f3-bbd9-376184eca60e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7917c1c6-7c23-44fb-a30a-7046c2ad8898");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abcd6652-7e36-4b27-9a16-c8ff67f79c9f");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "483637b0-5a64-4b52-a909-7203a03354f3", null, "Patient", "PATIENT" },
                    { "4b63d65d-f256-431e-a32f-0c0e80434607", null, "Doctor", "DOCTOR" },
                    { "e164782e-f60e-4474-a71f-dff7558abdd4", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Session_Date_Time", "VideoLink" },
                values: new object[] { 1, new DateOnly(1993, 12, 1), "https://chat.openai.com/c/5d129c40-0119-40e6-8a7a-6ad30f40fc9b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57938fb5-497b-40f3-bbd9-376184eca60e", null, "Patient", "PATIENT" },
                    { "7917c1c6-7c23-44fb-a30a-7046c2ad8898", null, "Doctor", "DOCTOR" },
                    { "abcd6652-7e36-4b27-9a16-c8ff67f79c9f", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ContactInfo", "Name", "Specialization" },
                values: new object[] { 1, 9696655411L, "Ram", "Physician" });
        }
    }
}
