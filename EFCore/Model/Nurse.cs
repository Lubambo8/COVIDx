using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class Nurse
    {
        public Nurse()
        {
            NurseSchedules = new HashSet<NurseSchedule>();
            SuburbsPreferreds = new HashSet<SuburbsPreferred>();
            TestRequests = new HashSet<TestRequest>();
        }

        public int NurseId { get; set; }
        public string Idnumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public DateTime YearsQualified { get; set; }
        public string Rank { get; set; }
        public string Qualification { get; set; }

        public virtual User NurseNavigation { get; set; }
        public virtual ICollection<NurseSchedule> NurseSchedules { get; set; }
        public virtual ICollection<SuburbsPreferred> SuburbsPreferreds { get; set; }
        public virtual ICollection<TestRequest> TestRequests { get; set; }
    }
}
