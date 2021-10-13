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
                    IDnumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    YearsQualified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurse", x => x.NurseID);
                    table.ForeignKey(
                        name: "FK_Nurse_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
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
                    MedicalAidNo = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DependencyCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Patient_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    DependencyCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MainMemberID = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
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
                    TimeSlotAssigned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DependentID = table.Column<int>(type: "int", nullable: true)
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
                name: "RequestHistory",
                columns: table => new
                {
                    RequestHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestRequestID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldRequestStatus = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestHistory", x => x.RequestHistoryID);
                    table.ForeignKey(
                        name: "FK_RequestHistory_TestRequest_TestRequestID",
                        column: x => x.TestRequestID,
                        principalTable: "TestRequest",
                        principalColumn: "TestRequestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    BloodPressure = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OxygenLevel = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestTime = table.Column<TimeSpan>(type: "time", nullable: false),
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
                values: new object[] { 101, "Port Elizabeth" });

            migrationBuilder.InsertData(
                table: "MedicalAidScheme",
                columns: new[] { "MedicalAidSchemeID", "Description" },
                values: new object[] { 101, "Discovery Health" });

            migrationBuilder.InsertData(
                table: "MedicalAidScheme",
                columns: new[] { "MedicalAidSchemeID", "Description" },
                values: new object[] { 102, "ProfMed" });

            migrationBuilder.InsertData(
                table: "MedicalAidPlan",
                columns: new[] { "MedicalAidPlanID", "Description", "MedicalAidSchemeID" },
                values: new object[,]
                {
                    { 110, "Premium Plan", 102 },
                    { 108, "Standard Plan", 102 },
                    { 107, "Key-care Plan", 102 },
                    { 106, "Smart Plan", 101 },
                    { 105, "Core Plan", 101 },
                    { 104, "Saver Plan", 101 },
                    { 103, "Priority Plan", 101 },
                    { 102, "Comprehensive Plan", 101 },
                    { 101, "Executive Plan", 101 },
                    { 109, "Family Plan", 102 }
                });

            migrationBuilder.InsertData(
                table: "Suburb",
                columns: new[] { "SuburbID", "CityID", "PostalCode", "SuburbName" },
                values: new object[,]
                {
                    { 110, 101, "6025", "Western Hills" },
                    { 108, 101, "6001", "North End" },
                    { 107, 101, "6070", "Lovemore Park" },
                    { 106, 101, "6011", "Schoenmakerskop" },
                    { 105, 101, "6001", "Forest Hill" },
                    { 104, 101, "6001", "South End" },
                    { 103, 101, "6013", "Humewood" },
                    { 102, 101, "6001", "Summerstrand" },
                    { 109, 101, "6020", "Korsten" },
                    { 101, 101, "6070", "Walmer" }
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
                name: "IX_Nurse_UserID",
                table: "Nurse",
                column: "UserID");

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
                name: "IX_Patient_UserID",
                table: "Patient",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestHistory_TestRequestID",
                table: "RequestHistory",
                column: "TestRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Suburb_CityID",
                table: "Suburb",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_SuburbsPreferred_NurseID",
                table: "SuburbsPreferred",
                column: "NurseID");

            migrationBuilder.CreateIndex(
                name: "IX_SuburbsPreferred_SuburbID",
                table: "SuburbsPreferred",
                column: "SuburbID",
                unique: true);

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
                name: "NurseSchedule");

            migrationBuilder.DropTable(
                name: "RequestHistory");

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "MedicalAidScheme");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
