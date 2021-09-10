using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class LabUser
    {
        public LabUser()
        {
            Tests = new HashSet<Test>();
        }

        public int LabUserId { get; set; }
        public string Idnumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Qualification { get; set; }

        public virtual ICollection<Test> Tests { get; set; }
    }
}
