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
    public class DependentCreateViewModel : IDependent
    {
        public AlertModel Alert { get; set; }
        [Required(ErrorMessage = "First Name is required"),
            MaxLength(128)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required"),
            MaxLength(128)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "ID Number is required"), MaxLength(13, ErrorMessage = "ID needs to be 13 digits")]
        public string Idnumber { get; set; }

        public string PersonResponsible { get; set; }
        //public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Mobile Number is required"), MaxLength(10, ErrorMessage = "Mobile needs to be 10 digits")]
        public string MobileNumber { get; set; }

        [Required]

        public string EmailAddress { get; set; }

        public bool AddressSameasMainMember { get; set; } = false;
        public bool MedicalAidSameasMainMember { get; set; }
        public string AddressLine1 { get; set; }


        public string AddressLine2 { get; set; }


        public int? SuburbID { get; set; }

        [Required,
            Display(Name = "Date of Birth")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Genders Gender { get; set; }
        [Required]
        public bool MedicalAidStatus { get; set; }


        public string MedicalAidNo { get; set; }
        public int? MedicalAidPlanId { get; set; }

        [Required(ErrorMessage = "Relationship type is required")]
        public Relationships Relationship { get; set; }


        public string DependencyCode { get; set; }

        //PatientID
        public int MainMemberID { get; set; }
        public int DependentID { get; set; }
    }
}
