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

        public static IQueryable<TestRequest> GetTestRequests(this DbSet<TestRequest> requests)
        {
            return requests
                .Include(req => req.CalendarEvents)
                .Include(req => req.Patient)
                .Include(req => req.Suburb)
                .Include(req => req.Nurse);
        }

        public static List<MedicalAidPlan> GetMedicalAidDetailList(this DbSet<MedicalAidPlan> plans)
        {
            return plans.Include(plan => plan.MedicalAidScheme).ToList();
        }
    }
}
