using AutoMapper;
using CovidXWebApp.Models.Calendar;
using CovidXWebApp.API.Interface;
using EFCore;
using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Email;

namespace CovidXWebApp.API
{
    public class CalendarAPI : ICalendarAPI
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IEmailer _email;

        public CalendarAPI(DatabaseContext context, IMapper mapper, IEmailer email)
        {
            _context = context;
            _mapper = mapper;
            _email = email;
        }

        public bool AddEvents(CalendarEventModel model)
        {
            model.Start = Convert.ToDateTime(model.StartText.Substring(0, 25));
            model.End = Convert.ToDateTime(model.EndText.Substring(0, 25));

            var entity = _mapper.Map<CalendarEvent>(model);

            //Check for validation to make sure a test request cannotb
            if (model.Start < DateTime.Now)
            {
                return false;
            }

            var testRequest = _context.TestRequest.SingleOrDefault(x => x.TestRequestID == model.ID);
            testRequest.RequestStatus = TestRequestStatus.Scheduled;
            testRequest.StartTime = model.Start;
            testRequest.EndTime = model.End;




            // new events will have an ID of 0

            //add calender
            _context.CalendarEvents.Add(entity);
            //update test request
            _context.TestRequest.Update(testRequest);


            var result = _context.SaveChanges();

            if (result > 0)
            {
                //var patient = _context.Patient.SingleOrDefault(x => x.PatientID == testRequest.PatientId);
                //var subject = "Scheduled Test Request ";
                //var body = "Your test requests have been scheduled for the following date and time slots:" +
                //    testRequest.StartTime.ToString() + " " + testRequest.EndTime.ToString() + "\n" + "Kind Regards, CovidX Management";
                //_email.SendEmail("Veemvolt@gmail.com", subject, body);
                return true;
            }

            return false;
        }

        public List<CalendarEventModel> GetAssignedRequests(string userID)
        {
            var eventList = new List<CalendarEventModel>();

            // get all the test request information for the current nurse
            var requests = _context.TestRequest.GetTestRequests()
                .Where(item => item.RequestStatus == TestRequestStatus.Assigned && item.Nurse.UserID == userID)
                .ToList();

            foreach (var request in requests)
            {
                var calendarEvent = new CalendarEventModel()
                {
                    ID = request.TestRequestID,
                    Title = request.TestAddress1,
                    Description = request.TestAddress1 + " " + request.Suburb.SuburbName,
                    AllDay = false
                };

                eventList.Add(calendarEvent);
            }

            return eventList;
        }

        public List<CalendarEventModel> GetEvents()
        {
            // make for database call to get the time slots
            var output = new List<CalendarEventModel>();
            // make for database call to get the time slots

            var events = _context.CalendarEvents.ToList();

            foreach (var eve in events)
            {
                var item = new CalendarEventModel()
                {
                    ID = eve.ID,
                    AllDay = eve.AllDay,
                    Description = eve.Description,
                    Start = eve.Start,
                    End = eve.End,
                    Title = eve.Description
                };

                output.Add(item);
            }

            return output;
        }
    }
}
