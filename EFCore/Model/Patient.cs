using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class Patient
    {
        public Patient()
        {
            Dependents = new HashSet<Dependent>();
            TestRequests = new HashSet<TestRequest>();
        }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Idnumber { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int SuburbId { get; set; }
        public bool MedicalAidStatus { get; set; }
        public int MedicalAidPlanId { get; set; }
        public int MedicalAidNo { get; set; }
        public int DependencyCode { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual MedicalAidPlan MedicalAidPlan { get; set; }
        public virtual User PatientNavigation { get; set; }
        public virtual Suburb Suburb { get; set; }
        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<TestRequest> TestRequests { get; set; }
    }
}
