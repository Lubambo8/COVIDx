using EFCore.Model;
using EFCore.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Models.ViewModel
{
    public class PatientCreateViewModel : IPatient
    {
        public TestRequestViewModel TestRequest { get; set; }
        public string UserID { get; set; }

        public string Avatar { get; set; }

        public AlertModel Alert { get; set; }

        [Required(ErrorMessage = "First Name is required"),
            MaxLength(128)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required"),
            MaxLength(128)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "ID Number is required")]
        [RegularExpression(@"[0-9]{13}", ErrorMessage = "ID Number is Invalid")]
        [StringLength(13, ErrorMessage = "ID number should be 13 characters")]
        public string IDnumber { get; set; }

        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Mobile Number is Invalid")]
        [StringLength(10, ErrorMessage = "Mobile number should be 10 digits")]
        public string MobileNumber { get; set; }

        [Required]
        public int SuburbID { get; set; }

        [Required(ErrorMessage = "Date of Birth is Required"),
            Display(Name = "Date Of Birth")]

        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Address is Required"),
            MaxLength(1024)]
        public string AddressLine1 { get; set; }

        [MaxLength(128)]
        public string AddressLine2 { get; set; }

        [Required]
        public bool MedicalAidStatus { get; set; } = false;
        public int? MedicalAidPlanID { get; set; }
        public string MedicalAidNo { get; set; }
        public string DependencyCode { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Genders Gender { get; set; }
        public string EmailAddress { get; set; }
        public int PatientID { get; set; }

        [Required(ErrorMessage = "Person responsile for accounts is required")]
        public string PersonResponsible { get; set; }
    }
}

