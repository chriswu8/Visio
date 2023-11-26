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
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EyeDrops = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoryOfCancer = table.Column<bool>(type: "bit", nullable: false),
                    HistoryOfCataracts = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfDiabetes = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfHeartProblems = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfHIV = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfKidneyDisease = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfMacularDegeneration = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfRetinalDetachment = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfStroke = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfThyroid = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfTuberculosis = table.Column<bool>(type: "bit", nullable: true),
                    HistoryOfNeuromuscularDisease = table.Column<bool>(type: "bit", nullable: true),
                    UncorrectedSphere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UncorrectedCyliner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UncorrectedAxis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectedSphere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectedCyliner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectedAxis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LifeStage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlaucomaFamilyHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasGlaucoma = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.ExamId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Service",
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
                    table.PrimaryKey("PK_Service", x => x.Id);
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
                    IsEditing = table.Column<bool>(type: "bit", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patient_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
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
                    ServiceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Appointment_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID");
                    table.ForeignKey(
                        name: "FK_Appointment_Service_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fee = table.Column<int>(type: "int", nullable: true),
                    ServiceID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Invoice_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "PatientID");
                    table.ForeignKey(
                        name: "FK_Invoice_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Invoice_Service_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Exam",
                columns: new[] { "ExamId", "BloodPressure", "Complaint", "CorrectedAxis", "CorrectedCyliner", "CorrectedSphere", "ExamDay", "ExamMonth", "ExamTime", "ExamYear", "EyeDrops", "GlaucomaFamilyHistory", "HasGlaucoma", "HistoryOfCancer", "HistoryOfCataracts", "HistoryOfDiabetes", "HistoryOfHIV", "HistoryOfHeartProblems", "HistoryOfKidneyDisease", "HistoryOfMacularDegeneration", "HistoryOfNeuromuscularDisease", "HistoryOfRetinalDetachment", "HistoryOfStroke", "HistoryOfThyroid", "HistoryOfTuberculosis", "LifeStage", "Sex", "UncorrectedAxis", "UncorrectedCyliner", "UncorrectedSphere" },
                values: new object[,]
                {
                    { 1, "Normal", "", "na", "na", "na", "1", "1", "11", "2011", "", "None", false, false, false, false, false, false, false, false, false, false, false, false, false, "Young adulthood", "Male", "na", "na", "0.00" },
                    { 2, "Normal", "", "na", "na", "na", "2", "2", "10:00AM", "2022", "", "None", false, false, false, false, false, false, false, false, false, false, false, false, false, "Young adulthood", "Male", "na", "na", "0.00" },
                    { 3, "Normal", "", "na", "na", "na", null, "3", "13:00", "2013", "", "None", false, false, false, false, false, false, false, false, false, false, false, false, false, "Young adulthood", "Male", "na", "na", "0.00" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "Fee", "Manufacturer", "ModelNumber", "Type" },
                values: new object[,]
                {
                    { 1, 100, "Ray Ban", "RB3558", "Sunglasses" },
                    { 2, 150, "Ray Ban", "RB3025", "Aviator Sunglasses" },
                    { 3, 120, "Ray Ban", "RB2140", "Wayfarer Sunglasses" }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Code", "Description", "Fee" },
                values: new object[,]
                {
                    { 1, "REE1", "Regular Eye Exam", 100 },
                    { 2, "GEE1", "Glaucoma Eye Exam", 200 },
                    { 3, "YEE1", "Regular Eye Exam 3", 300 }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "PatientID", "Address", "BirthDate", "City", "Email", "ExamId", "FirstName", "InvoiceId", "IsEditing", "IsSelected", "LastName", "MiddleName", "Occupation", "Phone", "PostalCode", "Province", "ProvincialHealthNumber" },
                values: new object[,]
                {
                    { 1, "123 Main st", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vancouver", "test@mail.com", 1, "Edmond", 1, false, false, "Chen", "Li", "test", "233132", "VA2 34B", "BC", "12345" },
                    { 2, "123 Test St", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richmond", "test@mail.com", 2, "Chris", 2, false, false, "Wu", "Yue", "test", "233132", "VA2 34B", "BC", "12345" },
                    { 3, "123 Minor st", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vancouver", "test@mail.com", 3, "Kris", 3, false, false, "Ocampo", "Li", "test", "233132", "VA2 34B", "BC", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "ID", "Day", "Month", "PatientID", "ServiceID", "Time", "Year" },
                values: new object[] { 1, "21", "1", 1, 1, "9:00", "2023" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "ID", "Day", "Fee", "Month", "PatientID", "ProductID", "ServiceID", "Year" },
                values: new object[,]
                {
                    { 2, "14", 100, "12", 1, null, 1, "2023" },
                    { 3, "14", 100, "12", 1, 1, null, "2023" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientID",
                table: "Appointment",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ServiceID",
                table: "Appointment",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_PatientID",
                table: "Invoice",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_ProductID",
                table: "Invoice",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_ServiceID",
                table: "Invoice",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_ExamId",
                table: "Patient",
                column: "ExamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Exam");
        }
    }
}
