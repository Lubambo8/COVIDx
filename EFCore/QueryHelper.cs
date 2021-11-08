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

        public static IQueryable<TestRequest> GetDetails(this DbSet<TestRequest> requests)
        {
            return requests
                .Include(req => req.CalendarEvents)
                .Include(req => req.Patient)
                .Include(req => req.Suburb)
                .Include(req => req.Dependent)
                    .ThenInclude(dep => dep.Suburb)
                .Include(req => req.Nurse);
        }

        public static List<MedicalAidPlan> GetMedicalAidDetailList(this DbSet<MedicalAidPlan> plans)
        {
            return plans.Include(plan => plan.MedicalAidScheme).ToList();
        }

        public static IQueryable<Patient> GetDetails(this DbSet<Patient> patients)
        {
            return patients
                .Include(pat => pat.Suburb)
                .Include(pat => pat.Dependents)
                    .ThenInclude(dep => dep.Suburb)
                .Include(pat => pat.MedicalAidPlan)
                .ThenInclude(pat => pat.MedicalAidScheme);
        }

        public static IQueryable<Nurse> GetDetails(this DbSet<Nurse> nurses)
        {
            return nurses
                .Include(nur => nur.SuburbsPreferreds);
                
        }
    }
}
