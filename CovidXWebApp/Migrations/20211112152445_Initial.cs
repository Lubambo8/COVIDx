using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidXWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "LabUser",
                columns: table => new
                {
                    LabUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDnumber = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabUser", x => x.LabUserID);
                });

            migrationBuilder.CreateTable(
                name: "MedicalAidScheme",
                columns: table => new
                {
                    MedicalAidSchemeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalAidScheme", x => x.MedicalAidSchemeID);
                });

            migrationBuilder.CreateTable(
                name: "Nurse",
                columns: table => new
                {
                    NurseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDnumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SuburbID = table.Column<int>(type: "int", nullable: false),
                    YearsQualified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rank = table.Column<int>(type: "int", maxLength: 128, nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurse", x => x.NurseID);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Suburb",
                columns: table => new
                {
                    SuburbID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuburbName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suburb", x => x.SuburbID);
                    table.ForeignKey(
                        name: "FK_Suburb_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalAidPlan",
                columns: table => new
                {
                    MedicalAidPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MedicalAidSchemeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalAidPlan", x => x.MedicalAidPlanID);
                    table.ForeignKey(
                        name: "FK_MedicalAidPlan_MedicalAidScheme_MedicalAidSchemeID",
                        column: x => x.MedicalAidSchemeID,
                        principalTable: "MedicalAidScheme",
                        principalColumn: "MedicalAidSchemeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuburbsPreferred",
                columns: table => new
                {
                    SuburbID = table.Column<int>(type: "int", nullable: false),
                    NurseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuburbsPreferred", x => new { x.SuburbID, x.NurseID });
                    table.ForeignKey(
                        name: "FK_SuburbsPreferred_Nurse_NurseID",
                        column: x => x.NurseID,
                        principalTable: "Nurse",
                        principalColumn: "NurseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuburbsPreferred_Suburb_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburb",
                        principalColumn: "SuburbID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IDnumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    SuburbID = table.Column<int>(type: "int", nullable: false),
                    MedicalAidStatus = table.Column<bool>(type: "bit", nullable: false),
                    MedicalAidPlanID = table.Column<int>(type: "int", nullable: true),
                    MedicalAidNo = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DependencyCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonResponsible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patient_MedicalAidPlan_MedicalAidPlanID",
                        column: x => x.MedicalAidPlanID,
                        principalTable: "MedicalAidPlan",
                        principalColumn: "MedicalAidPlanID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_Suburb_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburb",
                        principalColumn: "SuburbID");
                });

            migrationBuilder.CreateTable(
                name: "Dependent",
                columns: table => new
                {
                    DependentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IDnumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    SuburbID = table.Column<int>(type: "int", nullable: true),
                    DateOfbirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalAidNo = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    MedicalAidPlanID = table.Column<int>(type: "int", nullable: true),
                    MedicalAidStatus = table.Column<bool>(type: "bit", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Relationship = table.Column<int>(type: "int", nullable: false),
                    DependencyCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    MainMemberID = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PersonResponsible = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependent", x => x.DependentID);
                    table.ForeignKey(
                        name: "FK_Dependent_MedicalAidPlan_MedicalAidPlanID",
                        column: x => x.MedicalAidPlanID,
                        principalTable: "MedicalAidPlan",
                        principalColumn: "MedicalAidPlanID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dependent_Patient_MainMemberID",
                        column: x => x.MainMemberID,
                        principalTable: "Patient",
                        principalColumn: "PatientID");
                    table.ForeignKey(
                        name: "FK_Dependent_Suburb_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburb",
                        principalColumn: "SuburbID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestRequest",
                columns: table => new
                {
                    TestRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestStatus = table.Column<int>(type: "int", maxLength: 128, nullable: false),
                    TestAddress1 = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    TestAddress2 = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SuburbID = table.Column<int>(type: "int", nullable: false),
                    NurseID = table.Column<int>(type: "int", nullable: true),
                    DateAssigned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DependentID = table.Column<int>(type: "int", nullable: true),
                    CalendarEventID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestRequest", x => x.TestRequestID);
                    table.ForeignKey(
                        name: "FK_TestRequest_Dependent_DependentID",
                        column: x => x.DependentID,
                        principalTable: "Dependent",
                        principalColumn: "DependentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestRequest_Nurse_NurseID",
                        column: x => x.NurseID,
                        principalTable: "Nurse",
                        principalColumn: "NurseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestRequest_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestRequest_Suburb_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburb",
                        principalColumn: "SuburbID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CalendarEvents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllDay = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarEvents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CalendarEvents_TestRequest_ID",
                        column: x => x.ID,
                        principalTable: "TestRequest",
                        principalColumn: "TestRequestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NurseSchedule",
                columns: table => new
                {
                    TestRequestID = table.Column<int>(type: "int", nullable: false),
                    NurseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NurseSchedule", x => new { x.NurseID, x.TestRequestID });
                    table.ForeignKey(
                        name: "FK_NurseSchedule_Nurse_NurseID",
                        column: x => x.NurseID,
                        principalTable: "Nurse",
                        principalColumn: "NurseID");
                    table.ForeignKey(
                        name: "FK_NurseSchedule_TestRequest_TestRequestID",
                        column: x => x.TestRequestID,
                        principalTable: "TestRequest",
                        principalColumn: "TestRequestID");
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Temperature = table.Column<double>(type: "float", maxLength: 128, nullable: false),
                    BloodPressure = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OxygenLevel = table.Column<int>(type: "int", maxLength: 128, nullable: false),
                    TestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestResult = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ResultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LabUserID = table.Column<int>(type: "int", nullable: true),
                    TestRequestID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_Test_LabUser_LabUserID",
                        column: x => x.LabUserID,
                        principalTable: "LabUser",
                        principalColumn: "LabUserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Test_TestRequest_TestRequestID",
                        column: x => x.TestRequestID,
                        principalTable: "TestRequest",
                        principalColumn: "TestRequestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 1, "Gqeberha" });

            migrationBuilder.InsertData(
                table: "LabUser",
                columns: new[] { "LabUserID", "EmailAddress", "FirstName", "Gender", "IDnumber", "LastName", "MobileNumber", "Qualification" },
                values: new object[] { 1, "mandla@gmail.com", "Mandla", 1, "79052520225083", "Khumalo", "0912458796", "Pharmacist" });

            migrationBuilder.InsertData(
                table: "MedicalAidScheme",
                columns: new[] { "MedicalAidSchemeID", "Description" },
                values: new object[,]
                {
                    { 1, "BestMed" },
                    { 2, "Bonitas" },
                    { 3, "Discovery Health" }
                });

            migrationBuilder.InsertData(
                table: "Nurse",
                columns: new[] { "NurseID", "AddressLine1", "AddressLine2", "EmailAddress", "FirstName", "Gender", "IDnumber", "LastName", "MobileNumber", "Rank", "SuburbID", "UserID", "YearsQualified" },
                values: new object[,]
                {
                    { 1, "10th Avenue", null, "dorothy@gmail.com", "Dorothy", 0, "7503180225083", "Daniels", "0512458796", 2, 126, "b4781a1d-7286-4d10-981c-bb54e987d4b0", new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "64 Barbert street", null, "lindile@gmail.com", "Lindile", 0, "7603180225083", "Hadebe", "0522458796", 3, 73, "c6370b10-526e-4d63-8648-8bb17b3613bd", new DateTime(1997, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "13 Gutch Road", null, "marcel@gmail.com", "Marcel", 0, "7703180225083", "Van Niekerk", "0532458796", 0, 43, "a911d5f1-734a-415d-93ae-19c6c74320d3", new DateTime(2003, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MedicalAidPlan",
                columns: new[] { "MedicalAidPlanID", "Description", "MedicalAidSchemeID" },
                values: new object[,]
                {
                    { 47, "Keycare Core", 3 },
                    { 20, "BonFitComprehensive", 2 },
                    { 19, "BonClassic", 2 },
                    { 18, "BonComplete", 2 },
                    { 17, "BonSave", 2 },
                    { 16, "BonFit Select", 2 },
                    { 15, "Standard Select", 2 },
                    { 14, "Standard", 2 },
                    { 13, "Primary Select", 2 },
                    { 12, "Primary", 2 },
                    { 21, "Hospital Standard", 2 },
                    { 11, "BonStart", 2 },
                    { 9, "Pace 3", 1 },
                    { 8, "Pace 2", 1 },
                    { 7, "Pace 1", 1 },
                    { 6, "Pulse 2", 1 },
                    { 5, "Pulse 1", 1 },
                    { 4, "Beat 4", 1 },
                    { 3, "Beat 3", 1 },
                    { 2, "Beat 2", 1 },
                    { 1, "Beat 1", 1 },
                    { 10, "Pace 4", 1 },
                    { 22, "BonEssential", 2 },
                    { 46, "Keycare Smart", 3 },
                    { 24, "BonCap", 2 },
                    { 23, "BonEssentialSelect", 2 },
                    { 45, "Keycare Plus", 3 },
                    { 44, "Coastal Core", 3 },
                    { 43, "Essential Delta Core", 3 },
                    { 42, "Essential Core", 3 },
                    { 41, "Classic Delta Core", 3 },
                    { 39, "Essential Smart", 3 },
                    { 38, "Classic Smart", 3 },
                    { 37, "Coastal Saver", 3 },
                    { 36, "Essential Delta Saver", 3 },
                    { 40, "Classic Core", 3 },
                    { 34, "Classic Delta Saver", 3 },
                    { 33, "Classic Saver", 3 },
                    { 32, "Essential Priority", 3 },
                    { 31, "Classic Priority", 3 },
                    { 25, "Executive", 3 },
                    { 30, "Essential Data", 3 }
                });

            migrationBuilder.InsertData(
                table: "MedicalAidPlan",
                columns: new[] { "MedicalAidPlanID", "Description", "MedicalAidSchemeID" },
                values: new object[,]
                {
                    { 29, "Essential Comprehensive", 3 },
                    { 28, "Classic Smart Comprehensive", 3 },
                    { 27, "Classic Data Comprehensive", 3 },
                    { 26, "Classic Comprehensive", 3 },
                    { 35, "Essential Saver", 3 }
                });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "SuburbID", "CityID", "PostalCode", "SuburbName" },
                values: new object[,]
                {
                    { 113, 1, "6059", "Saltville" },
                    { 114, 1, "6059", "Sanctor" },
                    { 115, 1, "6020", "Schauderville" },
                    { 120, 1, "6020", "Springdale" },
                    { 117, 1, "6025", "Sherwood" },
                    { 118, 1, "6001", "Sidwell" },
                    { 119, 1, "6001", "South End" },
                    { 112, 1, "6059", "Salt Lake" },
                    { 116, 1, "6070", "Sea View" },
                    { 111, 1, "6059", "Salsoneville" },
                    { 100, 1, "6001", "Parsons Hill" },
                    { 109, 1, "6001", "Rufanevale" },
                    { 108, 1, "6025", "Rowallan Park" },
                    { 107, 1, "6001", "Richmond Park" },
                    { 106, 1, "6001", "Richmond Hill" },
                    { 105, 1, "6001", "Retiefville" },
                    { 104, 1, "6201", "Redhouse" },
                    { 103, 1, "6070", "Providentia" },
                    { 102, 1, "6070", "Pinegrove" },
                    { 101, 1, "6001", "Perridgevale" },
                    { 121, 1, "6070", "Springfield" },
                    { 99, 1, "6025", "Parsons Vlei" },
                    { 110, 1, "6070", "Salisbury Park" },
                    { 122, 1, "6001", "ST Georges" },
                    { 133, 1, "6059", "Timothy Valley" },
                    { 124, 1, "6001", "Steytler" },
                    { 147, 1, "6201", "Zwide" },
                    { 146, 1, "6001", "Young Park" },
                    { 98, 1, "6020", "Parkside" },
                    { 144, 1, "6070", "Woodlands" },
                    { 143, 1, "6070", "Weybridge Park" },
                    { 142, 1, "6045", "Westview" },
                    { 141, 1, "6025", "Westering" },
                    { 140, 1, "6211", "Wells Estate" },
                    { 139, 1, "6070", "Walmer Heights" },
                    { 138, 1, "6070", "Walmer Downs" },
                    { 123, 1, "6045", "Stella Londt Park" }
                });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "SuburbID", "CityID", "PostalCode", "SuburbName" },
                values: new object[,]
                {
                    { 137, 1, "6070", "Walmer" },
                    { 135, 1, "6070", "Trevolen" },
                    { 134, 1, "6025", "Treehaven" },
                    { 132, 1, "6070", "Theescombe" },
                    { 131, 1, "6025", "Taybank" },
                    { 130, 1, "6001", "Sydenham" },
                    { 129, 1, "6210", "Swartkops" },
                    { 128, 1, "6045", "Sunridge Park" },
                    { 127, 1, "6001", "Summerwood" },
                    { 126, 1, "6001", "Summerstrand" },
                    { 125, 1, "6001", "Struandale" },
                    { 136, 1, "6025", "Vikingvale" },
                    { 145, 1, "6020", "Woolhope" },
                    { 97, 1, "6001", "Park Drive" },
                    { 95, 1, "6059", "Palm Ridge" },
                    { 26, 1, "6045", "Cotswold" },
                    { 27, 1, "6001", "Cradock Place" },
                    { 28, 1, "6001", "Cradockplek" },
                    { 29, 1, "6001", "Craigbain" },
                    { 30, 1, "6025", "Crestview" },
                    { 31, 1, "6059", "Dowerville" },
                    { 32, 1, "6070", "Emerald Hill" },
                    { 33, 1, "6070", "Essexvale" },
                    { 34, 1, "6070", "Fairview" },
                    { 25, 1, "6001", "Collen Glen" },
                    { 35, 1, "6045", "Ferguson" },
                    { 37, 1, "6059", "Fernwood Park" },
                    { 38, 1, "6001", "Forest Hill" },
                    { 39, 1, "6045", "Framesby" },
                    { 40, 1, "6045", "Francis Evatt Park" },
                    { 41, 1, "6025", "Gambleville" },
                    { 42, 1, "6020", "Gelvan Park" },
                    { 43, 1, "6020", "Gelvandale" },
                    { 44, 1, "6045", "Glen Hurd" },
                    { 45, 1, "6025", "Glen Kamma" },
                    { 36, 1, "6045", "Fernglen" },
                    { 46, 1, "6001", "Gledinningvale" },
                    { 24, 1, "6059", "Cleary Park" },
                    { 22, 1, "6070", "Charlo" },
                    { 2, 1, "6001", "Algoa Park" },
                    { 3, 1, "6059", "Arcadia" },
                    { 4, 1, "6059", "Aspen Heights" }
                });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "SuburbID", "CityID", "PostalCode", "SuburbName" },
                values: new object[,]
                {
                    { 5, 1, "6025", "Ben Kamma" },
                    { 6, 1, "6059", "Bethelsdorp" },
                    { 7, 1, "6070", "Beverly Grove" },
                    { 8, 1, "6020", "Beverly Hills" },
                    { 9, 1, "6059", "Bloemendal" },
                    { 10, 1, "6210", "Bluewater BAY" },
                    { 23, 1, "6059", "Chatty" },
                    { 11, 1, "6200", "Boast Village" },
                    { 13, 1, "6025", "Bramhope" },
                    { 14, 1, "6025", "Brentwood Park" },
                    { 15, 1, "6025", "Bridgemead" },
                    { 16, 1, "6070", "Broadwood" },
                    { 17, 1, "6025", "Brymore" },
                    { 18, 1, "6001", "Cadles" },
                    { 19, 1, "6001", "Castle Hill" },
                    { 20, 1, "6001", "Centralhil" },
                    { 21, 1, "6001", "Central" },
                    { 12, 1, "6059", "Booysens Park" },
                    { 47, 1, "6025", "Glenroy Park" },
                    { 48, 1, "6070", "Goldwater" },
                    { 49, 1, "6045", "Greenacres" },
                    { 75, 1, "6070", "Lovemore Heights" },
                    { 76, 1, "6070", "Lovemore Park" },
                    { 77, 1, "6001", "Macleanville" },
                    { 78, 1, "6020", "Malabar" },
                    { 79, 1, "6070", "Mangold Park" },
                    { 80, 1, "6200", "Mcnamee Village" },
                    { 81, 1, "6001", "Mill Park" },
                    { 82, 1, "6001", "Millard Grange" },
                    { 83, 1, "6070", "Miramar" },
                    { 74, 1, "6070", "Lorraine Manor" },
                    { 84, 1, "6059", "Missionvale" },
                    { 86, 1, "6025", "Morningside" },
                    { 87, 1, "6001", "Motherwell" },
                    { 88, 1, "6001", "Mount Croix" },
                    { 89, 1, "6070", "Mount Pleasant" },
                    { 90, 1, "6001", "Neave" },
                    { 91, 1, "6200", "New Brighton" },
                    { 92, 1, "6045", "Newton Park" },
                    { 93, 1, "6059", "Normanville" },
                    { 94, 1, "6001", "North End" },
                    { 85, 1, "6025", "Moregrove" }
                });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "SuburbID", "CityID", "PostalCode", "SuburbName" },
                values: new object[,]
                {
                    { 73, 1, "6070", "Lorraine" },
                    { 72, 1, "6001", "Listerwood" },
                    { 71, 1, "6025", "Linton Grange" },
                    { 50, 1, "6001", "Greenbushes" },
                    { 51, 1, "6070", "Greenshields Park" },
                    { 52, 1, "6059", "Heath Park" },
                    { 53, 1, "6020", "Helenvale" },
                    { 54, 1, "6059", "Hillside" },
                    { 55, 1, "6001", "Holland Park" },
                    { 56, 1, "6001", "Humerail" },
                    { 57, 1, "6001", "Humewood" },
                    { 58, 1, "6025", "Hunters Retreat" },
                    { 59, 1, "6025", "Kabega" },
                    { 60, 1, "6070", "Kamma Creek" },
                    { 61, 1, "6070", "Kamma Park" },
                    { 62, 1, "6025", "Kamma Ridge" },
                    { 63, 1, "6211", "Kamvelihle" },
                    { 64, 1, "6001", "Kemsley Park" },
                    { 65, 1, "6001", "Kensington" },
                    { 66, 1, "6020", "Korsten" },
                    { 67, 1, "6025", "Kunene Park" },
                    { 68, 1, "6200", "Kwaford" },
                    { 69, 1, "6205", "Kwazakhele" },
                    { 70, 1, "6001", "Linkside" },
                    { 96, 1, "6070", "Pari Park" },
                    { 1, 1, "6001", "Adcock Vale" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "PatientID", "AddressLine1", "AddressLine2", "DateOfBirth", "DependencyCode", "EmailAddress", "FirstName", "Gender", "IDnumber", "LastName", "MedicalAidNo", "MedicalAidPlanID", "MedicalAidStatus", "MobileNumber", "PersonResponsible", "SuburbID", "UserID" },
                values: new object[,]
                {
                    { 3, "1 Harbor Cottages", "Sayre Crescent", new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "David", 1, "8002200225083", "Greeff", null, null, false, "0712458796", "David Greeff", 56, "586aeb11-f69c-435a-a066-77a5a03ccf84" },
                    { 1, "19 Admirality Way", null, new DateTime(1955, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "00", null, "Charmaine", 0, "5503180225083", "Meintjies", "285465885", 8, true, "0832458796", "Charmaine Meintjies", 126, "62b19f4b-ed00-43c9-a7e4-10544e4c3cb9" },
                    { 12, "45 Columbia Crescent", null, new DateTime(1991, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "00", null, "Pulane", 0, "9110120225083", "Masemola", "465465885", 1, true, "0642458796", "Pulane Masemola", 84, "2f2e6869-4071-42d0-bc81-ed037c099a17" },
                    { 6, "28 7th Avenue", null, new DateTime(1975, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Felicity", 0, "7512020225083", "Daniels", null, null, false, "0612458796", "Felicity Daniels", 127, "993ab159-92db-4e13-9096-92d0f3e7ba72" },
                    { 2, "24 7th Avenue", null, new DateTime(1980, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jacob", 1, "8012010225083", "Moloi", null, null, false, "0822458796", "Jacob Moloi", 127, "f3241b84-940c-45fa-8a71-dda57cefe4a6" },
                    { 8, "12 Marshall Road", null, new DateTime(1964, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "00", null, "Alyce", 0, "6412120225083", "Morapedi", "395465885", 17, true, "0632458796", "Alyce Morapedi", 57, "87f902a7-a258-41a4-abe0-fff895624838" },
                    { 5, "6 Rubin Crescent", null, new DateTime(1985, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Karien", 0, "8509020225083", "Momberg", null, null, false, "0732458796", "Karien Momberg", 126, "9a6a06d9-002f-4bba-a2d3-8c88db78655f" },
                    { 10, "29 Peace Street", null, new DateTime(1950, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Carlos", 1, "5008100225083", "Perestrelo", null, null, false, "0842458796", "Carlos Perestrelo", 84, "ca99bbf8-a011-4d23-87af-86659e6c75c2" },
                    { 4, "27 Aspen Complex", "La Roche Drive", new DateTime(1976, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kopano", 1, "7606030225083", "Sithole", null, null, false, "0722458796", "Kopano Sithole", 57, "9e1cabd8-4db3-4c4d-97bb-ce87b049dae9" },
                    { 7, "37 The Beaches", "Beach Road", new DateTime(1960, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Errol", 1, "6008090225083", "Pieterse", null, null, false, "0612458796", "Errol Pieterse", 56, "153a5791-0955-4753-8b56-ca6e352f2c4d" },
                    { 11, "7 Jacks Road", null, new DateTime(1971, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kabelo", 1, "7112150225083", "Padi", null, null, false, "0742458796", "Kabelo Padi", 84, "89d4c9c1-0b46-4440-bbef-591aa8e33810" },
                    { 9, "13 Congo Avenue", null, new DateTime(1983, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "00", null, "Asha", 0, "8302090225083", "Sharma", "175465885", 44, true, "0812458796", "Asha Sharma", 84, "d1b8b348-0630-40ae-ba96-0327d46f3ef3" }
                });

            migrationBuilder.InsertData(
                table: "SuburbsPreferred",
                columns: new[] { "NurseID", "SuburbID" },
                values: new object[,]
                {
                    { 15, 91 },
                    { 1, 126 },
                    { 1, 57 },
                    { 1, 127 },
                    { 1, 56 }
                });

            migrationBuilder.InsertData(
                table: "Dependent",
                columns: new[] { "DependentID", "AddressLine1", "AddressLine2", "DateOfbirth", "DependencyCode", "EmailAddress", "FirstName", "Gender", "IDnumber", "LastName", "MainMemberID", "MedicalAidNo", "MedicalAidPlanID", "MedicalAidStatus", "MobileNumber", "PersonResponsible", "Relationship", "SuburbID" },
                values: new object[,]
                {
                    { 96, "24 7th Avenue", null, new DateTime(2011, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jacob@gmail.com", "Thabo", 1, "1107090225083", "Moloi", 2, null, null, false, "0822458796", "Jacob Moloi", 0, 127 },
                    { 94, "19 Admirality Way", null, new DateTime(1953, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charmaine@gmail.com", "Daniel", 1, "5309130225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 7, 126 },
                    { 93, "19 Admirality Way", null, new DateTime(2016, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charmaine@gmail.com", "Vanessa", 0, "1607070225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 9, 126 },
                    { 92, "19 Admirality Way", null, new DateTime(2012, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charmaine@gmail.com", "Vince", 1, "1205050225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 9, 126 },
                    { 91, "19 Admirality Way", null, new DateTime(1980, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "daleen@gmail.com", "Daleene", 0, "8009160225083", "Meintjies", 1, "285465885", 8, true, "0832458796", "Charmaine Meintjies", 8, 126 },
                    { 95, "24 7th Avenue", null, new DateTime(1983, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "lesedi@gmail.com", "Lesedi", 0, "8307070225083", "Moloi", 2, null, null, false, "0772458796", "Jacob Moloi", 2, 127 }
                });

            migrationBuilder.InsertData(
                table: "TestRequest",
                columns: new[] { "TestRequestID", "CalendarEventID", "DateAssigned", "DependentID", "EndTime", "NurseID", "PatientId", "RequestDate", "RequestStatus", "StartTime", "SuburbID", "TestAddress1", "TestAddress2" },
                values: new object[,]
                {
                    { 26, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 15, 8, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 57, "12 Marshall Road", null },
                    { 11, null, null, null, null, null, 8, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 57, "12 Marshall Road", null },
                    { 16, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 1, 1, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 30, null, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 12, new DateTime(2021, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 84, "45 Columbia Crescent", null },
                    { 15, null, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, 12, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 84, "45 Columbia Crescent", null },
                    { 24, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 6, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 127, "28 7th Avenue", null },
                    { 9, null, null, null, null, null, 6, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 127, "28 7th Avenue", null },
                    { 6, 6, new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 56, "1 Harbor Cottages", "Sayre Crescent" },
                    { 23, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "6 Rubin Crescent", null },
                    { 8, null, null, null, null, null, 5, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 126, "6 Rubin Crescent", null },
                    { 29, null, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 11, new DateTime(2021, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 84, "7 Jacks Road", null },
                    { 14, null, null, null, null, null, 11, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "7 Jacks Road", null },
                    { 28, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 15, 10, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 84, "29 Peace Street", null },
                    { 13, null, null, null, null, null, 10, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "29 Peace Street", null },
                    { 22, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 57, "27 Aspen Complex", "La Roche Drive" },
                    { 7, null, null, null, null, null, 4, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 57, "27 Aspen Complex", "La Roche Drive" },
                    { 25, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 15, 7, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 56, "37 The Beaches", "Beach Road" },
                    { 10, null, null, null, null, null, 7, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 56, "37 The Beaches", "Beach Road" },
                    { 21, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 15, 3, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 56, "1 Harbor Cottages", "Sayre Crescent" },
                    { 12, null, null, null, null, null, 9, new DateTime(2021, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 84, "13 Congo Avenue", null },
                    { 27, null, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 15, 9, new DateTime(2021, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 84, "13 Congo Avenue", null }
                });

            migrationBuilder.InsertData(
                table: "CalendarEvents",
                columns: new[] { "ID", "AllDay", "Description", "End", "Start", "Title" },
                values: new object[,]
                {
                    { 6, false, "1 Harbor Cottages Humerail", new DateTime(2021, 11, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), "1 Harbor Cottages" },
                    { 1, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" }
                });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "TestID", "BarCode", "BloodPressure", "LabUserID", "OxygenLevel", "ResultDate", "Temperature", "TestDate", "TestRequestID", "TestResult", "TestTime" },
                values: new object[,]
                {
                    { 1, "PENDCCOV-001", "124/79", 1, 95, new DateTime(2021, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 37.5, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Positive", new DateTime(2021, 2, 1, 10, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "PENDCCOV-0011", "124/79", 1, 91, new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), 37.200000000000003, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Positive", new DateTime(2021, 2, 13, 13, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "PENDCCOV-0015", "124/79", 1, 94, new DateTime(2021, 3, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 38.5, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Positive", new DateTime(2021, 2, 28, 14, 41, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "PENDCCOV-009", "124/79", 1, 93, new DateTime(2021, 2, 15, 8, 19, 0, 0, DateTimeKind.Unspecified), 38.100000000000001, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Positive", new DateTime(2021, 2, 13, 11, 1, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "PENDCCOV-0012", "120/80", 1, 99, new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), 34.200000000000003, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Negative", new DateTime(2021, 2, 13, 13, 29, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "PENDCCOV-0014", "120/80", 1, 93, new DateTime(2021, 3, 1, 7, 12, 0, 0, DateTimeKind.Unspecified), 37.899999999999999, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Positive", new DateTime(2021, 2, 28, 14, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "PENDCCOV-0013", "124/79", 1, 92, new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), 38.200000000000003, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Positive", new DateTime(2021, 2, 13, 13, 46, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "PENDCCOV-007", "124/79", 1, 92, new DateTime(2021, 2, 15, 8, 12, 0, 0, DateTimeKind.Unspecified), 36.899999999999999, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Positive", new DateTime(2021, 2, 13, 10, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "PENDCCOV-0010", "120/80", 1, 100, new DateTime(2021, 2, 15, 9, 17, 0, 0, DateTimeKind.Unspecified), 34.5, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Negative", new DateTime(2021, 2, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "PENDCCOV-006", "120/80", 1, 100, new DateTime(2021, 2, 15, 9, 12, 0, 0, DateTimeKind.Unspecified), 35.100000000000001, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Negative", new DateTime(2021, 2, 13, 12, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "PENDCCOV-008", "120/80", 1, 91, new DateTime(2021, 2, 15, 8, 12, 0, 0, DateTimeKind.Unspecified), 37.399999999999999, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Positive", new DateTime(2021, 2, 13, 10, 37, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TestRequest",
                columns: new[] { "TestRequestID", "CalendarEventID", "DateAssigned", "DependentID", "EndTime", "NurseID", "PatientId", "RequestDate", "RequestStatus", "StartTime", "SuburbID", "TestAddress1", "TestAddress2" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 3, 3, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 18, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 4, 4, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 19, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 5, 5, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 20, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null },
                    { 17, null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, new DateTime(2021, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 126, "19 Admirality Way", null }
                });

            migrationBuilder.InsertData(
                table: "CalendarEvents",
                columns: new[] { "ID", "AllDay", "Description", "End", "Start", "Title" },
                values: new object[,]
                {
                    { 2, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 3, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 4, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" },
                    { 5, false, "19 Admirality Way Summerstrand", new DateTime(2021, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "19 Admirality Way" }
                });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "TestID", "BarCode", "BloodPressure", "LabUserID", "OxygenLevel", "ResultDate", "Temperature", "TestDate", "TestRequestID", "TestResult", "TestTime" },
                values: new object[,]
                {
                    { 2, "PENDCCOV-002", "120/80", 1, 97, new DateTime(2021, 2, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), 38.200000000000003, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Positive", new DateTime(2021, 2, 1, 10, 35, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "PENDCCOV-003", "124/79", 1, 99, new DateTime(2021, 2, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), 34.600000000000001, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Negative", new DateTime(2021, 2, 1, 10, 48, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "PENDCCOV-004", "120/80", 1, 99, new DateTime(2021, 2, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), 35.799999999999997, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Negative", new DateTime(2021, 2, 1, 11, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "PENDCCOV-005", "124/79", 1, 90, new DateTime(2021, 2, 3, 8, 12, 0, 0, DateTimeKind.Unspecified), 37.899999999999999, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Positive", new DateTime(2021, 2, 1, 11, 29, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_MainMemberID",
                table: "Dependent",
                column: "MainMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_MedicalAidPlanID",
                table: "Dependent",
                column: "MedicalAidPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_SuburbID",
                table: "Dependent",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalAidPlan_MedicalAidSchemeID",
                table: "MedicalAidPlan",
                column: "MedicalAidSchemeID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseSchedule_TestRequestID",
                table: "NurseSchedule",
                column: "TestRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_MedicalAidPlanID",
                table: "Patient",
                column: "MedicalAidPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_SuburbID",
                table: "Patient",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_Suburb_CityID",
                table: "Suburb",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_SuburbsPreferred_NurseID",
                table: "SuburbsPreferred",
                column: "NurseID");

            migrationBuilder.CreateIndex(
                name: "IX_Test_LabUserID",
                table: "Test",
                column: "LabUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Test_TestRequestID",
                table: "Test",
                column: "TestRequestID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestRequest_DependentID",
                table: "TestRequest",
                column: "DependentID");

            migrationBuilder.CreateIndex(
                name: "IX_TestRequest_NurseID",
                table: "TestRequest",
                column: "NurseID");

            migrationBuilder.CreateIndex(
                name: "IX_TestRequest_PatientId",
                table: "TestRequest",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TestRequest_SuburbID",
                table: "TestRequest",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalendarEvents");

            migrationBuilder.DropTable(
                name: "NurseSchedule");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SuburbsPreferred");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "LabUser");

            migrationBuilder.DropTable(
                name: "TestRequest");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Dependent");

            migrationBuilder.DropTable(
                name: "Nurse");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "MedicalAidPlan");

            migrationBuilder.DropTable(
                name: "Suburb");

            migrationBuilder.DropTable(
                name: "MedicalAidScheme");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
