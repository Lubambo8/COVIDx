using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class TestRequest
    {
        public int TestRequestID { get; set; }
        public int PatientID { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestStatus { get; set; }
        public string TestAddress1 { get; set; }
        public string TestAddress2 { get; set; }
        public int SuburbID { get; set; }
        public int NurseID { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime TimeSlotAssigned { get; set; }
    }
}
