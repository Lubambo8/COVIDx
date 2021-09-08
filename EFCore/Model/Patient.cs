using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int SuburbID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MedicalAidPlanID { get; set; }
        public bool MedicalAidStatus { get; set; }
        public string MedicalAidNo { get; set; }
        public string MobileNumber { get; set; }
        public string DependencyCode { get; set; }
    }
}
