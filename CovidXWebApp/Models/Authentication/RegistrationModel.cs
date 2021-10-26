using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Email is required."),
            DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public AlertModel Alert { get; set; }
        [Required,
            MinLength(8),
            DataType(DataType.Password)]
        public string Password { get; set; }

        [Required,
            Compare(nameof(Password)),
            DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
