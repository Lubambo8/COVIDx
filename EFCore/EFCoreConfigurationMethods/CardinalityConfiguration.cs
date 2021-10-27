using EFCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.EFCoreConfigurationMethods
{
    public class CardinalityConfiguration :
                IEntityTypeConfiguration<Test>,
        IEntityTypeConfiguration<NurseSchedule>,
        IEntityTypeConfiguration<SuburbsPreferred>,
        IEntityTypeConfiguration<Dependent>,
        IEntityTypeConfiguration<TestRequest>,
        IEntityTypeConfiguration<Patient>,
        IEntityTypeConfiguration<CalendarEvent>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasOne(item => item.TestRequest)
                .WithOne(item => item.Test);
        }

        public void Configure(EntityTypeBuilder<NurseSchedule> builder)
        {
            builder.HasKey(e => new { e.NurseID, e.TestRequestID });

            builder.HasOne(fk => fk.TestRequest)
                 .WithMany(fk => fk.NurseSchedules)
                .HasForeignKey(fk => fk.TestRequestID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(fk => fk.Nurse)
                .WithMany(fk => fk.NurseSchedules)
               .HasForeignKey(fk => fk.NurseID)
               .OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<SuburbsPreferred> builder)
        {
            builder.HasKey(composite => new {composite.SuburbID, composite.NurseID });

        }


        public void Configure(EntityTypeBuilder<Dependent> builder)
        {
            builder.HasOne(item => item.MainMember)
                .WithMany(item => item.Dependents)
                .HasForeignKey(item => item.MainMemberID)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<TestRequest> builder)
        {
            builder.HasOne(item => item.Suburb)
                .WithMany(item => item.TestRequests)
                .HasForeignKey(item => item.SuburbID)
                .OnDelete(DeleteBehavior.Restrict);

        }

        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasOne(item => item.Suburb)
                .WithMany(item => item.Patients)
                .HasForeignKey(item => item.SuburbID)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<CalendarEvent> builder)
        {
            builder.HasOne<TestRequest>(calendar => calendar.TestRequest)
                 .WithOne(test => test.CalendarEvents)
                 .HasForeignKey<CalendarEvent>(fk => fk.ID);
        }
    }
}
