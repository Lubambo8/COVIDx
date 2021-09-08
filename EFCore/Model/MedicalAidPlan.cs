using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class MedicalAidPlan
    {
        public int MedicalAidPlanID { get; set; }
        public string Description { get; set; }
        public int MedicalAidSchemeID { get; set; }
    }
}
