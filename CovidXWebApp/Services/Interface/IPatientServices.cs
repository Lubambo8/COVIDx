using CovidXWebApp.Models.ViewModel;
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
        /// <summary>
        /// Gets the profile details of the current patient
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        Patient GetPatientDetail(string userID);
        bool AddPatient(PatientCreateViewModel model);

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
        bool AddDependent(DependentCreateViewModel model);

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

        /// <summary>
        /// Gets a list of addresses based on a patientID to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetPatientAddress(int patientID);

        /// <summary>
        /// Gets a list of addresses based on a patientID to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetDependentAddress(int patientID);

        // <summary>
        /// Gets a list of addresses based on a patientID to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetDependentSuburb(int patientID);

        /// <summary>
        /// Gets a list of dependents based on a patientID to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetDependentByPatientID(int patientID);

        /// <summary>
        /// Gets details about the requests made by the patient
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<TestRequestDetailModel> GetTestRequests(string userID);
        public bool AddTestRequest(TestRequestViewModel data);

        /// <summary>
        /// Cancels a test Request
        /// </summary>
        /// <param name="testRequestID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        bool TestCancel(int testRequestID, string userID);

        

        /// <summary>
        /// Gets a list of test results based on a user id
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        List<Test> GetTestInfo(string UserID);
    }
}
