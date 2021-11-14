using CovidXWebApp.API.Interface;
using EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Email;

namespace CovidXWebApp.API
{
    public class EmailAPI : IEmailAPI
    {
        private readonly DatabaseContext _context;
        private readonly IEmailer _emailer;

        public EmailAPI(DatabaseContext context, IEmailer emailer)
        {
            _context = context;
            _emailer = emailer;
        }
        public bool SendPatientNotification(int testrequestID)
        { //find the test request using testrequestID
            var request = _context.TestRequest.SingleOrDefault(x => x.TestRequestID == testrequestID);

            if (request is null)
            {
                return false;
            }
            //find patient linked to this test request
            //var patient = _context.Patient.SingleOrDefault(x => x.PatientID == request.PatientId);
            var patient = _context.Patient.SingleOrDefault(x => x.PatientID == request.PatientId);

            if (patient is null)
            {
                return false;
            }

            

            var subject = "Test Request Scheduled";
            var body = "Hi there, Your test requests have been scheduled for the following date and time slots:" +
                request.StartTime.ToString() + " " + request.EndTime.ToString() + "\n" + "Brought to you by CO-X";

            _emailer.SendEmail(patient.EmailAddress, subject, body);

            return true;
        }
    }
}
