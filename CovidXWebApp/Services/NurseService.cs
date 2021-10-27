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

namespace CovidXWebApp.Services
{
    public class NurseService : INurseServices
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public NurseService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool AddNurse(NurseCreateViewModel model)
        {
            var nurse = _mapper.Map<Nurse>(model);
            //Add patient to DB
            _context.Nurse.Add(nurse);

            //Save changes to DB
            var rowsAffected = _context.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public bool AddSuburbs(NurseSuburbsModel model)
        {
            var suburbs = _mapper.Map<SuburbsPreferred>(model);

            _context.SuburbsPreferred.Add(suburbs);

            var rowsAffected = _context.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public Nurse FindNurseByUserID(string UserID)
        {
            var nurseByUserID = _context.Nurse.FirstOrDefault(x => x.UserID == UserID);

            return nurseByUserID;
        }

        public IQueryable<SuburbsPreferred> GetFavouriteSuburbs()
        {
            var query = _context.SuburbsPreferred
                .Include(x => x.Suburb);

            return query;
        }

        public SelectList GetSuburbList()
        {
            var list = _context.Suburb.ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "SuburbID", "SuburbName");

            return output;
        }

        public List<SuburbsPreferred> GetSuburbsPreffereds(string userID)
        {
            //get the nurse ID and userID
            var nurse = _context.Nurse.SingleOrDefault(item => item.UserID == userID);
            // get all favourite suburbs
            var prefered = GetFavouriteSuburbs().Where(item => item.NurseID == nurse.NurseID).ToList();

            return prefered;
        }

        public IQueryable<TestRequest> GetFavouriteRequests(List<int> preferedSuburbsID)
        {
            // get a select statement [SELECT * FROM TestRequest TR]
            var query = _context.TestRequest
                // left join to suburb table [LEFT JOIN Suburb S ON S.ID = TR.SuburbID]
                .Include(x => x.Suburb)
                // where the suburb id's match one or more of the suburb id's in test request [WHERE TR.SuburbID IN (101, 102. 103, 104)]
                .Where(x => preferedSuburbsID.Contains(x.SuburbID));


            return query;
        }

        public IQueryable<TestRequest> GetMyTestRequests(int nurseID)
        {


            // get all favourite suburbs
            var prefered = _context.SuburbsPreferred.Where(item => item.NurseID == nurseID);

            // get id list
            var preferedList = prefered.Select(item => item.SuburbID).ToList();

            // get favourite requests
            var preferedTestRequests = GetFavouriteRequests(preferedList)
                .Where(x => x.RequestStatus == TestRequestStatus.New);

            return preferedTestRequests;

        }


        public bool AssignNurse(int testRequestID, string userID)
        {
            //find nurse by user id
            var nurse = _context.Nurse.SingleOrDefault(x => x.UserID == userID);

            //find the test request based on the passed in ID
            var testRequest = _context.TestRequest.SingleOrDefault(x => x.TestRequestID == testRequestID);

            //update nurseid and request status for that found request
            testRequest.NurseID = nurse.NurseID;
            testRequest.RequestStatus = TestRequestStatus.Assigned;


            //update test request
            _context.TestRequest.Update(testRequest);


            //Map ViewModel info to EF Core Entity

            //Update Test Record 
            //_db.SuburbsPreffereds.Add(entity);

            //Save changes to DB
            var rowsAffected = _context.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public bool NurseExists(string UserID)
        {
            var patientExists = _context.Patient.FirstOrDefault(x => x.UserID == UserID);

            if (patientExists is not null)
            {
                return true;
            }

            return false;
        }
    }
}
