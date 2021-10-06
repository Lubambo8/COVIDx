using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCore.Model
{
    public partial class Suburb
    {
        public Suburb()
        {
            Dependents = new HashSet<Dependent>();
            Patients = new HashSet<Patient>();
            TestRequests = new HashSet<TestRequest>();
        }

        [Key]
        public int SuburbID { get; set; }

        [Required,
            MaxLength(128)]
        public string SuburbName { get; set; }

        [Required,
            MaxLength(128)]
        public string PostalCode { get; set; }

        [Required]
        public int CityID { get; set; }

        public virtual City City { get; set; }
        public virtual SuburbsPreferred SuburbsPreferred { get; set; }
        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<TestRequest> TestRequests { get; set; }
    }
}
