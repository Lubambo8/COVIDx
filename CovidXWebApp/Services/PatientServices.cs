using CovidXWebApp.Services.Interface;
using EFCore;
using EFCore.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Services
{
    public class PatientServices : IPatientServices
    {
        private readonly DatabaseContext _context;

        public PatientServices(DatabaseContext context)
        {
            _context = context;
        }

        public SelectList GetSuburbList()
        {
            // get all the suburs from the database
            var list = _context.Suburb.ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "SuburbID", "SuburbName");

            return output;
        }

        public List<SubtextOption> GetMedicalAidList()
        {
            // get all the medical aid plans from the database
            var medicalAidPlans = _context.MedicalAidPlan.GetMedicalAidDetailList();

            // create a list of SubtextOption objects to return
            var output = new List<SubtextOption>();

            // populate the SubtextOption list with the medical aid plans
            foreach (var plan in medicalAidPlans)
            {
                // set the option properties
                var option = new SubtextOption()
                {
                    DisplayText = plan.Description,
                    DisplaySubtext = plan.MedicalAidScheme.Description,
                    Value = plan.MedicalAidPlanID
                };

                // add the option to the list
                output.Add(option);
            }

            return output;

            //IQueryable<MedicalAidPlan> query = _context.MedicalAidPlans.GetMedicalAidDetail();
            //var getSpecificPlanQuery = query.Where(plan => plan.Name == "this");
            //getSpecificPlanQuery.ToList();

            //List<MedicalAidPlan> list = _context.MedicalAidPlans.GetMedicalAidDetailList();
            //var getSpecificPlan = list.Where(plan => plan.Name == "this");
        }

        public bool AddPatient(Patient model)
        {
            _context.Patient.Add(model);

            var rowsAffected = _context.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;

            // return _context.SaveChanges() > 0;
        }

        public Patient FindPatientByPatientID(int PatientID)
        {
            throw new NotImplementedException();
        }

        public bool AddDependent(Dependent model)
        {
            _context.Dependent.Add(model);

            var rowsAffected = _context.SaveChanges();

            if(rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<TestRequest> GetTestRequests(int PatientID)
        {
            throw new NotImplementedException();
        }

        public List<Dependent> GetDependents(int PatientID)
        {
            throw new NotImplementedException();
        }

        public Patient FindPatientByUserID(string UserID)
        {
            var patientByUserID = _context.Patient.FirstOrDefault(x => x.UserID == UserID);

            return patientByUserID;
        }
    }
}
