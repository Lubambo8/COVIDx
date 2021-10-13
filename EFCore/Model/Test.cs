using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCore.Model
{
    public partial class Test
    {
        [Key]
        public int TestID { get; set; }

        [Required,
            MaxLength(128)]
        public string BarCode { get; set; }

        [Required,
            MaxLength(128)]
        public string Temperature { get; set; }

        [Required,
            MaxLength(128)]
        public string BloodPressure { get; set; }

        [Required,
            MaxLength(128)]
        public string OxygenLevel { get; set; }

        [Required]
        public DateTime TestDate { get; set; }

        [Required]
        public TimeSpan TestTime { get; set; }

        [ MaxLength(128)]
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
