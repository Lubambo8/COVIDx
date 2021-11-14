using CovidXWebApp.Models.ViewModel;
using CovidXWebApp.API.Interface;
using EFCore.EFCoreConfigurationMethods;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Controllers
{
    public class ManagerController : Controller
    {
        private readonly UserManager<EFCoreIdentityUser> _userManager;
        private readonly INurseAPI _nurseService;

        public ManagerController(UserManager<EFCoreIdentityUser> userManager, INurseAPI nurseService)
        {
            _userManager = userManager;
            _nurseService = nurseService;
        }

        [HttpGet]
        public IActionResult Reports()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Reports(ManagerReportViewModel model)
        {


            if (ModelState.IsValid)
            {

                //Get date range inputs
                var range = model.DateInput.Split('-');
                model.StartDate = Convert.ToDateTime(range[0]);
                model.EndDate = Convert.ToDateTime(range[1]);


                _nurseService.GetReportDetails(model.nurseID, model.StartDate, model.EndDate);
                return View(nameof(ReportTable), model);
            }



            return View();
        }

        [HttpGet]

        public IActionResult ReportTable()
        {
            return View();
        }
    }
}
