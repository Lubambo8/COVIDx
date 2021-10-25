using EFCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Models.ViewModel
{
    public class NurseCreateViewModel : INurse
    {
        [Required(ErrorMessage = "Address Line is required"),
            MaxLength(1024)]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "First Name is required"),
            MaxLength(128)]
        public string FirstName { get; set; }

        [Required]
        public Genders Gender { get; set; }

        public string IDnumber { get; set; }

        [Required(ErrorMessage = "Last Name is required"),
            MaxLength(128)]
        public string LastName { get; set; }

        [Required,
            MaxLength(10)]
        public string MobileNumber { get; set; }
        public int NurseID { get; set; }

        [Required(ErrorMessage = "Qualification is required"),
            MaxLength(1024)]
        public string Qualification { get; set; }

        [Required]
        public string Rank { get; set; }
        public string UserID { get; set; }

        [Required(ErrorMessage = "Year of Qualification is required")]
        public DateTime YearsQualified { get; set; }
    }
}
