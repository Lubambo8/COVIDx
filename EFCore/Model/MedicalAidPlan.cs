using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCore.Model
{
    public partial class MedicalAidPlan
    {
        public MedicalAidPlan()
        {
            Dependents = new HashSet<Dependent>();
            Patients = new HashSet<Patient>();
        }

        [Key]
        public int MedicalAidPlanID { get; set; }

        [Required,
            MaxLength(128)]
        public string Description { get; set; }

        [Required]
        public int MedicalAidSchemeID { get; set; }

        [ForeignKey(nameof(MedicalAidSchemeID))]
        public virtual MedicalAidScheme MedicalAidScheme { get; set; }
        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
