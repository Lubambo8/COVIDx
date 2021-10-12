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
    public class DataSeedConfig :
        IEntityTypeConfiguration<City>,
        IEntityTypeConfiguration<Suburb>,
        IEntityTypeConfiguration<MedicalAidPlan>,
        IEntityTypeConfiguration<MedicalAidScheme>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(new City
            {
                CityId = 101,
                CityName = "Port Elizabeth"
            });
        }

        public void Configure(EntityTypeBuilder<Suburb> builder)
        {
            builder.HasData(
                new Suburb
                {
                    SuburbID = 101,
                    SuburbName = "Walmer",
                    PostalCode = "6070",
                    CityID = 101
                },
                new Suburb
                {
                    SuburbID = 102,
                    SuburbName = "Summerstrand",
                    PostalCode = "6001",
                    CityID = 101
                },
                new Suburb
                {
                    SuburbID = 103,
                    SuburbName = "Humewood",
                    PostalCode = "6013",
                    CityID = 101
                },
                new Suburb
                {
                    SuburbID = 104,
                    SuburbName = "South End",
                    PostalCode = "6001",
                    CityID = 101
                },
                new Suburb
                {
                    SuburbID = 105,
                    SuburbName = "Forest Hill",
                    PostalCode = "6001",
                    CityID = 101
                },
                new Suburb
                {
                    SuburbID = 106,
                    SuburbName = "Schoenmakerskop",
                    PostalCode = "6011",
                    CityID = 101
                },
                new Suburb
                {
                    SuburbID = 107,
                    SuburbName = "Lovemore Park",
                    PostalCode = "6070",
                    CityID = 101
                },
                new Suburb
                {
                    SuburbID = 108,
                    SuburbName = "North End",
                    PostalCode = "6001",
                    CityID = 101
                },
                new Suburb
                {
                    SuburbID = 109,
                    SuburbName = "Korsten",
                    PostalCode = "6020",
                    CityID = 101
                },
                new Suburb
                {
                    SuburbID = 110,
                    SuburbName = "Western Hills",
                    PostalCode = "6025",
                    CityID = 101
                });
        }

        public void Configure(EntityTypeBuilder<MedicalAidPlan> builder)
        {
            builder.HasData(
                new MedicalAidPlan { MedicalAidPlanID = 101, Description = "Executive Plan", MedicalAidSchemeID = 101 },
                new MedicalAidPlan { MedicalAidPlanID = 102, Description = "Comprehensive Plan", MedicalAidSchemeID = 101 },
                new MedicalAidPlan { MedicalAidPlanID = 103, Description = "Priority Plan", MedicalAidSchemeID = 101 },
                new MedicalAidPlan { MedicalAidPlanID = 104, Description = "Saver Plan", MedicalAidSchemeID = 101 },
                new MedicalAidPlan { MedicalAidPlanID = 105, Description = "Core Plan", MedicalAidSchemeID = 101 },
                new MedicalAidPlan { MedicalAidPlanID = 106, Description = "Smart Plan", MedicalAidSchemeID = 101 },
                new MedicalAidPlan { MedicalAidPlanID = 107, Description = "Key-care Plan", MedicalAidSchemeID = 102 },
                new MedicalAidPlan { MedicalAidPlanID = 108, Description = "Standard Plan", MedicalAidSchemeID = 102 },
                new MedicalAidPlan { MedicalAidPlanID = 109, Description = "Family Plan", MedicalAidSchemeID = 102 },
                new MedicalAidPlan { MedicalAidPlanID = 110, Description = "Premium Plan", MedicalAidSchemeID = 102 });
        }

        public void Configure(EntityTypeBuilder<MedicalAidScheme> builder)
        {
            builder.HasData(
                new MedicalAidScheme { MedicalAidSchemeID = 101, Description = "Discovery Health" },
                 new MedicalAidScheme { MedicalAidSchemeID = 102, Description = "ProfMed" }
                );
        }
    }
}


