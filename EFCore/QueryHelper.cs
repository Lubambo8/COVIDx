using EFCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public static class QueryHelper
    {
        public static IQueryable<MedicalAidPlan> GetMedicalAidDetail(this DbSet<MedicalAidPlan> plans)
        {
            return plans.Include(plan => plan.MedicalAidScheme);
        }

        public static List<MedicalAidPlan> GetMedicalAidDetailList(this DbSet<MedicalAidPlan> plans)
        {
            return plans.Include(plan => plan.MedicalAidScheme).ToList();
        }
    }
}
