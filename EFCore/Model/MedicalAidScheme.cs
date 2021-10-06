using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCore.Model
{
    public partial class MedicalAidScheme
    {
        public MedicalAidScheme()
        {
            MedicalAidPlans = new HashSet<MedicalAidPlan>();
        }

        [Key]
        public int MedicalAidSchemeID { get; set; }

        [Required,
            MaxLength(128)]
        public string Description { get; set; }

        public virtual ICollection<MedicalAidPlan> MedicalAidPlans { get; set; }
    }
}
