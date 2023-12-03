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
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
<<<<<<< HEAD:VisionX/Data/Migrations/20231202202032_M1.cs
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    ClockIn = table.Column<TimeSpan>(type: "time", nullable: true),
                    ClockOut = table.Column<TimeSpan>(type: "time", nullable: true),
                    TotalHoursWorked = table.Column<TimeSpan>(type: "time", nullable: true)
=======
                    ClockIn = table.Column<TimeSpan>(type: "time", nullable: true),
                    ClockOut = table.Column<TimeSpan>(type: "time", nullable: true)
>>>>>>> 41f273205d5949464829b63f2867f76e417fd661:VisionX/Data/Migrations/20231203034143_M1.cs
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

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
                    UncorrectedODSphere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UncorrectedODCylinder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UncorrectedODAxis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UncorrectedOSSphere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UncorrectedOSCylinder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UncorrectedOSAxis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectedODSphere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectedODCylinder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectedODAxis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectedOSSphere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectedOSCylinder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectedOSAxis = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false)
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
                table: "Employee",
<<<<<<< HEAD:VisionX/Data/Migrations/20231202202032_M1.cs
                columns: new[] { "ID", "ClockIn", "ClockOut", "FirstName", "IsSelected", "LastName", "MiddleName", "TotalHoursWorked" },
                values: new object[] { 1, null, null, "Chris", false, "Wu", "Yue", new TimeSpan(0, 0, 0, 0, 0) });
=======
                columns: new[] { "ID", "ClockIn", "ClockOut", "FirstName", "LastName", "MiddleName" },
                values: new object[] { 1, null, null, "Chris", "Wu", "Yue" });
