using CovidXWebApp.Models.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Models.ViewModel
{
    public class CalendarViewModel
    {
        public AlertModel Alert { get; set; }
        public CalendarEventModel CalendarEventModel { get; set; }
    }
}
