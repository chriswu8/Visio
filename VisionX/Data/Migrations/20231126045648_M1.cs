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
                name: "Patient",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvincialHealthNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    IsEditing = table.Column<bool>(type: "bit", nullable: false),
                    ExamMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symptoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EyeDrops = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoryOfCancer = table.Column<bool>(type: "bit", nullable: true),
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
                    GlaucomaHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasGlaucoma = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientID);
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
                table: "Patient",
                columns: new[] { "PatientID", "Address", "BirthDate", "BloodPressure", "City", "Complaint", "CorrectedAxis", "CorrectedCyliner", "CorrectedSphere", "Email", "ExamDay", "ExamMonth", "ExamTime", "ExamYear", "EyeDrops", "FirstName", "GlaucomaHistory", "HasGlaucoma", "HistoryOfCancer", "HistoryOfCataracts", "HistoryOfDiabetes", "HistoryOfHIV", "HistoryOfHeartProblems", "HistoryOfKidneyDisease", "HistoryOfMacularDegeneration", "HistoryOfNeuromuscularDisease", "HistoryOfRetinalDetachment", "HistoryOfStroke", "HistoryOfThyroid", "HistoryOfTuberculosis", "IsEditing", "IsSelected", "LastName", "LifeStage", "MiddleName", "Occupation", "Phone", "PostalCode", "Province", "ProvincialHealthNumber", "Sex", "Symptoms", "UncorrectedAxis", "UncorrectedCyliner", "UncorrectedSphere" },
                values: new object[,]
                {
                    { 1, "123 Main st", "1923-01-01", "Hypertensive Crisis", "Vancouver", "", "na", "na", "na", "test@mail.com", "1", "1", "11", "2011", "", "Edmond", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Chen", "Senior", "Li", "test", "233132", "VA2 34B", "BC", "12345", "Female", null, "na", "na", "0.00" },
                    { 2, "123 Test St", "1923-02-02", "Hypertensive Crisis", "Richmond", "", "na", "na", "na", "test@mail.com", "1", "1", "11", "2011", "", "Chris", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Wu", "Senior", "Yue", "test", "233132", "VA2 34B", "BC", "12345", "Female", null, "na", "na", "0.00" },
                    { 3, "123 Minor st", "2000-03-03", "Hypertensive Crisis", "Vancouver", "", "na", "na", "na", "test@mail.com", "1", "1", "11", "2011", "", "Kris", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Ocampo", "Senior", "Li", "test", "233132", "VA2 34B", "BC", "12345", "Female", null, "na", "na", "0.00" }
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
        }
    }
}
