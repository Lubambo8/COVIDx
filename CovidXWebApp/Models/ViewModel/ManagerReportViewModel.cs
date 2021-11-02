using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Models.ViewModel
{
    public class ManagerReportViewModel
    {
        //show tests performed by a specific nurse within a specific date range
        public AlertModel Alert { get; set; }
        public int nurseID { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DateInput { get; set; }
    }
}
