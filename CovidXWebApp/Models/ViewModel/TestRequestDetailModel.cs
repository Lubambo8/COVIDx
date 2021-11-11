using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Models.ViewModel
{
    public class TestRequestDetailModel
    {
        public AlertModel Alert { get; set; }
        public string PatientFullName { get; set; }
        public string NurseFullName { get; set; }
        public TestRequestStatus Status { get; set; }
        public DateTime RequestDate { get; set; }
        public string TestLocation { get; set; }
        public string TestDate { get; set; }
        public bool IsActive { get; set; }
        public int RequestedByID { get; set; }
        public int? RequestedForID { get; set; }
        public int TestRequestID { get; set; }
        public int SuburbID { get; set; }

        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
