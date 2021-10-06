using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCore.Model
{
    public partial class TestRequest
    {
        [Key]
        public int TestRequestID { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public DateTime RequestDate { get; set; }

        [Required,
            MaxLength(128)]
        public string RequestStatus { get; set; }

        [Required,
            MaxLength(1024)]
        public string TestAddress1 { get; set; }

        [MaxLength(128)]
        public string TestAddress2 { get; set; }

        [Required]
        public int SuburbID { get; set; }

        [Required]
        public int NurseID { get; set; }

        [Required]
        public DateTime DateAssigned { get; set; }

        [Required]
        public DateTime TimeSlotAssigned { get; set; }

        public virtual Nurse Nurse { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Suburb Suburb { get; set; }
        public virtual Test Test { get; set; }
    }
}
