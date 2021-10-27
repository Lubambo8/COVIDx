using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Models.Calendar
{
    public class CalendarEventModel
    {
        public int? ID { get; set; }

        public int RequestID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public string StartText { get; set; }
        public DateTime End { get; set; }
        public string EndText { get; set; }
        public bool AllDay { get; set; }
    }
}
