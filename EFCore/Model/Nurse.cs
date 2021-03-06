using EFCore.EFCoreConfigurationMethods;
using EFCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCore.Model
{
    public partial class Nurse : INurse
    {
        public Nurse()
        {
            NurseSchedules = new HashSet<NurseSchedule>();
            SuburbsPreferreds = new HashSet<SuburbsPreferred>();
            TestRequests = new HashSet<TestRequest>();
        }

        [Key]
        public int NurseID { get; set; }

        [Required,
            MaxLength(13)]
        public string IDnumber { get; set; }

        [Required,
            MaxLength(128)]
        public string FirstName { get; set; }

        [Required,
            MaxLength(128)]
        public string LastName { get; set; }

        [Required,
            MaxLength(10)]
        public string MobileNumber { get; set; }

        [Required,
            MaxLength(128)]
        public string EmailAddress { get; set; }

        [Required,
            MaxLength(1024)]
        public string AddressLine1 { get; set; }

        [MaxLength(128)]
        public string AddressLine2 { get; set; }

        [Required]
        public int SuburbID { get; set; }

        [Required]
        public DateTime YearsQualified { get; set; }

        [Required,
            MaxLength(128)]
        public Rank Rank { get; set; }


        [ForeignKey(nameof(EFCoreIdentityUser))]
        public string UserID { get; set; }

        [Required]
        public Genders Gender { get; set; }

        public virtual ICollection<NurseSchedule> NurseSchedules { get; set; }
        public virtual ICollection<SuburbsPreferred> SuburbsPreferreds { get; set; }
        public virtual ICollection<TestRequest> TestRequests { get; set; }
    }
}
