using CovidXWebApp.Models.Calendar;
using CovidXWebApp.Models.ViewModel;
using CovidXWebApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Controllers
{
    public class CalendarController : Controller
    {
        private readonly ICalendarService _calendarService;

        public CalendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        public IActionResult Index()
        {
            // model will load the assigned test requests
            return View(new CalendarViewModel());
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            // calendar will call this action to load it's calendar events
            var output = _calendarService.GetEvents();

            return Json(output);
        }

        [HttpPost]
        public IActionResult Update(CalendarEventModel model)
        {
            // logic ??
            var success = _calendarService.AddEvents(model);

            if (success)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
