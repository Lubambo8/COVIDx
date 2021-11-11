using AutoMapper;
using CovidXWebApp.Models.ViewModel;
using CovidXWebApp.Services.Interface;
using EFCore;
using EFCore.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        private readonly IMapper _mapper;

        public PatientServices(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public bool AddPatient(PatientCreateViewModel model)
        {
            // map the data from the model to the a patient entity
            var patient = _mapper.Map<Patient>(model);

            _context.Patient.Add(patient);

            var rowsAffected = _context.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;

            // return _context.SaveChanges() > 0;
        }

        public Patient GetPatientDetail(string userID)
        {
            // get all the patient details
            return _context.Patient.GetDetails()
                // where the user ID matches
                .SingleOrDefault(x => x.UserID == userID);
        }

        public Patient FindPatientByPatientID(int PatientID)
        {
            throw new NotImplementedException();
        }

        public bool AddDependent(DependentCreateViewModel model)
        {
            var dependent = _mapper.Map<Dependent>(model);

            _context.Dependent.Add(dependent);

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

        public SelectList GetPatientAddress(int patientID)
        {
            // get list of dependents from the database
            var list = _context.Patient.Where(x => x.PatientID == patientID).ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "AddressLine1", "AddressLine1");

            return output;
        }

        public SelectList GetDependentAddress(int patientID)
        {
            // get list of dependents address from the database
            var list = _context.Dependent.Where(x => x.MainMemberID == patientID).ToList();

            // create a select list with 'DependentD' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "DependentID", "AddressLine1");

            return output;
        }

        public SelectList GetDependentSuburb(int patientID)
        {
            // get list of dependents address from the database
            var list = _context.Dependent.Where(x => x.MainMemberID == patientID).ToList();
            // var list = _db.Suburbs.Include(x => x.Dependents).ThenInclude(x => x.MainMemberId == patientID);

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "DependentId", "SuburbName");

            return output;
        }

        public SelectList GetDependentByPatientID(int patientID)
        {
            // get list of dependents from the database
            var list = _context.Dependent.Where(x => x.MainMemberID == patientID).ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "DependentID", "FirstName");

            return output;
        }

        public bool AddTestRequest(TestRequestViewModel data)
        {
            //Map ViewModel info to EF Core Entity
            var entity = new TestRequest()
            {
                PatientId = data.PatientId,
                DependentID = data.DependentId,
                RequestDate = DateTime.Now,
                RequestStatus = TestRequestStatus.New,
                TestAddress1 = data.TestAddress1,
                SuburbID = data.SuburbId
            };

            
            //Add entity to Db
            _context.TestRequest.Add(entity);

            //Save changes to db
            var rowsAffected = _context.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<TestRequestDetailModel> GetTestRequests(string userID)
        {
            var output = new List<TestRequestDetailModel>();

            // create a list of the active states
            var activeTestStatus = new TestRequestStatus[] { TestRequestStatus.New, TestRequestStatus.Assigned, TestRequestStatus.Scheduled, TestRequestStatus.AtLab };

            // get patient where the user ID matches
            var patient = _context.Patient.GetDetails().SingleOrDefault(x => x.UserID == userID);

            // get all the test request details
            var requests = _context.TestRequest.GetDetails()
                // where the patient made the request
                .Where(req => req.PatientId == patient.PatientID)
                .ToList();

            // details about the test request
            TestRequestDetailModel details;
            TestRequest requester = requests.FirstOrDefault(item => item.PatientId == patient.PatientID);

            if(requester == null)
            {
                return output;

            }
            else
            {
                details = new TestRequestDetailModel()
                {
                    IsActive = true,
                    NurseFullName = (requester.Nurse is null) ? "Not yet assigned" : requester.Nurse.FirstName + " " + requester.Nurse.LastName,
                    PatientFullName = patient.FirstName + " " + patient.LastName,
                    RequestDate = requester.RequestDate,
                    Status = requester.RequestStatus,
                    TestDate = requester.StartTime.HasValue == true ? requester.StartTime.Value.ToShortDateString() + " " + requester.StartTime.Value.ToShortTimeString() : "Not yet scheduled",
                    TestLocation = requester.Patient.AddressLine1,
                    TestRequestID = requester.TestRequestID,
                    RequestedByID = requester.PatientId,
                    RequestedForID = requester.PatientId,
                    SuburbID = (int)patient.SuburbID
                };

                output.Add(details);
            }
            

            // get active dependent ID's
            var activeDependentID = requests
                // where the status is one of the active statuses
                .Where(item => activeTestStatus.Contains(item.RequestStatus))
                // and select only the dependent IDs
                .Select(item => item.DependentID);

            foreach (var dependent in patient.Dependents)
            {
                // details about the test request
                TestRequestDetailModel detail;
                // the test request database entity for the specific dependent
                TestRequest request = requests.FirstOrDefault(item => item.DependentID == dependent.DependentID);

                if (request == null)
                {
                    return output;
                }
                else
                {
                    detail = new TestRequestDetailModel()
                    {
                        IsActive = true,
                        NurseFullName = (request.Nurse is null) ? "Not yet assigned" : request.Nurse.FirstName + " " + request.Nurse.LastName,
                        PatientFullName = patient.FirstName + " " + patient.LastName,
                        RequestDate = request.RequestDate,
                        Status = request.RequestStatus,
                        TestDate = request.StartTime.HasValue == true ? request.StartTime.Value.ToShortDateString() + " " + request.StartTime.Value.ToShortTimeString() : "Not yet scheduled",
                        TestLocation = request.Dependent.AddressLine1,
                        TestRequestID = request.TestRequestID,
                        RequestedByID = request.PatientId,
                        RequestedForID = request.DependentID,
                        SuburbID = (int)patient.SuburbID
                    };


                    if (activeDependentID.Contains(dependent.DependentID))
                    {
                        detail = new TestRequestDetailModel()
                        {
                            IsActive = true,
                            NurseFullName = (request.Nurse is null) ? "Not yet assigned" : request.Nurse.FirstName + " " + request.Nurse.LastName,
                            PatientFullName = dependent.FirstName + " " + dependent.LastName,
                            RequestDate = request.RequestDate,
                            Status = request.RequestStatus,
                            TestDate = request.StartTime.HasValue == true ? request.StartTime.Value.ToShortDateString() + " " + request.StartTime.Value.ToShortTimeString() : "Not yet scheduled",
                            TestLocation = request.Dependent.AddressLine1,
                            TestRequestID = request.TestRequestID,
                            RequestedByID = request.PatientId,
                            RequestedForID = request.DependentID,
                            SuburbID = (int)dependent.SuburbID
                        };


                    }
                    else
                    {

                        detail = new TestRequestDetailModel()
                        {
                            IsActive = false,
                            NurseFullName = "Not yet assigned",
                            PatientFullName = dependent.FirstName + " " + dependent.LastName,
                            RequestDate = request.RequestDate,
                            Status = TestRequestStatus.New,
                            TestDate = "Not yet scheduled",
                            TestLocation = dependent.Suburb.SuburbName,
                            TestRequestID = 0,
                            RequestedByID = patient.PatientID,
                            RequestedForID = dependent.DependentID,
                            SuburbID = (int)dependent.SuburbID
                        };
                    }
                }
                


                // if the dependent has an active request
                

                // add to list
                output.Add(detail);
            }

            // return the list
            return output;
        }

        public bool TestCancel(int testRequestID, string userID)
        {
            //find patient by user id
            var patient = _context.Patient.SingleOrDefault(x => x.UserID == userID);

            //find the test request based on the passed in ID
            var testRequest = _context.TestRequest.SingleOrDefault(x => x.TestRequestID == testRequestID);

            //update request status for that found request that needs to be cancelled
            testRequest.RequestStatus = TestRequestStatus.Cancelled;


            //update test request
            _context.TestRequest.Update(testRequest);

            //Save changes to Database
            var rowsAffected = _context.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        

        public List<Test> GetTestInfo(string UserID)
        {
            //find patient based on user id
            var patient = _context.Patient.SingleOrDefault(x => x.UserID == UserID);
            //find tests request based on patient id
            var testRequestList = _context.Test.GetDetails().Where(x => x.TestRequest.Patient.PatientID == patient.PatientID).ToList();

            return testRequestList;
        }
    }
}
