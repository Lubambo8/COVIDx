using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class NurseSchedule
    {
        public int TestRequestId { get; set; }
        public int NurseId { get; set; }

        public virtual Nurse Nurse { get; set; }
    }
}
