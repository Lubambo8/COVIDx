using CovidXWebApp.Models;
using CovidXWebApp.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
           

            //while (true)
            //{

            //}
            return View();
        }

        public IActionResult NurseDashboard()
        {
            var model = new NurseSuburbsModel()
            {
                Alert = HttpContext.Session.GetAndRemove<AlertModel>(nameof(AlertModel)) ?? default
            };
            return View(model);
        }

        public IActionResult PatientDashboard()
        {
            var model = new PatientCreateViewModel()
            {
                Alert = HttpContext.Session.GetAndRemove<AlertModel>(nameof(AlertModel)) ?? default
            };
            return View(model);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
