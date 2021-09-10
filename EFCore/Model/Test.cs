using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class Test
    {
        public int TestId { get; set; }
        public string BarCode { get; set; }
        public string Temperature { get; set; }
        public string BloodPressure { get; set; }
        public string OxygenLevel { get; set; }
        public DateTime TestDate { get; set; }
        public TimeSpan TestTime { get; set; }
        public string TestResult { get; set; }
        public DateTime ResultDate { get; set; }
        public int LabUserId { get; set; }

        public virtual LabUser LabUser { get; set; }
        public virtual TestRequest TestRequest { get; set; }
    }
}
