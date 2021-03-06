using EFCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Models.ViewModel
{
    public class NurseCreateViewModel : INurse
    {
        public string UserID { get; set; }

        public string Avatar { get; set; }
        public AlertModel Alert { get; set; }
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

        [Required]
        public Rank Rank { get; set; }

        [Required(ErrorMessage = "Year of Qualification is required")]
        public DateTime YearsQualified { get; set; }
        public int SuburbID { get; set; }
    }
}
