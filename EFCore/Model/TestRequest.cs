using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class TestRequest
    {
        public int TestRequestId { get; set; }
        public int PatientId { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestStatus { get; set; }
        public string TestAddress1 { get; set; }
        public string TestAddress2 { get; set; }
        public int SuburbId { get; set; }
        public int NurseId { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime TimeSlotAssigned { get; set; }

        public virtual Nurse Nurse { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Suburb Suburb { get; set; }
        public virtual Test TestRequestNavigation { get; set; }
    }
}
