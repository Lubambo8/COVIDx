using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class SuburbsPreferred
    {
        public int SuburbId { get; set; }
        public int NurseId { get; set; }

        public virtual Nurse Nurse { get; set; }
        public virtual Suburb Suburb { get; set; }
    }
}
