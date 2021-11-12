using EFCore.EFCoreConfigurationMethods;
using EFCore.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public partial class DatabaseContext : IdentityDbContext<EFCoreIdentityUser>
    {
       

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CovidX_DB;Integrated Security=True;");
        //}
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Dependent> Dependent { get; set; }
        public virtual DbSet<LabUser> LabUser { get; set; }
        public virtual DbSet<MedicalAidPlan> MedicalAidPlan { get; set; }
        public virtual DbSet<MedicalAidScheme> MedicalAidScheme { get; set; }
        public virtual DbSet<Nurse> Nurse { get; set; }
        public virtual DbSet<NurseSchedule> NurseSchedule { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Suburb> Suburb { get; set; }
        public virtual DbSet<SuburbsPreferred> SuburbsPreferred { get; set; }
        public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestRequest> TestRequest { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configure relationships and seed data
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

            modelBuilder.SeedingCity();
            modelBuilder.SeedingSuburb();
            modelBuilder.SeedingMedicalAidScheme();
            modelBuilder.SeedingPatients();
            modelBuilder.SeedingMedicalAidPlan();
            modelBuilder.SeedingDependents();
            modelBuilder.SeedingNurses();
            modelBuilder.SeedingNursePreferredSuburbs();
            modelBuilder.SeedingLabUser();
            modelBuilder.SeedingTestRequests();
            modelBuilder.SeedingCalenderEvents();
            modelBuilder.SeedingTests();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
