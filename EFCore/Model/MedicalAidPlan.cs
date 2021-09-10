using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class MedicalAidPlan
    {
        public MedicalAidPlan()
        {
            Dependents = new HashSet<Dependent>();
            Patients = new HashSet<Patient>();
        }

        public int MedicalAidPlanId { get; set; }
        public string Description { get; set; }
        public int MedicalAidSchemeId { get; set; }

        public virtual MedicalAidScheme MedicalAidScheme { get; set; }
        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