>>>>>>> 41f273205d5949464829b63f2867f76e417fd661:VisionX/Data/Migrations/20231203034143_M1.cs

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "PatientID", "Address", "BirthDate", "BloodPressure", "City", "Complaint", "CorrectedODAxis", "CorrectedODCylinder", "CorrectedODSphere", "CorrectedOSAxis", "CorrectedOSCylinder", "CorrectedOSSphere", "Email", "ExamDay", "ExamMonth", "ExamTime", "ExamYear", "EyeDrops", "FirstName", "GlaucomaHistory", "HasGlaucoma", "HistoryOfCancer", "HistoryOfCataracts", "HistoryOfDiabetes", "HistoryOfHIV", "HistoryOfHeartProblems", "HistoryOfKidneyDisease", "HistoryOfMacularDegeneration", "HistoryOfNeuromuscularDisease", "HistoryOfRetinalDetachment", "HistoryOfStroke", "HistoryOfThyroid", "HistoryOfTuberculosis", "IsEditing", "IsSelected", "LastName", "LifeStage", "MiddleName", "Occupation", "Phone", "PostalCode", "Province", "ProvincialHealthNumber", "Sex", "Symptoms", "UncorrectedODAxis", "UncorrectedODCylinder", "UncorrectedODSphere", "UncorrectedOSAxis", "UncorrectedOSCylinder", "UncorrectedOSSphere" },
                values: new object[,]
                {
                    { 1, "555 Q St", "2001-11-30", "Hypertensive Crisis", "Vancouver", "", "0", "0", "0", "0", "0", "0", "echen@my.bcit.ca", "1", "1", "11", "2011", "", "Edmond", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Chen", "Senior", "Li", "student", "604-567-8901", "VA2 34B", "BC", "9901234567", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 2, "666 R Ave", "1923-02-02", "Hypertensive Crisis", "Richmond", "", "0", "0", "0", "0", "0", "0", "cwu@my.bcit.ca", "1", "1", "11", "2011", "", "Chris", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Wu", "Senior", "Yue", "student", "778-678-9012", "VA2 34B", "BC", "9123456780", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 3, "666 R Ave", "1996-02-08", "High (stage 1)", "Vancouver", "", "0", "0", "0", "0", "0", "0", "kriso@my.bcit.ca", "1", "1", "11", "2011", "", "Kris", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Ocampo", "Young adulthood", "KO", "student", "236-789-0123", "VA2 34B", "BC", "9345678901", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 4, "777 S Ln", "1997-04-20", "Elevated", "Maple Ridge", "", "0", "0", "0", "0", "0", "0", "bcoilan@my.bcit.ca", "1", "1", "11", "2011", "", "Bradner", "Paternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Coilan", "Senior", "BC", "student", "250-890-1234", "VA2 34B", "BC", "9789012345", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 5, "456 B Ave", "1998-06-25", "High (stage 2)", "Surrey", "", "0", "0", "0", "0", "0", "0", "kenarc@my.bcit.ca", "1", "1", "11", "2011", "", "Kenar", "Paternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Crasto", "Adolescence", "KC", "student", "604-901-2345", "VA2 34B", "BC", "9901234567", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 6, "789 C Ln", "1999-08-11", "Normal", "New Westminister", "", "0", "0", "0", "0", "0", "0", "Keving@my.bcit.ca", "1", "1", "11", "2011", "", "Kevin", "Maternal parent", "No", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Guo", "Young adulthood", "KG", "student", "778-012-3456", "VA2 34B", "BC", "9123456789", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 7, "101 D Rd", "2000-10-19", "Hypertensive Crisis", "Richmond", "", "0", "0", "0", "0", "0", "0", "trevor@my.bcit.ca", "1", "1", "11", "2011", "", "Trevor", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Hong", "Senior", "TH", "student", "236-123-4567", "VA2 34B", "BC", "9345678901", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 8, "222 E St", "2001-12-24", "High (stage 2)", "Coquitlam", "", "0", "0", "0", "0", "0", "0", "Reynard@my.bcit.ca", "1", "1", "11", "2011", "", "Reynard", "Paternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Lo", "Infant", "RL", "student", "250-234-5678", "VA2 34B", "BC", "9567890123", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 9, "333 F Ave", "1996-02-02", "Elevated", "Vancouver", "", "0", "0", "0", "0", "0", "0", "james@my.bcit.ca", "1", "1", "11", "2014", "", "James", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Lum", "Toddler", "JL", "student", "604-345-6789", "VA2 34B", "BC", "9789012345", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 10, "444 G Ln", "1997-04-15", "Normal", "Vancouver", "", "0", "0", "0", "0", "0", "0", "traill@my.bcit.ca", "1", "1", "11", "2015", "", "Traill", "Maternal parent", "No", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Lyall", "Young adulthood", "TL", "student", "778-456-7890", "VA2 34B", "BC", "9901234567", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 11, "555 H Rd", "1998-06-20", "High (stage 1)", "Vancouver", "", "0", "0", "0", "0", "0", "0", "Miguel@my.bcit.ca", "1", "1", "11", "2011", "", "Miguel", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Magpoc", "Adolescence", "MM", "student", "236-567-8901", "VA2 34B", "BC", "9123456789", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 12, "666 I St", "1999-08-04", "Hypertensive Crisis", "Vancouver", "", "0", "0", "0", "0", "0", "0", "naz@my.bcit.ca", "1", "1", "11", "2011", "", "Sarvenaz", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Mehregan", "Senior", "SM", "student", "250-678-9012", "VA2 34B", "BC", "9345678901", "Female", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 13, "777 J Ave", "2000-10-11", "Hypertensive Crisis", "Vancouver", "", "0", "0", "0", "0", "0", "0", "anna@my.bcit.ca", "1", "1", "11", "2011", "", "Anna", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Yujeong", "Senior", "AY", "student", "604-789-0123", "VA2 34B", "BC", "9567890123", "Female", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 14, "888 K Ln", "2001-12-17", "Normal", "Vancouver", "", "0", "0", "0", "0", "0", "0", "nanak@my.bcit.ca", "1", "1", "11", "2021", "", "Nanakpreet", "Paternal parent", "No", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Singh", "Middle Adulthood", "NS", "student", "778-890-1234", "VA2 34B", "BC", "9789012345", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 15, "999 L Rd", "1996-02-23", "Hypertensive Crisis", "Vancouver", "", "0", "0", "0", "0", "0", "0", "sahil@my.bcit.ca", "1", "1", "11", "2019", "", "Sahil", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Rai", "Senior", "Class Rep", "student", "236-901-2345", "VA2 34B", "BC", "9901234567", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 16, "111 M St", "1997-05-07", "Normal", "Vancouver", "", "0", "0", "0", "0", "0", "0", "sam@bcit.ca", "1", "1", "11", "2020", "", "Samuel", "Maternal parent", "No", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Tjahjadi", "Adolescence", "Li", "student", "604-123-4567", "VA2 34B", "BC", "9123456789", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 17, "222 N Ave", "1998-05-22", "Hypertensive Crisis", "Vancouver", "", "0", "0", "0", "0", "0", "0", "shayan@my.bcit.ca", "1", "1", "11", "2014", "", "Shayan", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Zahedanaraki", "Senior", "Li", "student", "778-234-5678", "VA2 34B", "BC", "9345678901", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 18, "333 O Ln", "1966-07-07", "Hypertensive Crisis", "Vancouver", "", "0", "0", "0", "0", "0", "0", "medhat@bcit.ca", "1", "1", "11", "2011", "", "Medhat", "Maternal parent", "Yes", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Elmasry", "Young Adulthood", "Li", "student", "236-345-6789", "VA2 34B", "BC", "9567890123", "Male", null, "0", "0", "0.00", "0", "0", "0.00" },
                    { 19, "444 P Blvd", "1970-09-14", "Normal", "Vancouver", "", "0", "0", "0", "0", "0", "0", "mirela@bcit.ca", "1", "1", "11", "2011", "", "Mirela", "Maternal parent", "No", false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Gutica", "Young Adulthood", "Li", "instructor", "250-456-7890", "VA2 34B", "BC", "9789012345", "Female", null, "0", "0", "0.00", "0", "0", "0.00" }
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
                columns: new[] { "ID", "Day", "Fee", "IsPaid", "Month", "PatientID", "ProductID", "ServiceID", "Year" },
                values: new object[,]
                {
                    { 2, "14", 100, false, "12", 1, null, 1, "2023" },
                    { 3, "14", 100, false, "12", 1, 1, null, "2023" }
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
                name: "Employee");

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
