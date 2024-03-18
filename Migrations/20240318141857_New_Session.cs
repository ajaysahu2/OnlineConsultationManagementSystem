using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultationManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class New_Session : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Session_Date_Time = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    VideoLink = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57938fb5-497b-40f3-bbd9-376184eca60e", null, "Patient", "PATIENT" },
                    { "7917c1c6-7c23-44fb-a30a-7046c2ad8898", null, "Doctor", "DOCTOR" },
                    { "abcd6652-7e36-4b27-9a16-c8ff67f79c9f", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03508db8-1e70-4570-b9a3-4f63a648eb06", null, "Patient", "PATIENT" },
                    { "31ad2f83-3800-40b9-9629-9198a0605acc", null, "Doctor", "DOCTOR" },
                    { "9d4eb6a0-4e2d-4db2-abf9-1609da01717a", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
