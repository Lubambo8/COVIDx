using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class MedicalAidScheme
    {
        public MedicalAidScheme()
        {
            MedicalAidPlans = new HashSet<MedicalAidPlan>();
        }

        public int MedicalAidSchemeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MedicalAidPlan> MedicalAidPlans { get; set; }
    }
}
