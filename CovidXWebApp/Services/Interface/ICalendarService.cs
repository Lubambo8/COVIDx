using CovidXWebApp.Models.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Services.Interface
{
    public interface ICalendarService
    {
        /// <summary>
        /// Gets the list of scheduled test requests
        /// </summary>
        /// <returns></returns>
        List<CalendarEventModel> GetEvents();

        /// <summary>
        /// Gets all the test request for the logged in nurse
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<CalendarEventModel> GetAssignedRequests(string userID);

        bool AddEvents(CalendarEventModel model);
    }
}
