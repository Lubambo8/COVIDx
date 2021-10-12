using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCore.Model
{
    public partial class SuburbsPreferred
    {
        [Required]
        public int SuburbID { get; set; }

        [Required]
        public int NurseID { get; set; }

        [ForeignKey(nameof(NurseID))]
        public virtual Nurse Nurse { get; set; }

        [ForeignKey(nameof(SuburbID))]
        public virtual Suburb Suburb { get; set; }
    }
}
