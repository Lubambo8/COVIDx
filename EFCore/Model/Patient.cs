using EFCore.EFCoreConfigurationMethods;
using EFCore.Model;
using EFCore.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



#nullable disable

namespace EFCore.Model
{
    public partial class Patient : IPatient
    {
        public Patient()
        {
            Dependents = new HashSet<Dependent>();
            TestRequests = new HashSet<TestRequest>();
        }

        [Key]
        public int PatientID { get; set; }

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
            MaxLength(10)]
        public string MobileNumber { get; set; }

        [Required,
            MaxLength(1024)]
        public string AddressLine1 { get; set; }

        [MaxLength(1024)]
        public string AddressLine2 { get; set; }

        [Required]
        public int SuburbID { get; set; }

        [Required]
        public bool MedicalAidStatus { get; set; }

        [Display(Name = "Medical Aid")]
        public int? MedicalAidPlanID { get; set; }

        [MaxLength(128)]
        public string MedicalAidNo { get; set; }

        [MaxLength(128)]
        public string DependencyCode { get; set; }

        [Required,
            Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string PersonResponsible { get; set; }

        [Required]
        public Genders Gender { get; set; }

        [ForeignKey(nameof(EFCoreIdentityUser))]
        public string UserID { get; set; }

        [ForeignKey(nameof(MedicalAidPlanID))]
        public virtual MedicalAidPlan MedicalAidPlan { get; set; }

        [ForeignKey(nameof(SuburbID))]
        public virtual Suburb Suburb { get; set; }

        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<TestRequest> TestRequests { get; set; }

        [MaxLength(1024),
            Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}
