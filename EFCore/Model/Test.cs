using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class Test
    {
        public int TestID { get; set; }
        public string BarCode { get; set; }
        public string Temperature { get; set; }
        public string BloodPressure { get; set; }
        public string OxygenLevel { get; set; }
        public DateTime TestDate { get; set; }
        public DateTime TestTime { get; set; }
        public string TestResult { get; set; }
        public DateTime ResultDate { get; set; }
        public int LabUserID { get; set; }
    }
}
