using CovidXWebApp.Models;
using CovidXWebApp.Models.ViewModel;
using CovidXWebApp.Services.Interface;
using EFCore.EFCoreConfigurationMethods;
using EFCore.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<EFCoreIdentityUser> _userManager;
        private readonly IPatientServices _patientService;

        public ProfileController(UserManager<EFCoreIdentityUser> userManager, IPatientServices patientService)
        {
            _userManager = userManager;
            _patientService = patientService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new PatientCreateViewModel());
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PatientCreateViewModel model)
        {
           

            if (ModelState.IsValid)
            {
                //// get user id value...
                //var user = _userManager.GetUserIdAsync(User.Identity.Name);

                //var user = await _userManager.FindByEmailAsync(User.Identity.Name);
                var user = await _userManager.GetUserAsync(User);


                // ...add that as a foreign key
                //model.UserId = user.Id;

                //Check if patient already exist


                //If patient does not exist..
                //Create new Patient object
                var patient = new Patient
                {
                    UserID = user.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    IDnumber = model.IDnumber,
                    MobileNumber = model.MobileNumber,
                    AddressLine1 = model.AddressLine1,
                    AddressLine2 = model.AddressLine2,
                    DateOfBirth = model.DateOfBirth,
                    MedicalAidStatus = model.MedicalAidStatus,
                    SuburbID = model.SuburbID
                };

                // create the database entry
                if (model.MedicalAidStatus == true)
                {
                    //If MedicalAid Switch Selected
                    //Changed MedicalAidStatus to true
                    patient.MedicalAidStatus = true;
                    patient.MedicalAidPlanID = model.MedicalAidPlanID;
                    patient.MedicalAidNo = model.MedicalAidNo;
                    patient.DependencyCode = model.DependencyCode;
                    //ADD PATIENT
                    _patientService.AddPatient(patient);

                    //if (success)
                    //{
                    //    // update the Identity user-name
                    //    string username = model.Patient.FirstName + " " + model.Patient.LastName;
                    //    await _userManager.SetUserNameAsync(user, username);
                    //}
                }
                else if (model.MedicalAidStatus == false)
                {
                    //If MedicalAid Switch not selected
                    patient.MedicalAidStatus = false;
                    _patientService.AddPatient(patient);

                    //if (success)
                    //{
                    //    // update the Identity user-name
                    //    string username = model.Patient.FirstName + " " + model.Patient.LastName;
                    //    await _userManager.SetUserNameAsync(user, username);
                    //}
                }

                //return View();
                return RedirectToAction("Login", "Account");
                //return RedirectToAction("ProfileAvatar", "Profile", new { model });
            }

            // reload the page with the user's input
            ModelState.AddModelError(string.Empty, "Could not create profile. Try again");
            return View(model);
        }


    }
}
