using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.ModelInterfaces
{
    public interface ITestRequest
    {
        int? AcceptedByID { get; set; }

        /// <summary>
        /// Represents the calendar event
        /// </summary>
        int? CalendarEventID { get; set; }

        DateTime? EndTime { get; set; }

        /// <summary>
        /// Represents the Patient ID
        /// </summary>
        int RequestedByID { get; set; }

        /// <summary>
        /// Represents the Dependent ID
        /// </summary>
        int? RequestedForID { get; set; }

        DateTime? StartTime { get; set; }

        TestRequestStatus Status { get; set; }

        /// <summary>
        /// The location of the test center
        /// </summary>
        int? SuburbID { get; set; }

        int TestRequestID { get; set; }
    }
}
