using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCore.Model
{
    public partial class Test : ITest
    {
        [Key]
        public int TestID { get; set; }

        [Required,
            MaxLength(128)]
        public string BarCode { get; set; }

        [Required,
            MaxLength(128)]
        public double Temperature { get; set; }

        [Required,
            MaxLength(128)]
        public string BloodPressure { get; set; }

        [Required,
            MaxLength(128)]
        public int OxygenLevel { get; set; }

        [Required]
        public DateTime TestDate { get; set; }

        [Required]
        public DateTime TestTime { get; set; }

        [MaxLength(128)]
        public string TestResult { get; set; }

        public DateTime? ResultDate { get; set; }


        public int? LabUserID { get; set; }

        [Required]
        public int TestRequestID { get; set; }

        [ForeignKey(nameof(LabUserID))]
        public virtual LabUser LabUser { get; set; }

        [ForeignKey(nameof(TestRequestID))]
        public virtual TestRequest TestRequest { get; set; }
    }
}
