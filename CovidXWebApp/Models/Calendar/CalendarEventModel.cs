using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Models.Calendar
{
    public class CalendarEventModel
    {
        public AlertModel Alert { get; set; }
        public int? ID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public string StartText { get; set; }
        public DateTime End { get; set; }
        public string EndText { get; set; }
        public bool AllDay { get; set; }
    }
}
