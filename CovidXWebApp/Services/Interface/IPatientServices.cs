using EFCore.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Services.Interface
{
    public interface IPatientServices
    {
        bool AddPatient(Patient model);

        List<SubtextOption> GetMedicalAidList();

        SelectList GetSuburbList();

        /// <summary>
        /// Find patient by patient ID
        /// </summary>
        /// <param name="PatientID"></param>
        /// <returns></returns>
        Patient FindPatientByPatientID(int PatientID);

        /// <summary>
        /// Add <see cref="Dependent"/> to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddDependent(Dependent model);

        /// <summary>
        /// Get All Tests Requests 
        /// </summary>
        /// <returns></returns>
        List<TestRequest> GetTestRequests(int PatientID);

        /// <summary>
        /// Get All Dependents
        /// </summary>
        /// <param name="PatientID"></param>
        /// <returns></returns>
        List<Dependent> GetDependents(int PatientID);

        /// <summary>
        /// Find Patient by it's UserID
        /// </summary>
        /// <param name="UserID"></param>
        Patient FindPatientByUserID(string UserID);
    }
}
