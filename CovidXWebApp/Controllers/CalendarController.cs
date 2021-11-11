using CovidXWebApp.Models.Calendar;
using CovidXWebApp.Models.ViewModel;
using CovidXWebApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

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
            var model = new CalendarViewModel()
            {
                Alert = HttpContext.Session.GetAndRemove<AlertModel>(nameof(AlertModel)) ?? default
            };
            // model will load the assigned test requests
            return View(model);
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
            model.Start = Convert.ToDateTime(model.StartText.Substring(0, 25));
            model.End = Convert.ToDateTime(model.EndText.Substring(0, 25));
            var success = _calendarService.AddEvents(model);


            if (success)
            {
                var alert = new AlertModel
                {
                    AlertType = AlertType.Success,
                    Message = "Test was successfully scheduled!"
                };
                HttpContext.Session.Set<AlertModel>(nameof(AlertModel), alert);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var alert = new AlertModel
                {
                    AlertType = AlertType.Error,
                    Message = "Error!, You cannot schedule a test request in a past date. Please try again"
                };
                

                HttpContext.Session.Set<AlertModel>(nameof(AlertModel), alert);
                 return RedirectToAction(nameof(Index));
               
            }

            
        }
    }
}
