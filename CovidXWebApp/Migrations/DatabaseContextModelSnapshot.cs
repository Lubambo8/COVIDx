﻿// <auto-generated />
using System;
using EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CovidXWebApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.EFCoreConfigurationMethods.EFCoreIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EFCore.Model.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("CityId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("EFCore.Model.Dependent", b =>
                {
                    b.Property<int>("DependentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("DateOfbirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DependencyCode")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IDnumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("MainMemberID")
                        .HasColumnType("int");

                    b.Property<int?>("MedicalAidPlanID")
                        .HasColumnType("int");

                    b.Property<bool>("MedicalAidStatus")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Relationship")
                        .HasColumnType("int");

                    b.Property<int>("SuburbID")
                        .HasColumnType("int");

                    b.HasKey("DependentID");

                    b.HasIndex("MainMemberID");

                    b.HasIndex("MedicalAidPlanID");

                    b.HasIndex("SuburbID");

                    b.ToTable("Dependent");
                });

            modelBuilder.Entity("EFCore.Model.LabUser", b =>
                {
                    b.Property<int>("LabUserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IDnumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("LabUserID");

                    b.ToTable("LabUser");
                });

            modelBuilder.Entity("EFCore.Model.MedicalAidPlan", b =>
                {
                    b.Property<int>("MedicalAidPlanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("MedicalAidSchemeID")
                        .HasColumnType("int");

                    b.HasKey("MedicalAidPlanID");

                    b.HasIndex("MedicalAidSchemeID");

                    b.ToTable("MedicalAidPlan");
                });

            modelBuilder.Entity("EFCore.Model.MedicalAidScheme", b =>
                {
                    b.Property<int>("MedicalAidSchemeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("MedicalAidSchemeID");

                    b.ToTable("MedicalAidScheme");
                });

            modelBuilder.Entity("EFCore.Model.Nurse", b =>
                {
                    b.Property<int>("NurseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IDnumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("YearsQualified")
                        .HasColumnType("datetime2");

                    b.HasKey("NurseID");

                    b.HasIndex("UserID");

                    b.ToTable("Nurse");
                });

            modelBuilder.Entity("EFCore.Model.NurseSchedule", b =>
                {
                    b.Property<int>("NurseID")
                        .HasColumnType("int");

                    b.Property<int>("TestRequestID")
                        .HasColumnType("int");

                    b.HasKey("NurseID", "TestRequestID");

                    b.ToTable("NurseSchedule");
                });

            modelBuilder.Entity("EFCore.Model.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DependencyCode")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IDnumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("MedicalAidNo")
                        .HasColumnType("int");

                    b.Property<int?>("MedicalAidPlanID")
                        .HasColumnType("int");

                    b.Property<bool>("MedicalAidStatus")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("SuburbID")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PatientID");

                    b.HasIndex("MedicalAidPlanID");

                    b.HasIndex("SuburbID");

                    b.HasIndex("UserID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("EFCore.Model.RequestHistory", b =>
                {
                    b.Property<int>("TestRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("OldRequestStatus")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("TestRequestID");

                    b.ToTable("RequestHistory");
                });

            modelBuilder.Entity("EFCore.Model.Suburb", b =>
                {
                    b.Property<int>("SuburbID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("SuburbName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("SuburbID");

                    b.HasIndex("CityID");

                    b.ToTable("Suburb");
                });

            modelBuilder.Entity("EFCore.Model.SuburbsPreferred", b =>
                {
                    b.Property<int>("SuburbID")
                        .HasColumnType("int");

                    b.Property<int>("NurseID")
                        .HasColumnType("int");

                    b.HasKey("SuburbID", "NurseID");

                    b.HasIndex("NurseID");

                    b.HasIndex("SuburbID")
                        .IsUnique();

                    b.ToTable("SuburbsPreferred");
                });

            modelBuilder.Entity("EFCore.Model.Test", b =>
                {
                    b.Property<int>("TestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("BloodPressure")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int?>("LabUserID")
                        .HasColumnType("int");

                    b.Property<string>("OxygenLevel")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("ResultDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Temperature")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("TestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TestRequestID")
                        .HasColumnType("int");

                    b.Property<string>("TestResult")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<TimeSpan>("TestTime")
                        .HasColumnType("time");

                    b.HasKey("TestID");

                    b.HasIndex("LabUserID");

                    b.HasIndex("TestRequestID")
                        .IsUnique();

                    b.ToTable("Test");
                });

            modelBuilder.Entity("EFCore.Model.TestRequest", b =>
                {
                    b.Property<int>("TestRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAssigned")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NurseID")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestStatus")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("SuburbID")
                        .HasColumnType("int");

                    b.Property<string>("TestAddress1")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("TestAddress2")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("TimeSlotAssigned")
                        .HasColumnType("datetime2");

                    b.HasKey("TestRequestID");

                    b.HasIndex("NurseID");

                    b.HasIndex("PatientId");

                    b.HasIndex("SuburbID");

                    b.ToTable("TestRequest");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("EFCore.Model.Dependent", b =>
                {
                    b.HasOne("EFCore.Model.Patient", "MainMember")
                        .WithMany("Dependents")
                        .HasForeignKey("MainMemberID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EFCore.Model.MedicalAidPlan", "MedicalAidPlan")
                        .WithMany("Dependents")
                        .HasForeignKey("MedicalAidPlanID");

                    b.HasOne("EFCore.Model.Suburb", "Suburb")
                        .WithMany("Dependents")
                        .HasForeignKey("SuburbID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainMember");

                    b.Navigation("MedicalAidPlan");

                    b.Navigation("Suburb");
                });

            modelBuilder.Entity("EFCore.Model.MedicalAidPlan", b =>
                {
                    b.HasOne("EFCore.Model.MedicalAidScheme", "MedicalAidScheme")
                        .WithMany("MedicalAidPlans")
                        .HasForeignKey("MedicalAidSchemeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalAidScheme");
                });

            modelBuilder.Entity("EFCore.Model.Nurse", b =>
                {
                    b.HasOne("EFCore.EFCoreConfigurationMethods.EFCoreIdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFCore.Model.NurseSchedule", b =>
                {
                    b.HasOne("EFCore.Model.Nurse", "Nurse")
                        .WithMany("NurseSchedules")
                        .HasForeignKey("NurseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nurse");
                });

            modelBuilder.Entity("EFCore.Model.Patient", b =>
                {
                    b.HasOne("EFCore.Model.MedicalAidPlan", "MedicalAidPlan")
                        .WithMany("Patients")
                        .HasForeignKey("MedicalAidPlanID");

                    b.HasOne("EFCore.Model.Suburb", "Suburb")
                        .WithMany("Patients")
                        .HasForeignKey("SuburbID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EFCore.EFCoreConfigurationMethods.EFCoreIdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalAidPlan");

                    b.Navigation("Suburb");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFCore.Model.Suburb", b =>
                {
                    b.HasOne("EFCore.Model.City", "City")
                        .WithMany("Suburbs")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("EFCore.Model.SuburbsPreferred", b =>
                {
                    b.HasOne("EFCore.Model.Nurse", "Nurse")
                        .WithMany("SuburbsPreferreds")
                        .HasForeignKey("NurseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.Model.Suburb", "Suburb")
                        .WithOne("SuburbsPreferred")
                        .HasForeignKey("EFCore.Model.SuburbsPreferred", "SuburbID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nurse");

                    b.Navigation("Suburb");
                });

            modelBuilder.Entity("EFCore.Model.Test", b =>
                {
                    b.HasOne("EFCore.Model.LabUser", "LabUser")
                        .WithMany("Tests")
                        .HasForeignKey("LabUserID");

                    b.HasOne("EFCore.Model.TestRequest", "TestRequest")
                        .WithOne("Test")
                        .HasForeignKey("EFCore.Model.Test", "TestRequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LabUser");

                    b.Navigation("TestRequest");
                });

            modelBuilder.Entity("EFCore.Model.TestRequest", b =>
                {
                    b.HasOne("EFCore.Model.Nurse", "Nurse")
                        .WithMany("TestRequests")
                        .HasForeignKey("NurseID");

                    b.HasOne("EFCore.Model.Patient", "Patient")
                        .WithMany("TestRequests")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.Model.Suburb", "Suburb")
                        .WithMany("TestRequests")
                        .HasForeignKey("SuburbID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Nurse");

                    b.Navigation("Patient");

                    b.Navigation("Suburb");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EFCore.EFCoreConfigurationMethods.EFCoreIdentityUser", null)
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EFCore.EFCoreConfigurationMethods.EFCoreIdentityUser", null)
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("EFCore.EFCoreConfigurationMethods.EFCoreIdentityUser", null)
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore.EFCoreConfigurationMethods.EFCoreIdentityUser", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("EFCore.Model.City", b =>
                {
                    b.Navigation("Suburbs");
                });

            modelBuilder.Entity("EFCore.Model.LabUser", b =>
                {
                    b.Navigation("Tests");
                });

            modelBuilder.Entity("EFCore.Model.MedicalAidPlan", b =>
                {
                    b.Navigation("Dependents");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("EFCore.Model.MedicalAidScheme", b =>
                {
                    b.Navigation("MedicalAidPlans");
                });

            modelBuilder.Entity("EFCore.Model.Nurse", b =>
                {
                    b.Navigation("NurseSchedules");

                    b.Navigation("SuburbsPreferreds");

                    b.Navigation("TestRequests");
                });

            modelBuilder.Entity("EFCore.Model.Patient", b =>
                {
                    b.Navigation("Dependents");

                    b.Navigation("TestRequests");
                });

            modelBuilder.Entity("EFCore.Model.Suburb", b =>
                {
                    b.Navigation("Dependents");

                    b.Navigation("Patients");

                    b.Navigation("SuburbsPreferred");

                    b.Navigation("TestRequests");
                });

            modelBuilder.Entity("EFCore.Model.TestRequest", b =>
                {
                    b.Navigation("Test");
                });
#pragma warning restore 612, 618
        }
    }
}
