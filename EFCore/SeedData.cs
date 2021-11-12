using EFCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public static class SeedData
    {
        #region City

        public static void SeedingCity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, CityName = "Gqeberha" });
        }

        #endregion City

        #region Suburb

        public static void SeedingSuburb(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suburb>().HasData(
                new Suburb { SuburbID = 1, SuburbName = "Adcock Vale", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 2, SuburbName = "Algoa Park", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 3, SuburbName = "Arcadia", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 4, SuburbName = "Aspen Heights", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 5, SuburbName = "Ben Kamma", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 6, SuburbName = "Bethelsdorp", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 7, SuburbName = "Beverly Grove", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 8, SuburbName = "Beverly Hills", PostalCode = "6020", CityID = 1 },
                new Suburb { SuburbID = 9, SuburbName = "Bloemendal", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 10, SuburbName = "Bluewater BAY", PostalCode = "6210", CityID = 1 },
                new Suburb { SuburbID = 11, SuburbName = "Boast Village", PostalCode = "6200", CityID = 1 },
                new Suburb { SuburbID = 12, SuburbName = "Booysens Park", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 13, SuburbName = "Bramhope", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 14, SuburbName = "Brentwood Park", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 15, SuburbName = "Bridgemead", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 16, SuburbName = "Broadwood", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 17, SuburbName = "Brymore", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 18, SuburbName = "Cadles", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 19, SuburbName = "Castle Hill", PostalCode = "6001", CityID = 1 },
                  new Suburb { SuburbID = 20, SuburbName = "Centralhil", PostalCode = "6001", CityID = 1 },

                new Suburb { SuburbID = 21, SuburbName = "Central", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 22, SuburbName = "Charlo", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 23, SuburbName = "Chatty", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 24, SuburbName = "Cleary Park", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 25, SuburbName = "Collen Glen", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 26, SuburbName = "Cotswold", PostalCode = "6045", CityID = 1 },
                new Suburb { SuburbID = 27, SuburbName = "Cradock Place", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 28, SuburbName = "Cradockplek", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 29, SuburbName = "Craigbain", PostalCode = "6001", CityID = 1 },
                  new Suburb { SuburbID = 30, SuburbName = "Crestview", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 31, SuburbName = "Dowerville", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 32, SuburbName = "Emerald Hill", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 33, SuburbName = "Essexvale", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 34, SuburbName = "Fairview", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 35, SuburbName = "Ferguson", PostalCode = "6045", CityID = 1 },
                new Suburb { SuburbID = 36, SuburbName = "Fernglen", PostalCode = "6045", CityID = 1 },
                new Suburb { SuburbID = 37, SuburbName = "Fernwood Park", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 38, SuburbName = "Forest Hill", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 39, SuburbName = "Framesby", PostalCode = "6045", CityID = 1 },
                  new Suburb { SuburbID = 40, SuburbName = "Francis Evatt Park", PostalCode = "6045", CityID = 1 },

                new Suburb { SuburbID = 41, SuburbName = "Gambleville", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 42, SuburbName = "Gelvan Park", PostalCode = "6020", CityID = 1 },
                new Suburb { SuburbID = 43, SuburbName = "Gelvandale", PostalCode = "6020", CityID = 1 },
                new Suburb { SuburbID = 44, SuburbName = "Glen Hurd", PostalCode = "6045", CityID = 1 },
                new Suburb { SuburbID = 45, SuburbName = "Glen Kamma", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 46, SuburbName = "Gledinningvale", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 47, SuburbName = "Glenroy Park", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 48, SuburbName = "Goldwater", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 49, SuburbName = "Greenacres", PostalCode = "6045", CityID = 1 },
                  new Suburb { SuburbID = 50, SuburbName = "Greenbushes", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 51, SuburbName = "Greenshields Park", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 52, SuburbName = "Heath Park", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 53, SuburbName = "Helenvale", PostalCode = "6020", CityID = 1 },
                new Suburb { SuburbID = 54, SuburbName = "Hillside", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 55, SuburbName = "Holland Park", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 56, SuburbName = "Humerail", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 57, SuburbName = "Humewood", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 58, SuburbName = "Hunters Retreat", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 59, SuburbName = "Kabega", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 60, SuburbName = "Kamma Creek", PostalCode = "6070", CityID = 1 },

                new Suburb { SuburbID = 61, SuburbName = "Kamma Park", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 62, SuburbName = "Kamma Ridge", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 63, SuburbName = "Kamvelihle", PostalCode = "6211", CityID = 1 },
                new Suburb { SuburbID = 64, SuburbName = "Kemsley Park", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 65, SuburbName = "Kensington", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 66, SuburbName = "Korsten", PostalCode = "6020", CityID = 1 },
                new Suburb { SuburbID = 67, SuburbName = "Kunene Park", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 68, SuburbName = "Kwaford", PostalCode = "6200", CityID = 1 },
                new Suburb { SuburbID = 69, SuburbName = "Kwazakhele", PostalCode = "6205", CityID = 1 },
                  new Suburb { SuburbID = 70, SuburbName = "Linkside", PostalCode = "6001", CityID = 1 },

                  new Suburb { SuburbID = 71, SuburbName = "Linton Grange", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 72, SuburbName = "Listerwood", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 73, SuburbName = "Lorraine", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 74, SuburbName = "Lorraine Manor", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 75, SuburbName = "Lovemore Heights", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 76, SuburbName = "Lovemore Park", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 77, SuburbName = "Macleanville", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 78, SuburbName = "Malabar", PostalCode = "6020", CityID = 1 },
                new Suburb { SuburbID = 79, SuburbName = "Mangold Park", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 80, SuburbName = "Mcnamee Village", PostalCode = "6200", CityID = 1 },

                new Suburb { SuburbID = 81, SuburbName = "Mill Park", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 82, SuburbName = "Millard Grange", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 83, SuburbName = "Miramar", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 84, SuburbName = "Missionvale", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 85, SuburbName = "Moregrove", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 86, SuburbName = "Morningside", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 87, SuburbName = "Motherwell", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 88, SuburbName = "Mount Croix", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 89, SuburbName = "Mount Pleasant", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 90, SuburbName = "Neave", PostalCode = "6001", CityID = 1 },

                 new Suburb { SuburbID = 91, SuburbName = "New Brighton", PostalCode = "6200", CityID = 1 },
                new Suburb { SuburbID = 92, SuburbName = "Newton Park", PostalCode = "6045", CityID = 1 },
                new Suburb { SuburbID = 93, SuburbName = "Normanville", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 94, SuburbName = "North End", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 95, SuburbName = "Palm Ridge", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 96, SuburbName = "Pari Park", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 97, SuburbName = "Park Drive", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 98, SuburbName = "Parkside", PostalCode = "6020", CityID = 1 },
                new Suburb { SuburbID = 99, SuburbName = "Parsons Vlei", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 100, SuburbName = "Parsons Hill", PostalCode = "6001", CityID = 1 },

                new Suburb { SuburbID = 101, SuburbName = "Perridgevale", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 102, SuburbName = "Pinegrove", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 103, SuburbName = "Providentia", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 104, SuburbName = "Redhouse", PostalCode = "6201", CityID = 1 },
                new Suburb { SuburbID = 105, SuburbName = "Retiefville", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 106, SuburbName = "Richmond Hill", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 107, SuburbName = "Richmond Park", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 108, SuburbName = "Rowallan Park", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 109, SuburbName = "Rufanevale", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 110, SuburbName = "Salisbury Park", PostalCode = "6070", CityID = 1 },

                new Suburb { SuburbID = 111, SuburbName = "Salsoneville", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 112, SuburbName = "Salt Lake", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 113, SuburbName = "Saltville", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 114, SuburbName = "Sanctor", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 115, SuburbName = "Schauderville", PostalCode = "6020", CityID = 1 },
                new Suburb { SuburbID = 116, SuburbName = "Sea View", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 117, SuburbName = "Sherwood", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 118, SuburbName = "Sidwell", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 119, SuburbName = "South End", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 120, SuburbName = "Springdale", PostalCode = "6020", CityID = 1 },

                 new Suburb { SuburbID = 121, SuburbName = "Springfield", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 122, SuburbName = "ST Georges", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 123, SuburbName = "Stella Londt Park", PostalCode = "6045", CityID = 1 },
                new Suburb { SuburbID = 124, SuburbName = "Steytler", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 125, SuburbName = "Struandale", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 126, SuburbName = "Summerstrand", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 127, SuburbName = "Summerwood", PostalCode = "6001", CityID = 1 },
                new Suburb { SuburbID = 128, SuburbName = "Sunridge Park", PostalCode = "6045", CityID = 1 },
                new Suburb { SuburbID = 129, SuburbName = "Swartkops", PostalCode = "6210", CityID = 1 },
                new Suburb { SuburbID = 130, SuburbName = "Sydenham", PostalCode = "6001", CityID = 1 },

                new Suburb { SuburbID = 131, SuburbName = "Taybank", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 132, SuburbName = "Theescombe", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 133, SuburbName = "Timothy Valley", PostalCode = "6059", CityID = 1 },
                new Suburb { SuburbID = 134, SuburbName = "Treehaven", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 135, SuburbName = "Trevolen", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 136, SuburbName = "Vikingvale", PostalCode = "6025", CityID = 1 },
                new Suburb { SuburbID = 137, SuburbName = "Walmer", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 138, SuburbName = "Walmer Downs", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 139, SuburbName = "Walmer Heights", PostalCode = "6070", CityID = 1 },
                new Suburb { SuburbID = 140, SuburbName = "Wells Estate", PostalCode = "6211", CityID = 1 },

                  new Suburb { SuburbID = 141, SuburbName = "Westering", PostalCode = "6025", CityID = 1 },
                  new Suburb { SuburbID = 142, SuburbName = "Westview", PostalCode = "6045", CityID = 1 },
                    new Suburb { SuburbID = 143, SuburbName = "Weybridge Park", PostalCode = "6070", CityID = 1 },
                  new Suburb { SuburbID = 144, SuburbName = "Woodlands", PostalCode = "6070", CityID = 1 },
                   new Suburb { SuburbID = 145, SuburbName = "Woolhope", PostalCode = "6020", CityID = 1 },
                  new Suburb { SuburbID = 146, SuburbName = "Young Park", PostalCode = "6001", CityID = 1 },
                  new Suburb { SuburbID = 147, SuburbName = "Zwide", PostalCode = "6201", CityID = 1 }

                );
        }

        #endregion Suburb

        #region MedicalAidScheme

        public static void SeedingMedicalAidScheme(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalAidScheme>().HasData(
                new MedicalAidScheme { MedicalAidSchemeID = 1, Description = "BestMed" },
                new MedicalAidScheme { MedicalAidSchemeID = 2, Description = "Bonitas" },
                new MedicalAidScheme { MedicalAidSchemeID = 3, Description = "Discovery Health" }
                 );
        }

        #endregion MedicalAidScheme

        #region MedicalAidPlan

        public static void SeedingMedicalAidPlan(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalAidPlan>().HasData(
                 new MedicalAidPlan { MedicalAidPlanID = 1, Description = "Beat 1", MedicalAidSchemeID = 1 },
                new MedicalAidPlan { MedicalAidPlanID = 2, Description = "Beat 2", MedicalAidSchemeID = 1 },
                new MedicalAidPlan { MedicalAidPlanID = 3, Description = "Beat 3", MedicalAidSchemeID = 1 },
                new MedicalAidPlan { MedicalAidPlanID = 4, Description = "Beat 4", MedicalAidSchemeID = 1 },
                new MedicalAidPlan { MedicalAidPlanID = 5, Description = "Pulse 1", MedicalAidSchemeID = 1 },
                new MedicalAidPlan { MedicalAidPlanID = 6, Description = "Pulse 2", MedicalAidSchemeID = 1 },
                new MedicalAidPlan { MedicalAidPlanID = 7, Description = "Pace 1", MedicalAidSchemeID = 1 },
                new MedicalAidPlan { MedicalAidPlanID = 8, Description = "Pace 2", MedicalAidSchemeID = 1 },
                new MedicalAidPlan { MedicalAidPlanID = 9, Description = "Pace 3", MedicalAidSchemeID = 1 },
                new MedicalAidPlan { MedicalAidPlanID = 10, Description = "Pace 4", MedicalAidSchemeID = 1 },

                new MedicalAidPlan { MedicalAidPlanID = 11, Description = "BonStart", MedicalAidSchemeID = 2 },
                new MedicalAidPlan { MedicalAidPlanID = 12, Description = "Primary", MedicalAidSchemeID = 2 },
                new MedicalAidPlan { MedicalAidPlanID = 13, Description = "Primary Select", MedicalAidSchemeID = 2 },
                new MedicalAidPlan { MedicalAidPlanID = 14, Description = "Standard", MedicalAidSchemeID = 2 },
                new MedicalAidPlan { MedicalAidPlanID = 15, Description = "Standard Select", MedicalAidSchemeID = 2 },
               new MedicalAidPlan { MedicalAidPlanID = 16, Description = "BonFit Select", MedicalAidSchemeID = 2 },
                new MedicalAidPlan { MedicalAidPlanID = 17, Description = "BonSave", MedicalAidSchemeID = 2 },
                 new MedicalAidPlan { MedicalAidPlanID = 18, Description = "BonComplete", MedicalAidSchemeID = 2 },
                  new MedicalAidPlan { MedicalAidPlanID = 19, Description = "BonClassic", MedicalAidSchemeID = 2 },
                   new MedicalAidPlan { MedicalAidPlanID = 20, Description = "BonFitComprehensive", MedicalAidSchemeID = 2 },
                    new MedicalAidPlan { MedicalAidPlanID = 21, Description = "Hospital Standard", MedicalAidSchemeID = 2 },
                     new MedicalAidPlan { MedicalAidPlanID = 22, Description = "BonEssential", MedicalAidSchemeID = 2 },
                      new MedicalAidPlan { MedicalAidPlanID = 23, Description = "BonEssentialSelect", MedicalAidSchemeID = 2 },
                       new MedicalAidPlan { MedicalAidPlanID = 24, Description = "BonCap", MedicalAidSchemeID = 2 },

                          new MedicalAidPlan { MedicalAidPlanID = 25, Description = "Executive", MedicalAidSchemeID = 3 },
                          new MedicalAidPlan { MedicalAidPlanID = 26, Description = "Classic Comprehensive", MedicalAidSchemeID = 3 },
                          new MedicalAidPlan { MedicalAidPlanID = 27, Description = "Classic Data Comprehensive", MedicalAidSchemeID = 3 },
                          new MedicalAidPlan { MedicalAidPlanID = 28, Description = "Classic Smart Comprehensive", MedicalAidSchemeID = 3 },
                           new MedicalAidPlan { MedicalAidPlanID = 29, Description = "Essential Comprehensive", MedicalAidSchemeID = 3 },
                            new MedicalAidPlan { MedicalAidPlanID = 30, Description = "Essential Data", MedicalAidSchemeID = 3 },
                             new MedicalAidPlan { MedicalAidPlanID = 31, Description = "Classic Priority", MedicalAidSchemeID = 3 },
                              new MedicalAidPlan { MedicalAidPlanID = 32, Description = "Essential Priority", MedicalAidSchemeID = 3 },

                               new MedicalAidPlan { MedicalAidPlanID = 33, Description = "Classic Saver", MedicalAidSchemeID = 3 },
                            new MedicalAidPlan { MedicalAidPlanID = 34, Description = "Classic Delta Saver", MedicalAidSchemeID = 3 },
                             new MedicalAidPlan { MedicalAidPlanID = 35, Description = "Essential Saver", MedicalAidSchemeID = 3 },
                              new MedicalAidPlan { MedicalAidPlanID = 36, Description = "Essential Delta Saver", MedicalAidSchemeID = 3 },

                                new MedicalAidPlan { MedicalAidPlanID = 37, Description = "Coastal Saver", MedicalAidSchemeID = 3 },
                            new MedicalAidPlan { MedicalAidPlanID = 38, Description = "Classic Smart", MedicalAidSchemeID = 3 },
                             new MedicalAidPlan { MedicalAidPlanID = 39, Description = "Essential Smart", MedicalAidSchemeID = 3 },
                              new MedicalAidPlan { MedicalAidPlanID = 40, Description = "Classic Core", MedicalAidSchemeID = 3 },

                                new MedicalAidPlan { MedicalAidPlanID = 41, Description = "Classic Delta Core", MedicalAidSchemeID = 3 },
                            new MedicalAidPlan { MedicalAidPlanID = 42, Description = "Essential Core", MedicalAidSchemeID = 3 },
                             new MedicalAidPlan { MedicalAidPlanID = 43, Description = "Essential Delta Core", MedicalAidSchemeID = 3 },
                              new MedicalAidPlan { MedicalAidPlanID = 44, Description = "Coastal Core", MedicalAidSchemeID = 3 },
                              new MedicalAidPlan { MedicalAidPlanID = 45, Description = "Keycare Plus", MedicalAidSchemeID = 3 },
                             new MedicalAidPlan { MedicalAidPlanID = 46, Description = "Keycare Smart", MedicalAidSchemeID = 3 },
                              new MedicalAidPlan { MedicalAidPlanID = 47, Description = "Keycare Core", MedicalAidSchemeID = 3 }

                );
        }

        #endregion MedicalAidPlan

        #region Patients

        public static void SeedingPatients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    PatientID = 1,
                    IDnumber = "5503180225083",
                    DateOfBirth = Convert.ToDateTime("1955/03/18"),
                    FirstName = "Charmaine",
                    LastName = "Meintjies",
                    MobileNumber = "0832458796",
                    AddressLine1 = "19 Admirality Way",
                    SuburbID = 126,
                    MedicalAidStatus = true,
                    MedicalAidPlanID = 8,
                    EmailAddress = "charmaine@gmail.com",
                    MedicalAidNo = "285465885",
                    PersonResponsible = "Charmaine Meintjies",
                    DependencyCode = "00",
                    UserID = "62b19f4b-ed00-43c9-a7e4-10544e4c3cb9",
                    Gender = Genders.Female
                },
                 new Patient
                 {
                     PatientID = 2,
                     IDnumber = "8012010225083",
                     DateOfBirth = Convert.ToDateTime("1980/12/01"),
                     FirstName = "Jacob",
                     LastName = "Moloi",
                     MobileNumber = "0822458796",
                     EmailAddress = "jacob@gmail.com",
                     AddressLine1 = "24 7th Avenue",
                     SuburbID = 127,
                     MedicalAidStatus = false,
                     MedicalAidPlanID = null,
                     PersonResponsible = "Jacob Moloi",
                     UserID = "f3241b84-940c-45fa-8a71-dda57cefe4a6",
                     Gender = Genders.Male
                 },
                  new Patient
                  {
                      PatientID = 3,
                      IDnumber = "8002200225083",
                      DateOfBirth = Convert.ToDateTime("1980/02/20"),
                      FirstName = "David",
                      LastName = "Greeff",
                      MobileNumber = "0712458796",
                      EmailAddress = "david@gmail.com",
                      AddressLine1 = "1 Harbor Cottages",
                      AddressLine2 = "Sayre Crescent",
                      SuburbID = 56,
                      MedicalAidStatus = false,
                      MedicalAidPlanID = null,
                      PersonResponsible = "David Greeff",
                      UserID = "586aeb11-f69c-435a-a066-77a5a03ccf84",
                      Gender = Genders.Male
                  },

                    new Patient
                    {
                        PatientID = 4,
                        IDnumber = "7606030225083",
                        DateOfBirth = Convert.ToDateTime("1976/06/03"),
                        FirstName = "Kopano",
                        LastName = "Sithole",
                        MobileNumber = "0722458796",
                        EmailAddress = "kopano@gmail.com",
                        AddressLine1 = "27 Aspen Complex",
                        AddressLine2 = "La Roche Drive",
                        SuburbID = 57,
                        MedicalAidStatus = false,
                        MedicalAidPlanID = null,
                        PersonResponsible = "Kopano Sithole",
                        UserID = "9e1cabd8-4db3-4c4d-97bb-ce87b049dae9",
                        Gender = Genders.Male
                    },

                        new Patient
                        {
                            PatientID = 5,
                            IDnumber = "8509020225083",
                            DateOfBirth = Convert.ToDateTime("1985/09/02"),
                            FirstName = "Karien",
                            LastName = "Momberg",
                            MobileNumber = "0732458796",
                            EmailAddress = "karien@gmail.com",
                            AddressLine1 = "6 Rubin Crescent",
                            SuburbID = 126,
                            MedicalAidStatus = false,
                            MedicalAidPlanID = null,
                            PersonResponsible = "Karien Momberg",
                            UserID = "9a6a06d9-002f-4bba-a2d3-8c88db78655f",
                            Gender = Genders.Female
                        },
                          new Patient
                          {
                              PatientID = 6,
                              IDnumber = "7512020225083",
                              DateOfBirth = Convert.ToDateTime("1975/12/02"),
                              FirstName = "Felicity",
                              LastName = "Daniels",
                              MobileNumber = "0612458796",
                              EmailAddress = "felicityONP400@gmail.com",
                              AddressLine1 = "28 7th Avenue",
                              SuburbID = 127,
                              MedicalAidStatus = false,
                              MedicalAidPlanID = null,
                              PersonResponsible = "Felicity Daniels",
                              UserID = "993ab159-92db-4e13-9096-92d0f3e7ba72",
                              Gender = Genders.Female
                          },

                            new Patient
                            {
                                PatientID = 7,
                                IDnumber = "6008090225083",
                                DateOfBirth = Convert.ToDateTime("1960/08/09"),
                                FirstName = "Errol",
                                LastName = "Pieterse",
                                MobileNumber = "0612458796",
                                EmailAddress = "errol@gmail.com",
                                AddressLine1 = "37 The Beaches",
                                AddressLine2 = "Beach Road",
                                SuburbID = 56,
                                MedicalAidStatus = false,
                                MedicalAidPlanID = null,
                                PersonResponsible = "Errol Pieterse",
                                UserID = "153a5791-0955-4753-8b56-ca6e352f2c4d",
                                Gender = Genders.Male
                            },

                              new Patient
                              {
                                  PatientID = 8,
                                  IDnumber = "6412120225083",
                                  DateOfBirth = Convert.ToDateTime("1964/12/12"),
                                  FirstName = "Alyce",
                                  LastName = "Morapedi",
                                  MobileNumber = "0632458796",
                                  EmailAddress = "alyce@gmail.com",
                                  AddressLine1 = "12 Marshall Road",
                                  SuburbID = 57,
                                  MedicalAidStatus = true,
                                  MedicalAidPlanID = 17,
                                  MedicalAidNo = "395465885",
                                  DependencyCode = "00",
                                  PersonResponsible = "Alyce Morapedi",
                                  UserID = "87f902a7-a258-41a4-abe0-fff895624838",
                                  Gender = Genders.Female
                              },
                                 new Patient
                                 {
                                     PatientID = 9,
                                     IDnumber = "8302090225083",
                                     DateOfBirth = Convert.ToDateTime("1983/02/20"),
                                     FirstName = "Asha",
                                     LastName = "Sharma",
                                     MobileNumber = "0812458796",
                                     EmailAddress = "asha@gmail.com",
                                     AddressLine1 = "13 Congo Avenue",
                                     SuburbID = 84,
                                     MedicalAidStatus = true,
                                     MedicalAidPlanID = 44,
                                     MedicalAidNo = "175465885",
                                     DependencyCode = "00",
                                     PersonResponsible = "Asha Sharma",
                                     UserID = "d1b8b348-0630-40ae-ba96-0327d46f3ef3",
                                     Gender = Genders.Female
                                 },
                                   new Patient
                                   {
                                       PatientID = 10,
                                       IDnumber = "5008100225083",
                                       DateOfBirth = Convert.ToDateTime("1950/08/10"),
                                       FirstName = "Carlos",
                                       LastName = "Perestrelo",
                                       MobileNumber = "0842458796",
                                       EmailAddress = "carlos@gmail.com",
                                       AddressLine1 = "29 Peace Street",
                                       SuburbID = 84,
                                       MedicalAidStatus = false,
                                       MedicalAidPlanID = null,
                                       PersonResponsible = "Carlos Perestrelo",
                                       UserID = "ca99bbf8-a011-4d23-87af-86659e6c75c2",
                                       Gender = Genders.Male
                                   },
                                    new Patient
                                    {
                                        PatientID = 11,
                                        IDnumber = "7112150225083",
                                        DateOfBirth = Convert.ToDateTime("1971/12/15"),
                                        FirstName = "Kabelo",
                                        LastName = "Padi",
                                        MobileNumber = "0742458796",
                                        EmailAddress = "kabelo@gmail.com",
                                        AddressLine1 = "7 Jacks Road",
                                        SuburbID = 84,
                                        MedicalAidStatus = false,
                                        PersonResponsible = "Kabelo Padi",
                                        MedicalAidPlanID = null,
                                        UserID = "89d4c9c1-0b46-4440-bbef-591aa8e33810",
                                        Gender = Genders.Male
                                    },
                                     new Patient
                                     {
                                         PatientID = 12,
                                         IDnumber = "9110120225083",
                                         DateOfBirth = Convert.ToDateTime("1991/10/12"),
                                         FirstName = "Pulane",
                                         LastName = "Masemola",
                                         MobileNumber = "0642458796",
                                         EmailAddress = "pulane@gmail.com",
                                         AddressLine1 = "45 Columbia Crescent",
                                         SuburbID = 84,
                                         MedicalAidStatus = true,
                                         MedicalAidPlanID = 1,
                                         MedicalAidNo = "465465885",
                                         DependencyCode = "00",
                                         PersonResponsible = "Pulane Masemola",
                                         UserID = "2f2e6869-4071-42d0-bc81-ed037c099a17",
                                         Gender = Genders.Female
                                     }

                 );
        }

        #endregion Patients

        #region Dependents

        public static void SeedingDependents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dependent>().HasData(
              new Dependent
              {
                  DependentID = 91,
                  MainMemberID = 1,
                  FirstName = "Daleene",
                  LastName = "Meintjies",
                  MobileNumber = "0832458796",
                  AddressLine1 = "19 Admirality Way",
                  SuburbID = 126,
                  MedicalAidStatus = true,
                  MedicalAidPlanID = 8,
                  MedicalAidNo = "285465885",
                  PersonResponsible = "Charmaine Meintjies",
                  Relationship= Relationships.Sister,//sibling
                  IDnumber = "8009160225083",
                  DateOfbirth = Convert.ToDateTime("1980/09/16"),
                  Gender = Genders.Female,
                  EmailAddress = "daleen@gmail.com"
              },
                new Dependent
                {
                    DependentID = 92,
                    MainMemberID = 1,//charmaine
                    FirstName = "Vince",
                    LastName = "Meintjies",
                    MobileNumber = "0832458796",
                    AddressLine1 = "19 Admirality Way",
                    SuburbID = 126,
                    MedicalAidStatus = true,
                    MedicalAidPlanID = 8,
                    MedicalAidNo = "285465885",
                    PersonResponsible = "Charmaine Meintjies",
                    Relationship= Relationships.GrandChild,//gtandchild
                    IDnumber = "1205050225083",
                    DateOfbirth = Convert.ToDateTime("2012/05/05"),
                    Gender = Genders.Male,
                    EmailAddress = "charmaine@gmail.com"
                },
                      new Dependent
                      {
                          DependentID = 93,
                          MainMemberID = 1,//charmaine
                          FirstName = "Vanessa",
                          LastName = "Meintjies",
                          MobileNumber = "0832458796",
                          AddressLine1 = "19 Admirality Way",
                          SuburbID = 126,
                          MedicalAidStatus = true,
                          MedicalAidPlanID = 8,
                          MedicalAidNo = "285465885",
                          PersonResponsible = "Charmaine Meintjies",
                          Relationship= Relationships.GrandChild,//grandchild
                          IDnumber = "1607070225083",
                          DateOfbirth = Convert.ToDateTime("2016/07/07"),
                          Gender = Genders.Female,
                          EmailAddress = "charmaine@gmail.com"
                      },

                       new Dependent
                       {
                           DependentID = 94,
                           MainMemberID = 1,//charmaine
                           FirstName = "Daniel",
                           LastName = "Meintjies",
                           MobileNumber = "0832458796",
                           AddressLine1 = "19 Admirality Way",
                           SuburbID = 126,
                           MedicalAidStatus = true,
                           MedicalAidPlanID = 8,
                           MedicalAidNo = "285465885",
                           PersonResponsible = "Charmaine Meintjies",
                           Relationship= Relationships.Brother,//sibling
                           IDnumber = "5309130225083",
                           DateOfbirth = Convert.ToDateTime("1953/09/13"),
                           Gender = Genders.Male,
                           EmailAddress = "charmaine@gmail.com"
                       },

                       new Dependent
                       {
                           
                           DependentID = 95,
                           MainMemberID = 2,//jacob
                           FirstName = "Lesedi",
                           LastName = "Moloi",
                           MobileNumber = "0772458796",
                           AddressLine1 = "24 7th Avenue",
                           SuburbID = 127,
                           MedicalAidStatus = false,
                           PersonResponsible = "Jacob Moloi",
                           Relationship= Relationships.Daughter,//child
                           IDnumber = "8307070225083",
                           DateOfbirth = Convert.ToDateTime("1983/07/07"),
                           Gender = Genders.Female,
                           MedicalAidPlanID = null,//40 is a placeholder since medicalaid doesnt want to be null, it is null on migration,
                           EmailAddress = "lesedi@gmail.com"
                       },
                        new Dependent
                        {
                            DependentID = 96,
                            MainMemberID = 2,//jacob
                            FirstName = "Thabo",
                            LastName = "Moloi",
                            MobileNumber = "0822458796",
                            AddressLine1 = "24 7th Avenue",
                            SuburbID = 127,
                            MedicalAidStatus = false,
                            PersonResponsible = "Jacob Moloi",
                            Relationship= Relationships.Son,//child
                            IDnumber = "1107090225083",
                            DateOfbirth = Convert.ToDateTime("2011/07/09"),
                            Gender = Genders.Male,
                            MedicalAidPlanID = null,
                            EmailAddress = "jacob@gmail.com"
                        }

                 );
        }

        #endregion Dependents

        #region Nurses

        public static void SeedingNurses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nurse>().HasData(
                new Nurse
                {
                    NurseID = 1,
                    FirstName = "Dorothy",
                    LastName = "Daniels",
                    IDnumber = "7503180225083",
                    YearsQualified = Convert.ToDateTime("1992/04/04"),
                    Rank = Rank.Specialized,
                    AddressLine1 = "10th Avenue",
                    SuburbID = 126,
                    MobileNumber = "0512458796",
                    EmailAddress = "dorothy@gmail.com",
                    UserID = "b4781a1d-7286-4d10-981c-bb54e987d4b0"
                    
                },

                  new Nurse
                  {
                      NurseID = 9,
                      FirstName = "Lindile",
                      LastName = "Hadebe",
                      IDnumber = "7603180225083",
                      YearsQualified = Convert.ToDateTime("1997/02/15"),
                      Rank = Rank.Midwife,
                      AddressLine1 = "64 Barbert street",
                      SuburbID = 73,
                      MobileNumber = "0522458796",
                      EmailAddress = "lindile@gmail.com",
                      UserID = "c6370b10-526e-4d63-8648-8bb17b3613bd"
                  },

                        new Nurse
                        {
                            NurseID = 15,
                            FirstName = "Marcel",
                            LastName = "Van Niekerk",
                            IDnumber = "7703180225083",
                            YearsQualified = Convert.ToDateTime("2003/05/07"),
                            Rank = Rank.General,
                            AddressLine1 = "13 Gutch Road",
                            SuburbID = 43,
                            MobileNumber = "0532458796",
                            EmailAddress = "marcel@gmail.com",
                            UserID = "a911d5f1-734a-415d-93ae-19c6c74320d3"
                        }

                 );
        }

        #endregion Nurses

        #region NursesPrefferedSuburbs

        public static void SeedingNursePreferredSuburbs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuburbsPreferred>().HasData(
                new SuburbsPreferred { NurseID = 1, SuburbID = 126 },//dorothy
                      new SuburbsPreferred { NurseID = 1, SuburbID = 127 },
                 new SuburbsPreferred { NurseID = 1, SuburbID = 56 },
                  new SuburbsPreferred { NurseID = 1, SuburbID = 57 },
                  new SuburbsPreferred { NurseID = 15, SuburbID = 91 }//marcel
                  
                 );
        }

        #endregion NursesPrefferedSuburbs

        #region SeedLabUser

        public static void SeedingLabUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabUser>().HasData(
               new LabUser
               {
                   LabUserID = 1,
                   FirstName = "Mandla",
                   LastName = "Khumalo",
                   IDnumber = "79052520225083",
                   MobileNumber = "0912458796",
                   EmailAddress = "mandla@gmail.com",
                   Qualification = "Pharmacist",
                   Gender = Genders.Male
                   
               }

                 );
        }

        #endregion SeedLabUser

        #region SeedTestRequests

        public static void SeedingTestRequests(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestRequest>().HasData(
               new TestRequest
               {
                   TestRequestID = 1,
                   RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                   RequestStatus = TestRequestStatus.Scheduled,
                   PatientId = 1,//Charmaine
                   DependentID = null,
                   TestAddress1 = "19 Admirality Way",
                   TestAddress2 = null,
                   SuburbID = 126,
                   DateAssigned = Convert.ToDateTime("12/11/2021"),
                   NurseID = 1, //Dorothy
                   StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                   EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                   CalendarEventID = 1
                   //10- 12,

               },

                 new TestRequest
                 {
                     TestRequestID = 2,
                     RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                     RequestStatus = TestRequestStatus.Scheduled,
                     PatientId = 1,
                     DependentID = 91,
                     TestAddress1 = "19 Admirality Way",
                     TestAddress2 = null,
                     SuburbID = 126,
                     DateAssigned = Convert.ToDateTime("12/11/2021"),
                     NurseID = 1, //Dorothy
                     StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                     EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                     CalendarEventID = 2
                     //10- 12
                 },

                    new TestRequest
                    {
                        TestRequestID = 3,
                        RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                        RequestStatus = TestRequestStatus.Scheduled,
                        PatientId = 1,//Charmaine
                        DependentID = 92, //Vince
                        TestAddress1 = "19 Admirality Way",
                        TestAddress2 = null,
                        SuburbID = 126,
                        DateAssigned = Convert.ToDateTime("12/11/2021"),
                        NurseID = 1, //Dorothy
                        StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                        EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                        CalendarEventID = 3
                        //10- 12
                    },
                      new TestRequest
                      {
                          TestRequestID = 4,
                          RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                          RequestStatus = TestRequestStatus.Scheduled,
                          PatientId = 1,
                          DependentID = 93, //VAnessa
                          TestAddress1 = "19 Admirality Way",
                          TestAddress2 = null,
                          SuburbID = 126,
                          DateAssigned = Convert.ToDateTime("12/11/2021"),
                          NurseID = 1, //Dorothy
                          StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                          EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                          CalendarEventID = 4
                          //10- 12
                      },

                        new TestRequest
                        {
                            TestRequestID = 5,
                            RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                            RequestStatus = TestRequestStatus.Scheduled,
                            PatientId = 1,//Charmaine
                            DependentID = 94, //VAnessa
                            TestAddress1 = "19 Admirality Way",
                            TestAddress2 = null,
                            SuburbID = 126,
                            DateAssigned = Convert.ToDateTime("12/11/2021"),
                            NurseID = 1, //Dorothy
                            StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                            EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                            CalendarEventID = 5
                            //10- 12
                        },
                        new TestRequest
                        {
                            TestRequestID = 6,
                            RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                            RequestStatus = TestRequestStatus.Scheduled,
                            PatientId = 3,//Dawid
                            DependentID = null,
                            TestAddress1 = "1 Harbor Cottages",
                            TestAddress2 = "Sayre Crescent",
                            SuburbID = 56,
                            DateAssigned = Convert.ToDateTime("13/11/2021"),
                            NurseID = 1, //Dorothy
                            StartTime = Convert.ToDateTime("13/11/2021 14:00:00"),
                            EndTime = Convert.ToDateTime("13/11/2021 16:00:00"),
                            CalendarEventID = 6
                            //10- 12,
                            //14- 16pm
                        },

                          new TestRequest
                          {
                              TestRequestID = 7,
                              RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                              RequestStatus = TestRequestStatus.New,
                              PatientId = 4,//Kopano
                              DependentID = null,
                              TestAddress1 = "27 Aspen Complex",
                              TestAddress2 = "La Roche Drive",
                              SuburbID = 57,
                              DateAssigned = null,
                              NurseID = null

                          },

                           new TestRequest
                           {
                               TestRequestID = 8,
                               RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                               RequestStatus = TestRequestStatus.New,
                               PatientId = 5,//Karien
                               DependentID = null,
                               TestAddress1 = "6 Rubin Crescent",
                               TestAddress2 = null,
                               SuburbID = 126,
                               DateAssigned = null,
                               NurseID = null

                           },

                               new TestRequest
                               {
                                   TestRequestID = 9,
                                   RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                   RequestStatus = TestRequestStatus.New,
                                   PatientId = 6,//Felcity
                                   DependentID = null,
                                   TestAddress1 = "28 7th Avenue",
                                   TestAddress2 = null,
                                   SuburbID = 127,
                                   DateAssigned = null,
                                   NurseID = null

                               },

                                    new TestRequest
                                    {
                                        TestRequestID = 10,
                                        RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                        RequestStatus = TestRequestStatus.New,
                                        PatientId = 7,//Errol
                                        DependentID = null,
                                        TestAddress1 = "37 The Beaches",
                                        TestAddress2 = "Beach Road",
                                        SuburbID = 56,
                                        DateAssigned = null,
                                        NurseID = null

                                    },

                                     new TestRequest
                                     {
                                         TestRequestID = 11,
                                         RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                         RequestStatus = TestRequestStatus.New,
                                         PatientId = 8,//Alyce
                                         DependentID = null,
                                         TestAddress1 = "12 Marshall Road",
                                         TestAddress2 = null,
                                         SuburbID = 57,
                                         DateAssigned = null,
                                         NurseID = null

                                     },

                                         new TestRequest
                                         {
                                             TestRequestID = 12,
                                             RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                             RequestStatus = TestRequestStatus.New,
                                             PatientId = 9,//Asha
                                             DependentID = null,
                                             TestAddress1 = "13 Congo Avenue",
                                             TestAddress2 = null,
                                             SuburbID = 84,
                                             DateAssigned = null,
                                             NurseID = null

                                         },

                                          new TestRequest
                                          {
                                              TestRequestID = 13,
                                              RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                              RequestStatus = TestRequestStatus.New,
                                              PatientId = 10,//Carlos
                                              DependentID = null,
                                              TestAddress1 = "29 Peace Street",
                                              TestAddress2 = null,
                                              SuburbID = 84,
                                              DateAssigned = null,
                                              NurseID = null

                                          },

                                                    new TestRequest
                                                    {
                                                        TestRequestID = 14,
                                                        RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                                        RequestStatus = TestRequestStatus.New,
                                                        PatientId = 11,//Kabelo
                                                        DependentID = null,
                                                        TestAddress1 = "7 Jacks Road",
                                                        TestAddress2 = null,
                                                        SuburbID = 84,
                                                        DateAssigned = null,
                                                        NurseID = null

                                                    },

                                                    new TestRequest
                                                    {
                                                        TestRequestID = 15,
                                                        RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                                        RequestStatus = TestRequestStatus.Scheduled,
                                                        PatientId = 12,//Pulane
                                                        DependentID = null,
                                                        TestAddress1 = "45 Columbia Crescent",
                                                        TestAddress2 = null,
                                                        SuburbID = 84,
                                                        DateAssigned = Convert.ToDateTime("12/11/2021"),
                                                        NurseID = 9, //dorothy,
                                                        StartTime = Convert.ToDateTime("13/11/2021 08:00:00"),
                                                        EndTime = Convert.ToDateTime("13/11/2021 10:00:00"),
                                                        CalendarEventID = null

                                                    },

                                                       //CLOSED TEST REQUESTS
                                                       new TestRequest
                                                       {
                                                           TestRequestID = 16,
                                                           RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                           RequestStatus = TestRequestStatus.Closed,
                                                           PatientId = 1,//Charmaine
                                                           DependentID = null,
                                                           TestAddress1 = "19 Admirality Way",
                                                           TestAddress2 = null,
                                                           SuburbID = 126,
                                                           DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                           NurseID = 1, //Dorothy
                                                           StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                           EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),
                                                           //10- 12,

                                                       },

                                                         new TestRequest
                                                         {
                                                             TestRequestID = 17,
                                                             RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                             RequestStatus = TestRequestStatus.Closed,
                                                             PatientId = 1,//Charmaine
                                                             DependentID = 91,//Daleen
                                                             TestAddress1 = "19 Admirality Way",
                                                             TestAddress2 = null,
                                                             SuburbID = 126,
                                                             DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                             NurseID = 1, //Dorothy
                                                             StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                             EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),

                                                         },

                                                              new TestRequest
                                                              {
                                                                  TestRequestID = 18,
                                                                  RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                                  RequestStatus = TestRequestStatus.Closed,
                                                                  PatientId = 1,//Charmaine
                                                                  DependentID = 92,//Vince
                                                                  TestAddress1 = "19 Admirality Way",
                                                                  TestAddress2 = null,
                                                                  SuburbID = 126,
                                                                  DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                                  NurseID = 1,
                                                                  StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                                  EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),//Dorothy
                                                                                                                      //10:00 -12:00
                                                              },

                                                              new TestRequest
                                                              {
                                                                  TestRequestID = 19,
                                                                  RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                                  RequestStatus = TestRequestStatus.Closed,
                                                                  PatientId = 1,//Charmaine
                                                                  DependentID = 93,//Vanessa
                                                                  TestAddress1 = "19 Admirality Way",
                                                                  TestAddress2 = null,
                                                                  SuburbID = 126,
                                                                  DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                                  NurseID = 1,
                                                                  StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                                  EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),//Dorothy
                                                                  //10:00 -12:00
                                                              },

                                                                new TestRequest
                                                                {
                                                                    TestRequestID = 20,
                                                                    RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                                    RequestStatus = TestRequestStatus.Closed,
                                                                    PatientId = 1,//Charmaine
                                                                    DependentID = 94,//Daniel
                                                                    TestAddress1 = "19 Admirality Way",
                                                                    TestAddress2 = null,
                                                                    SuburbID = 126,
                                                                    DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                                    NurseID = 1, //Dorothy
                                                                    StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                                    EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),
                                                                    //10:00 -12:00
                                                                },

                                                                 new TestRequest
                                                                 {
                                                                     TestRequestID = 21,
                                                                     RequestDate = Convert.ToDateTime("2021-02-12  10:00:00"),
                                                                     RequestStatus = TestRequestStatus.Closed,
                                                                     PatientId = 3,//David
                                                                     DependentID = null,
                                                                     TestAddress1 = "1 Harbor Cottages",
                                                                     TestAddress2 = "Sayre Crescent",
                                                                     SuburbID = 56,
                                                                     DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                     NurseID = 15, //Marcel
                                                                     StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                     EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                     //12:00 -14:00
                                                                 },

                                                                   new TestRequest
                                                                   {
                                                                       TestRequestID = 22,
                                                                       RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                       RequestStatus = TestRequestStatus.Closed,
                                                                       PatientId = 4,//Kopano
                                                                       DependentID = null,
                                                                       TestAddress1 = "27 Aspen Complex",
                                                                       TestAddress2 = "La Roche Drive",
                                                                       SuburbID = 57,
                                                                       DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                       NurseID = 1, //Dorothy
                                                                       StartTime = Convert.ToDateTime("13/02/2021 10:00:00"),
                                                                       EndTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                       //10:00 -12:00
                                                                   },

                                                                     new TestRequest
                                                                     {
                                                                         TestRequestID = 23,
                                                                         RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                         RequestStatus = TestRequestStatus.Closed,
                                                                         PatientId = 5,//Karien
                                                                         DependentID = null,
                                                                         TestAddress1 = "6 Rubin Crescent",
                                                                         TestAddress2 = null,
                                                                         SuburbID = 126,
                                                                         DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                         NurseID = 1, //Dorothy
                                                                         StartTime = Convert.ToDateTime("13/02/2021 10:00:00"),
                                                                         EndTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                         //10:00 -12:00
                                                                     },

                                                                        new TestRequest
                                                                        {
                                                                            TestRequestID = 24,
                                                                            RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                            RequestStatus = TestRequestStatus.Closed,
                                                                            PatientId = 6,//Felicity
                                                                            DependentID = null,
                                                                            TestAddress1 = "28 7th Avenue",
                                                                            TestAddress2 = null,
                                                                            SuburbID = 127,
                                                                            DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                            NurseID = 1, //Dorothy
                                                                            StartTime = Convert.ToDateTime("13/02/2021 10:00:00"),
                                                                            EndTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                            //10:00 -12:00
                                                                        },

                                                                           new TestRequest
                                                                           {
                                                                               TestRequestID = 25,
                                                                               RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                               RequestStatus = TestRequestStatus.Closed,
                                                                               PatientId = 7,//Errol
                                                                               DependentID = null,
                                                                               TestAddress1 = "37 The Beaches",
                                                                               TestAddress2 = "Beach Road",
                                                                               SuburbID = 56,
                                                                               DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                               NurseID = 15, //Marcel
                                                                               StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                               EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                               //12:00 -14:00
                                                                           },
                                                                             new TestRequest
                                                                             {
                                                                                 TestRequestID = 26,
                                                                                 RequestDate = Convert.ToDateTime("2021-02-12 10:00"),
                                                                                 RequestStatus = TestRequestStatus.Closed,
                                                                                 PatientId = 8,//Alyce
                                                                                 DependentID = null,
                                                                                 TestAddress1 = "12 Marshall Road",
                                                                                 TestAddress2 = null,
                                                                                 SuburbID = 57,
                                                                                 DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                                 NurseID = 15, //Marcel
                                                                                 StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                                 EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                                 //12:00 -14:00
                                                                             },
                                                                             new TestRequest
                                                                             {
                                                                                 TestRequestID = 27,
                                                                                 RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                                 RequestStatus = TestRequestStatus.Closed,
                                                                                 PatientId = 9,//Asha
                                                                                 DependentID = null,
                                                                                 TestAddress1 = "13 Congo Avenue",
                                                                                 TestAddress2 = null,
                                                                                 SuburbID = 84,
                                                                                 DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                                 NurseID = 15, //Marcel
                                                                                 StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                                 EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                                 //12:00 -14:00
                                                                             },

                                                                                    new TestRequest
                                                                                    {
                                                                                        TestRequestID = 28,
                                                                                        RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                                        RequestStatus = TestRequestStatus.Closed,
                                                                                        PatientId = 10,//Carlos
                                                                                        DependentID = null,
                                                                                        TestAddress1 = "29 Peace Street",
                                                                                        TestAddress2 = null,
                                                                                        SuburbID = 84,
                                                                                        DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                                        NurseID = 15, //Marcel
                                                                                        StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                                        EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                                        //12:00 -14:00
                                                                                    },

                                                                                      new TestRequest
                                                                                      {
                                                                                          TestRequestID = 29,
                                                                                          RequestDate = Convert.ToDateTime("2021-02-27 10:00:00"),
                                                                                          RequestStatus = TestRequestStatus.Closed,
                                                                                          PatientId = 11,//Kabelo
                                                                                          DependentID = null,
                                                                                          TestAddress1 = "7 Jacks Road",
                                                                                          TestAddress2 = null,
                                                                                          SuburbID = 84,
                                                                                          DateAssigned = Convert.ToDateTime("2021-02-28"),
                                                                                          NurseID = 1, //Dorothy
                                                                                          StartTime = Convert.ToDateTime("28/02/2021 14:00:00"),
                                                                                          EndTime = Convert.ToDateTime("28/02/2021 16:00:00"),
                                                                                          //14:00 -16:00
                                                                                      },
                                                                                              new TestRequest
                                                                                              {
                                                                                                  TestRequestID = 30,
                                                                                                  RequestDate = Convert.ToDateTime("2021-02-27 10:00:00"),
                                                                                                  RequestStatus = TestRequestStatus.Closed,
                                                                                                  PatientId = 12,//Pulane
                                                                                                  DependentID = null,
                                                                                                  TestAddress1 = "45 Columbia Crescent",
                                                                                                  TestAddress2 = null,
                                                                                                  SuburbID = 84,
                                                                                                  DateAssigned = Convert.ToDateTime("2021-02-28"),
                                                                                                  NurseID = 1, //dorothy
                                                                                                  StartTime = Convert.ToDateTime("28/02/2021 14:00:00"),
                                                                                                  EndTime = Convert.ToDateTime("28/02/2021 16:00:00"),
                                                                                                  //14:00 -16:00
                                                                                              }

                 );
        }

        #endregion SeedTestRequests

        #region SeedCalenderEvents

        public static void SeedingCalenderEvents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalendarEvent>().HasData(
               new CalendarEvent
               {
                   ID = 1,
                   Title = "19 Admirality Way",
                   Description = "19 Admirality Way" + " " + "Summerstrand",
                   Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                   End = Convert.ToDateTime("12/11/2021 12:00:00"),
                   AllDay = false
               },
                new CalendarEvent
                {
                    ID = 2,
                    Title = "19 Admirality Way",
                    Description = "19 Admirality Way" + " " + "Summerstrand",
                    Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                    End = Convert.ToDateTime("12/11/2021 12:00:00"),
                    AllDay = false
                },
                  new CalendarEvent
                  {
                      ID = 3,
                      Title = "19 Admirality Way",
                      Description = "19 Admirality Way" + " " + "Summerstrand",
                      Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                      End = Convert.ToDateTime("12/11/2021 12:00:00"),
                      AllDay = false
                  },
                   new CalendarEvent
                   {
                       ID = 4,
                       Title = "19 Admirality Way",
                       Description = "19 Admirality Way" + " " + "Summerstrand",
                       Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                       End = Convert.ToDateTime("12/11/2021 12:00:00"),
                       AllDay = false
                   },
                    new CalendarEvent
                    {
                        ID = 5,
                        Title = "19 Admirality Way",
                        Description = "19 Admirality Way" + " " + "Summerstrand",
                        Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                        End = Convert.ToDateTime("12/11/2021 12:00:00"),
                        AllDay = false
                    },
                       new CalendarEvent
                       {
                           ID = 6,
                           Title = "1 Harbor Cottages",
                           Description = "1 Harbor Cottages" + " " + "Humerail",
                           Start = Convert.ToDateTime("13/11/2021 10:00:00"),
                           End = Convert.ToDateTime("13/11/2021 12:00:00"),
                           AllDay = false
                       }







                 );
        }

        #endregion SeedCalenderEvents

        #region SeedTests

        public static void SeedingTests(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasData(
               new Test
               {
                   TestID = 1,
                   TestRequestID = 16,
                   LabUserID = 1,
                   BarCode = "PENDCCOV-001",
                   TestResult = "Positive",
                   Temperature = 37.5,
                   BloodPressure = "124/79",
                   OxygenLevel = 95,
                   ResultDate = Convert.ToDateTime("2021-02-03 08:00:00"),
                   TestDate = Convert.ToDateTime("2021-02-01"),
                   TestTime = Convert.ToDateTime("2021-02-01 10:15:00")

               },
                new Test
                {
                    TestID = 2,
                    TestRequestID = 17,
                    LabUserID = 1,
                    BarCode = "PENDCCOV-002",
                    TestResult = "Positive",
                    Temperature = 38.2,
                    BloodPressure = "120/80",
                    OxygenLevel = 97,
                    ResultDate = Convert.ToDateTime("2021-02-03 08:05:00"),
                    TestDate = Convert.ToDateTime("2021-02-01"),
                    TestTime = Convert.ToDateTime("2021-02-01 10:35:00")

                },
                new Test
                {
                    TestID = 3,
                    TestRequestID = 18,
                    LabUserID = 1,
                    BarCode = "PENDCCOV-003",
                    TestResult = "Negative",
                    Temperature = 34.6,
                    BloodPressure = "124/79",
                    OxygenLevel = 99,
                    ResultDate = Convert.ToDateTime("2021-02-03 08:05:00"),
                    TestDate = Convert.ToDateTime("2021-02-01"),
                    TestTime = Convert.ToDateTime("2021-02-01 10:48:00")


                },
                  new Test
                  {
                      TestID = 4,
                      TestRequestID = 19,
                      LabUserID = 1,
                      BarCode = "PENDCCOV-004",
                      TestResult = "Negative",
                      Temperature = 35.8,
                      BloodPressure = "120/80",
                      OxygenLevel = 99,
                      ResultDate = Convert.ToDateTime("2021-02-03 08:05:00"),
                      TestDate = Convert.ToDateTime("2021-02-01"),
                      TestTime = Convert.ToDateTime("2021-02-01 11:10:00")


                  },
                   new Test
                   {
                       TestID = 5,
                       TestRequestID = 20,
                       LabUserID = 1,
                       BarCode = "PENDCCOV-005",
                       TestResult = "Positive",
                       Temperature = 37.9,
                       BloodPressure = "124/79",
                       OxygenLevel = 90,
                       ResultDate = Convert.ToDateTime("2021-02-03 08:12:00"),
                       TestDate = Convert.ToDateTime("2021-02-01"),
                       TestTime = Convert.ToDateTime("2021-02-01 11:29:00")

                   },

                     new Test
                     {
                         TestID = 6,
                         TestRequestID = 21,
                         LabUserID = 1,
                         BarCode = "PENDCCOV-006",
                         TestResult = "Negative",
                         Temperature = 35.1,
                         BloodPressure = "120/80",
                         OxygenLevel = 100,
                         ResultDate = Convert.ToDateTime("2021-02-15 09:12:00"),
                         TestDate = Convert.ToDateTime("2021-02-13"),
                         TestTime = Convert.ToDateTime("2021-02-13 12:11:00")

                     },
                      new Test
                      {
                          TestID = 7,
                          TestRequestID = 22,
                          LabUserID = 1,
                          BarCode = "PENDCCOV-007",
                          TestResult = "Positive",
                          Temperature = 36.9,
                          BloodPressure = "124/79",
                          OxygenLevel = 92,
                          ResultDate = Convert.ToDateTime("2021-02-15 08:12:00"),
                          TestDate = Convert.ToDateTime("2021-02-13"),
                          TestTime = Convert.ToDateTime("2021-02-13 10:11:00")

                      },
                       new Test
                       {
                           TestID = 8,
                           TestRequestID = 23,
                           LabUserID = 1,
                           BarCode = "PENDCCOV-008",
                           TestResult = "Positive",
                           Temperature = 37.4,
                           BloodPressure = "120/80",
                           OxygenLevel = 91,
                           ResultDate = Convert.ToDateTime("2021-02-15 08:12:00"),
                           TestDate = Convert.ToDateTime("2021-02-13"),
                           TestTime = Convert.ToDateTime("2021-02-13 10:37:00")

                       },
                        new Test
                        {
                            TestID = 9,
                            TestRequestID = 24,
                            LabUserID = 1,
                            BarCode = "PENDCCOV-009",
                            TestResult = "Positive",
                            Temperature = 38.1,
                            BloodPressure = "124/79",
                            OxygenLevel = 93,
                            ResultDate = Convert.ToDateTime("2021-02-15 08:19:00"),
                            TestDate = Convert.ToDateTime("2021-02-13"),
                            TestTime = Convert.ToDateTime("2021-02-13 11:01:00")

                        },
                         new Test
                         {
                             TestID = 10,
                             TestRequestID = 25,
                             LabUserID = 1,
                             BarCode = "PENDCCOV-0010",
                             TestResult = "Negative",
                             Temperature = 34.5,
                             BloodPressure = "120/80",
                             OxygenLevel = 100,
                             ResultDate = Convert.ToDateTime("2021-02-15 09:17:00"),
                             TestDate = Convert.ToDateTime("2021-02-13"),
                             TestTime = Convert.ToDateTime("2021-02-13 12:55:00")

                         },
                          new Test
                          {
                              TestID = 11,
                              TestRequestID = 26,
                              LabUserID = 1,
                              BarCode = "PENDCCOV-0011",
                              TestResult = "Positive",
                              Temperature = 37.2,
                              BloodPressure = "124/79",
                              OxygenLevel = 91,
                              ResultDate = Convert.ToDateTime("2021-02-15 09:12:00"),
                              TestDate = Convert.ToDateTime("2021-02-13"),
                              TestTime = Convert.ToDateTime("2021-02-13 13:11:00")

                          },
                           new Test
                           {
                               TestID = 12,
                               TestRequestID = 27,
                               LabUserID = 1,
                               BarCode = "PENDCCOV-0012",
                               TestResult = "Negative",
                               Temperature = 34.2,
                               BloodPressure = "120/80",
                               OxygenLevel = 99,
                               ResultDate = Convert.ToDateTime("2021-02-15 09:12:00"),
                               TestDate = Convert.ToDateTime("2021-02-13"),
                               TestTime = Convert.ToDateTime("2021-02-13 13:29:00")

                           },
                            new Test
                            {
                                TestID = 13,
                                TestRequestID = 28,
                                LabUserID = 1,
                                BarCode = "PENDCCOV-0013",
                                TestResult = "Positive",
                                Temperature = 38.2,
                                BloodPressure = "124/79",
                                OxygenLevel = 92,
                                ResultDate = Convert.ToDateTime("2021-02-15 09:12:00"),
                                TestDate = Convert.ToDateTime("2021-02-13"),
                                TestTime = Convert.ToDateTime("2021-02-13 13:46:00")

                            },
                             new Test
                             {
                                 TestID = 14,
                                 TestRequestID = 29,
                                 LabUserID = 1,
                                 BarCode = "PENDCCOV-0014",
                                 TestResult = "Positive",
                                 Temperature = 37.9,
                                 BloodPressure = "120/80",
                                 OxygenLevel = 93,
                                 ResultDate = Convert.ToDateTime("2021-03-01 07:12:00"),
                                 TestDate = Convert.ToDateTime("2021-02-28"),
                                 TestTime = Convert.ToDateTime("2021-02-28 14:20:00")

                             },
                                new Test
                                {
                                    TestID = 15,
                                    TestRequestID = 30,
                                    LabUserID = 1,
                                    BarCode = "PENDCCOV-0015",
                                    TestResult = "Positive",
                                    Temperature = 38.5,
                                    BloodPressure = "124/79",
                                    OxygenLevel = 94,
                                    ResultDate = Convert.ToDateTime("2021-03-01 07:28:00"),
                                    TestDate = Convert.ToDateTime("2021-02-28"),
                                    TestTime = Convert.ToDateTime("2021-02-28 14:41:00")

                                }



                 );
        }

        #endregion SeedTests
    }
}
