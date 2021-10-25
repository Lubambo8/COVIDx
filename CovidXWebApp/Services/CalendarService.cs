using AutoMapper;
using CovidXWebApp.Models.Calendar;
using CovidXWebApp.Services.Interface;
using EFCore;
using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public CalendarService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool AddEvents(CalendarEventModel model)
        {
            model.Start = Convert.ToDateTime(model.StartText.Substring(0, 25));
            model.End = Convert.ToDateTime(model.EndText.Substring(0, 25));

            var entity = _mapper.Map<CalendarEvent>(model);

            // new events will have an ID of 0
            if (entity.ID == 0)
            {
                _context.CalendarEvents.Add(entity);
            }
            else
            {
                _context.CalendarEvents.Update(entity);
            }

            var result = _context.SaveChanges();

            if (result > 0)
            {
                return true;
            }

            return false;
        }

        public List<CalendarEventModel> GetAssignedRequests(string userID)
        {
            var eventList = new List<CalendarEventModel>();

            // get all the test request information for the current nurse
            var requests = _context.TestRequest.GetTestRequests()
                .Where(item => item.RequestStatus == TestRequestStatus.Assigned && item.Nurse.UserID == userID)
                .ToList();

            foreach (var request in requests)
            {
                var calendarEvent = new CalendarEventModel()
                {
                    ID = (int)request.CalendarEventID,
                    // Title = request.Nurse.FirstName,
                    Description = request.Suburb.SuburbName,
                    AllDay = false
                };

                eventList.Add(calendarEvent);
            }

            // TODO: temp data, remove !
            var output = new List<CalendarEventModel>()
            {
                new CalendarEventModel()
                {
                    ID = 8,
                    Title = "",
                    Description = "1 Harbor Cottages",
                    Start = Convert.ToDateTime("2021-10-14 10:00"),
                    End = Convert.ToDateTime("2021-10-14 11:00"),
                    AllDay = false
                },
                new CalendarEventModel()
                {
                    ID = 7,
                    Title = "",
                    Description = "24 7th Avenue",
                    Start = Convert.ToDateTime("2021-10-15 10:00"),
                    End = Convert.ToDateTime("2021-10-15 11:00"),
                    AllDay = false
                },
                new CalendarEventModel()
                {
                    ID = 6,
                    Title = "",
                    Description = "6 Rubi Crescent",
                    Start = Convert.ToDateTime("2021-10-15 12:30"),
                    End = Convert.ToDateTime("2021-10-15 13:30"),
                    AllDay = false
                },
                new CalendarEventModel()
                {
                    ID = 5,
                    Title = "",
                    Description = "19 Admirality Way",
                    Start = Convert.ToDateTime("2021-10-17 14:00"),
                    End = Convert.ToDateTime("2021-10-17 15:00"),
                    AllDay = false
                }
            };

            return output;
        }

        public List<CalendarEventModel> GetEvents()
        {
            var output = new List<CalendarEventModel>();
            // make for database call to get the time slots

            var events = _context.CalendarEvents.ToList();

            foreach (var eve in events)
            {
                var item = new CalendarEventModel()
                {
                    ID = eve.ID,
                    AllDay = eve.AllDay,
                    Description = eve.Description,
                    Start = eve.Start,
                    End = eve.End,
                    Title = eve.Title
                };

                output.Add(item);
            }

            return output;
        }
    }
}
