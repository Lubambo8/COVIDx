using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCore.Model
{
    public partial class NurseSchedule
    {
        [Required]
        public int TestRequestID { get; set; }

        [Key]
        public int NurseID { get; set; }

        public virtual Nurse Nurse { get; set; }
    }
}
