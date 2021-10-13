using EFCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCore.Model
{
    public partial class Dependent
    {
        [Key]
        public int DependentID { get; set; }

        [Required,
            MaxLength(128)]
        public string FirstName { get; set; }

        [Required,
            MaxLength(128)]
        public string LastName { get; set; }

        [Required,
            MaxLength(13)]
        public string IDnumber { get; set; }

        [Required,
            MaxLength(128)]
        public string EmailAddress { get; set; }

        [MaxLength(1024)]
        public string AddressLine1 { get; set; }

        [MaxLength(1024)]
        public string AddressLine2 { get; set; }

        public int? SuburbID { get; set; }

        [Required,
            Display(Name = "Date Of Birth")]
        public DateTime DateOfbirth { get; set; }

        [MaxLength(128)]
        public string MedicalAidNo { get; set; }

        [Display(Name = "Medical Aid")]
        public int? MedicalAidPlanID { get; set; }

        [Required]
        public bool MedicalAidStatus { get; set; }

        [Required,
            MaxLength(10)]
        public string MobileNumber { get; set; }

        [Required]
        public Relationships Relationship { get; set; }

        [MaxLength(128)]
        public string DependencyCode { get; set; }

        [Required]
        public int MainMemberID { get; set; }

        [Required]
        public Genders Gender { get; set; }

        [ForeignKey(nameof(MainMemberID))]
        public virtual Patient MainMember { get; set; }

        [ForeignKey(nameof(MedicalAidPlanID))]
        public virtual MedicalAidPlan MedicalAidPlan { get; set; }

        [ForeignKey(nameof(SuburbID))]
        public virtual Suburb Suburb { get; set; }
    }
}
