using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineConsultationManagementSystem.Migrations
{
    public partial class addingRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b6e3919-5da7-4421-8425-6683a75e3220", "987ad257-e97b-477b-8eda-954660678c98", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5d6b261-ee4d-4390-801e-bcd0ba2c3f80", "1843bb91-4247-4126-92b7-2847f775551e", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff4a92b0-8709-421f-8bd7-83f710a8c7d3", "e02d2013-bdd7-40c4-b21a-02b9cd95f9f6", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
