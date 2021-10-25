using EFCore.Model;
using EFCore.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Models.ViewModel
{
    public class PatientCreateViewModel : IPatient
    {
        public string UserID { get; set; }

        public string Avatar { get; set; }


        [Required(ErrorMessage = "First Name is required"),
            MaxLength(128)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required"),
            MaxLength(128)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "ID is required"), 
            MaxLength(13, ErrorMessage = "ID needs to be 13 digits")]
        public string IDnumber { get; set; }

        [Required(ErrorMessage = "Mobile Number is required"), 
            MaxLength(10, ErrorMessage = "Mobile needs to be 10 digits")]
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
    }
}

