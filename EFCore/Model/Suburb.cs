using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class Suburb
    {
        public Suburb()
        {
            Dependents = new HashSet<Dependent>();
            Patients = new HashSet<Patient>();
            TestRequests = new HashSet<TestRequest>();
        }

        public int SuburbId { get; set; }
        public string SuburbName { get; set; }
        public string PostalCode { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual SuburbsPreferred SuburbsPreferred { get; set; }
        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<TestRequest> TestRequests { get; set; }
    }
}
