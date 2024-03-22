using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class sessionsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb55e52-c51d-45e9-8688-8cc880022a02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c94e6bb-322f-48c9-a688-96f36130ca6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3545262-7e32-40d2-a56e-4ce295e1dd60");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Session_Date_Time",
                table: "Sessions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "49f9f49c-7eb9-4a0b-891b-09bb91a75e1c", null, "Doctor", "DOCTOR" },
                    { "80029ec1-8b05-4751-888d-ab746376e22a", null, "Administrator", "ADMINISTRATOR" },
                    { "c84df844-bc84-4b1e-a75b-db75c80a3ff5", null, "Patient", "PATIENT" }
                });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 1,
                column: "Session_Date_Time",
                value: new DateTime(1993, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f9f49c-7eb9-4a0b-891b-09bb91a75e1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80029ec1-8b05-4751-888d-ab746376e22a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c84df844-bc84-4b1e-a75b-db75c80a3ff5");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Session_Date_Time",
                table: "Sessions",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2bb55e52-c51d-45e9-8688-8cc880022a02", null, "Administrator", "ADMINISTRATOR" },
                    { "8c94e6bb-322f-48c9-a688-96f36130ca6f", null, "Patient", "PATIENT" },
                    { "a3545262-7e32-40d2-a56e-4ce295e1dd60", null, "Doctor", "DOCTOR" }
                });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 1,
                column: "Session_Date_Time",
                value: new DateOnly(1993, 12, 1));
        }
    }
}
