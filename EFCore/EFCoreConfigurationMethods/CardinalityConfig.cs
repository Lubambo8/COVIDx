using EFCore.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.EFCoreConfigurationMethods
{
    public class CardinalityConfig :
        IEntityTypeConfiguration<EFCoreIdentityUser>,
        IEntityTypeConfiguration<Test>,
        IEntityTypeConfiguration<NurseSchedule>,
        IEntityTypeConfiguration<SuburbsPreferred>,
        IEntityTypeConfiguration<IdentityUserLogin<string>>,
        IEntityTypeConfiguration<IdentityUserRole<string>>,
        IEntityTypeConfiguration<IdentityUserToken<string>>,
        IEntityTypeConfiguration<Dependent>,
        IEntityTypeConfiguration<TestRequest>
    {
        public void Configure(EntityTypeBuilder<EFCoreIdentityUser> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .HasMany(e => e.Claims)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(e => e.Logins)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(e => e.Roles)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasOne(item => item.TestRequest)
                .WithOne(item => item.Test);
        }

        public void Configure(EntityTypeBuilder<NurseSchedule> builder)
        {
            builder.HasKey(e => new { e.NurseID, e.TestRequestID });
        }

        public void Configure(EntityTypeBuilder<SuburbsPreferred> builder)
        {
            builder.HasKey(e => new { e.SuburbID, e.NurseID });
        }

        public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> builder)
        {
            builder.HasKey(e => e.UserId);
        }

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasKey(e => new { e.UserId, e.RoleId });
        }

        public void Configure(EntityTypeBuilder<IdentityUserToken<string>> builder)
        {
            builder.HasKey(e => e.UserId);
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

        
    }
}
