using EFCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required,
            MaxLength(1024)]
        public string AddressLine1 { get; set; }

        [MaxLength(1024)]
        public string AddressLine2 { get; set; }

        [Required]
        public int SuburbID { get; set; }

        [Required]
        public DateTime DateOfbirth { get; set; }

        [Required]
        public int MedicalAidPlanID { get; set; }

        [Required]
        public bool MedicalAidStatus { get; set; }

        [Required,
            MaxLength(10)]
        public string MobileNumber { get; set; }

        [Required]
        public int RelationshipTypeID { get; set; }

        [Required]
        public int DependencyCode { get; set; }

        [Required]
        public int MainMemberID { get; set; }

        [Required]
        public Genders Gender { get; set; }

        public virtual Patient MainMember { get; set; }
        public virtual MedicalAidPlan MedicalAidPlan { get; set; }
        public virtual DependentRelationship RelationshipType { get; set; }
        public virtual Suburb Suburb { get; set; }
    }
}
