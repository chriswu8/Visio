using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VisionX.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fee = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProvincialHealthNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    IsEditing = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientID = table.Column<int>(type: "int", nullable: true),
                    ExamID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Appointment_Exam_ExamID",
                        column: x => x.ExamID,
                        principalTable: "Exam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointment_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID");
                });

            migrationBuilder.InsertData(
                table: "Exam",
                columns: new[] { "Id", "Code", "Description", "Fee" },
                values: new object[,]
                {
                    { 1, "REE1", "Regular Eye Exam", 100 },
                    { 2, "GEE1", "General Eye Exam", 200 },
                    { 3, "YEE1", "Regular Eye Exam 3", 300 }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "PatientID", "Address", "BirthDate", "City", "Email", "FirstName", "IsEditing", "IsSelected", "LastName", "MiddleName", "Occupation", "Phone", "PostalCode", "Province", "ProvincialHealthNumber" },
                values: new object[,]
                {
                    { 1, "123 Main st", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vancouver", "test@mail.com", "Edmond", false, false, "Chen", "Li", "test", "233132", "VA2 34B", "BC", "12345" },
                    { 2, "123 Test St", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richmond", "test@mail.com", "Chris", false, false, "Wu", "Yue", "test", "233132", "VA2 34B", "BC", "12345" },
                    { 3, "123 Minor st", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vancouver", "test@mail.com", "Kris", false, false, "Ocampo", "Li", "test", "233132", "VA2 34B", "BC", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "ID", "Day", "ExamID", "Month", "PatientID", "Time", "Year" },
                values: new object[] { 1, "21", 1, "January", 1, "9:00", "2023" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ExamID",
                table: "Appointment",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientID",
                table: "Appointment",
                column: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
