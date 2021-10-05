using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Authentication
{
    public class CovidXUser : IdentityUser
    {
        public string Avatar { get; set; }
        public bool Active { get; set; }
        public string UserType { get; set; }
        public int? NurseID { get; set; }
        public int? PatientID { get; set; }
    }
}
