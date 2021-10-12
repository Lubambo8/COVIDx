using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCore.Model
{
    public partial class NurseSchedule
    {
        [Required]
        public int TestRequestID { get; set; }

        [Key]
        public int NurseID { get; set; }

        [ForeignKey(nameof(NurseID))]
        public virtual Nurse Nurse { get; set; }
    }
}
