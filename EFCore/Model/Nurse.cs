using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class Nurse
    {
        public int NurseID { get; set; }
        public string IDNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public DateTime YearsQualified { get; set; }
        public string Rank { get; set; }
        public string Qualification { get; set; }
    }
}
