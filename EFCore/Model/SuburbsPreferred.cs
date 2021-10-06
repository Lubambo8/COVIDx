using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCore.Model
{
    public partial class SuburbsPreferred
    {
        [Required]
        public int SuburbID { get; set; }

        [Required]
        public int NurseID { get; set; }

        public virtual Nurse Nurse { get; set; }
        public virtual Suburb Suburb { get; set; }
    }
}
