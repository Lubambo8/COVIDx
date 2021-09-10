using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCore
{
    public partial class CovidX_DBContext : DbContext
    {
        public CovidX_DBContext()
        {
        }

        public CovidX_DBContext(DbContextOptions<CovidX_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Dependent> Dependents { get; set; }
        public virtual DbSet<LabUser> LabUsers { get; set; }
        public virtual DbSet<MedicalAidPlan> MedicalAidPlans { get; set; }
        public virtual DbSet<MedicalAidScheme> MedicalAidSchemes { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<NurseSchedule> NurseSchedules { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Relationship> Relationships { get; set; }
        public virtual DbSet<RequestHistory> RequestHistories { get; set; }
        public virtual DbSet<Suburb> Suburbs { get; set; }
        public virtual DbSet<SuburbsPreferred> SuburbsPreferreds { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestRequest> TestRequests { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CovidX_DB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId)
                    .ValueGeneratedNever()
                    .HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Dependent>(entity =>
            {
                entity.ToTable("Dependent");

                entity.Property(e => e.DependentId)
                    .ValueGeneratedNever()
                    .HasColumnName("DependentID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.AddressLine2).HasMaxLength(128);

                entity.Property(e => e.DateOfbirth)
                    .HasColumnType("datetime")
                    .HasColumnName("DateOFBirth");

                entity.Property(e => e.DependencyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.MainMemberId).HasColumnName("MainMemberID");

                entity.Property(e => e.MedicalAidPlanId).HasColumnName("MedicalAidPlanID");

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.HasOne(d => d.MainMember)
                    .WithMany(p => p.Dependents)
                    .HasForeignKey(d => d.MainMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dependent_Patient");

                entity.HasOne(d => d.MedicalAidPlan)
                    .WithMany(p => p.Dependents)
                    .HasForeignKey(d => d.MedicalAidPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dependent_MedicalAidPlan");

                entity.HasOne(d => d.RelationshipType)
                    .WithMany(p => p.Dependents)
                    .HasForeignKey(d => d.RelationshipTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dependent_RelationshipType");

                entity.HasOne(d => d.Suburb)
                    .WithMany(p => p.Dependents)
                    .HasForeignKey(d => d.SuburbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dependent_Suburb");
            });

            modelBuilder.Entity<LabUser>(entity =>
            {
                entity.ToTable("LabUser");

                entity.Property(e => e.LabUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("LabUserID");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<MedicalAidPlan>(entity =>
            {
                entity.ToTable("MedicalAid_Plan");

                entity.Property(e => e.MedicalAidPlanId)
                    .ValueGeneratedNever()
                    .HasColumnName("MedicalAidPlanID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.MedicalAidSchemeId).HasColumnName("MedicalAidSchemeID");

                entity.HasOne(d => d.MedicalAidScheme)
                    .WithMany(p => p.MedicalAidPlans)
                    .HasForeignKey(d => d.MedicalAidSchemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalAid_Plan_MedicalAidScheme");
            });

            modelBuilder.Entity<MedicalAidScheme>(entity =>
            {
                entity.ToTable("MedicalAid_Scheme");

                entity.Property(e => e.MedicalAidSchemeId)
                    .ValueGeneratedNever()
                    .HasColumnName("MedicalAidSchemeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Nurse>(entity =>
            {
                entity.ToTable("Nurse");

                entity.Property(e => e.NurseId)
                    .ValueGeneratedNever()
                    .HasColumnName("NurseID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.AddressLine2).HasMaxLength(128);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearsQualified).HasColumnType("datetime");

                entity.HasOne(d => d.NurseNavigation)
                    .WithOne(p => p.Nurse)
                    .HasForeignKey<Nurse>(d => d.NurseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nurse_User");
            });

            modelBuilder.Entity<NurseSchedule>(entity =>
            {
                entity.HasKey(e => e.TestRequestId)
                    .HasName("PK__Nurse_Sc__5E3562E6499895F4");

                entity.ToTable("Nurse_Schedule");

                entity.Property(e => e.TestRequestId)
                    .ValueGeneratedNever()
                    .HasColumnName("TestRequestID");

                entity.Property(e => e.NurseId).HasColumnName("NurseID");

                entity.HasOne(d => d.Nurse)
                    .WithMany(p => p.NurseSchedules)
                    .HasForeignKey(d => d.NurseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nurse_Schedule_Nurse");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.PatientId)
                    .ValueGeneratedNever()
                    .HasColumnName("PatientID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.AddressLine2).HasMaxLength(128);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.MedicalAidPlanId).HasColumnName("MedicalAidPlanID");

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.HasOne(d => d.MedicalAidPlan)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.MedicalAidPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_MedicalAidPlan");

                entity.HasOne(d => d.PatientNavigation)
                    .WithOne(p => p.Patient)
                    .HasForeignKey<Patient>(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_User");

                entity.HasOne(d => d.Suburb)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.SuburbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Suburb");
            });

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipTypeId)
                    .HasName("PK__Relation__20FE5F61A98604E0");

                entity.ToTable("Relationship");

                entity.Property(e => e.RelationshipTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("RelationshipTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RequestHistory>(entity =>
            {
                entity.HasKey(e => e.TestRequestId)
                    .HasName("PK__Request___5E3562E6E1A2AEBE");

                entity.ToTable("Request_History");

                entity.Property(e => e.TestRequestId)
                    .ValueGeneratedNever()
                    .HasColumnName("TestRequestID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.OldRequestStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Suburb>(entity =>
            {
                entity.ToTable("Suburb");

                entity.Property(e => e.SuburbId)
                    .ValueGeneratedNever()
                    .HasColumnName("SuburbID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SuburbName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Suburbs)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suburb_City");
            });

            modelBuilder.Entity<SuburbsPreferred>(entity =>
            {
                entity.HasKey(e => e.SuburbId)
                    .HasName("PK__Suburbs___BB2E9AE12A4A89AF");

                entity.ToTable("Suburbs_Preferred");

                entity.Property(e => e.SuburbId)
                    .ValueGeneratedNever()
                    .HasColumnName("SuburbID");

                entity.Property(e => e.NurseId).HasColumnName("NurseID");

                entity.HasOne(d => d.Nurse)
                    .WithMany(p => p.SuburbsPreferreds)
                    .HasForeignKey(d => d.NurseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suburbs_Preferred_NurseID");

                entity.HasOne(d => d.Suburb)
                    .WithOne(p => p.SuburbsPreferred)
                    .HasForeignKey<SuburbsPreferred>(d => d.SuburbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suburbs_Preferred_Suburb");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test");

                entity.Property(e => e.TestId)
                    .ValueGeneratedNever()
                    .HasColumnName("TestID");

                entity.Property(e => e.BarCode)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.BloodPressure)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LabUserId).HasColumnName("LabUserID");

                entity.Property(e => e.OxygenLevel)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ResultDate).HasColumnType("datetime");

                entity.Property(e => e.Temperature)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TestDate).HasColumnType("datetime");

                entity.Property(e => e.TestResult)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.LabUser)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.LabUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_LabUser");
            });

            modelBuilder.Entity<TestRequest>(entity =>
            {
                entity.ToTable("Test_Request");

                entity.Property(e => e.TestRequestId)
                    .ValueGeneratedNever()
                    .HasColumnName("TestRequestID");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.NurseId).HasColumnName("NurseID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.TestAddress1)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TestAddress2).HasMaxLength(128);

                entity.Property(e => e.TimeSlotAssigned).HasColumnType("datetime");

                entity.HasOne(d => d.Nurse)
                    .WithMany(p => p.TestRequests)
                    .HasForeignKey(d => d.NurseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_Request_Nurse");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.TestRequests)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_Request_Patient");

                entity.HasOne(d => d.Suburb)
                    .WithMany(p => p.TestRequests)
                    .HasForeignKey(d => d.SuburbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_Request_Suburb");

                entity.HasOne(d => d.TestRequestNavigation)
                    .WithOne(p => p.TestRequest)
                    .HasForeignKey<TestRequest>(d => d.TestRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_Request_Tset");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
