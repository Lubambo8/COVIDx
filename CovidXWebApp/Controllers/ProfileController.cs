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
using Utility;

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

        [HttpGet]
        public IActionResult CreateDependent()
        {
            return View(new DependentCreateViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> CreateDependent(DependentCreateViewModel model)
        {
                if (ModelState.IsValid)
                {
                    // get user id value...
                    //var user = _userManager.GetUserIdAsync(User.Identity.Name);
                    var user = await _userManager.GetUserAsync(User);
                    //var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                    //Find patient by user ID
                    var patient = _patientService.FindPatientByUserID(user.Id);

                    //If found  ...add that as a foreign key

                    //model.MainMemberId = patient.PatientId;

                    //If patient does not exist..
                    //Create new Patient object
                    var dependent = new Dependent
                    {
                        MainMemberID = patient.PatientID,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        IDnumber = model.Idnumber,
                        MobileNumber = model.MobileNumber,
                        EmailAddress = model.EmailAddress,

                        DateOfbirth = model.Dob,
                        MedicalAidStatus = model.MedicalAidStatus,
                        
                        Relationship = model.Relationship,
                        PersonResponsible = model.PersonResponsible

                    };

                    //If address is same as Main Member,
                    //populate those values from Main Member table
                    if (model.AddressSameasMainMember == true)
                    {
                        dependent.AddressLine1 = patient.AddressLine1;
                        dependent.AddressLine2 = patient.AddressLine2;
                        dependent.SuburbID = patient.SuburbID;
                    }
                    else if (model.AddressSameasMainMember == false)
                    {
                        dependent.AddressLine1 = model.AddressLine1;
                        dependent.AddressLine2 = model.AddressLine2;
                        dependent.SuburbID = model.SuburbId;
                    }

                    // create the database entry
                    if (model.MedicalAidStatus == true)
                    {
                        //If MedicalAid Switch Selected
                        //Changed MedicalAidStatus to true
                        dependent.MedicalAidStatus = true;

                        //If MedicalAidSame as Main Member,
                        //get medical aid details from Patient Table
                        if (model.MedicalAidSameasMainMember == true)
                        {
                            dependent.MedicalAidPlanID = patient.MedicalAidPlanID;
                            dependent.MedicalAidNo = patient.MedicalAidNo;
                            dependent.DependencyCode = model.DependencyCode;
                        }
                        else if (model.MedicalAidSameasMainMember == false)
                        {
                            dependent.MedicalAidPlanID = model.MedicalAidPlanId;
                            dependent.MedicalAidNo = model.MedicalAidNo;
                            dependent.DependencyCode = model.DependencyCode;
                        }

                        //Add dependent
                        _patientService.AddDependent(dependent);


                    }
                    else if (model.MedicalAidStatus == false)
                    {
                        //If MedicalAid Switch not selected
                        dependent.MedicalAidStatus = false;
                        //ADD DEPENDENT
                        _patientService.AddDependent(dependent);


                    }

                    //return View();
                    //Add alert
                    TempData[WCAlert.Success] = "Dependent added successfully!";
                    return RedirectToAction("Dashboard", "Home");
                    //return RedirectToAction("ProfileAvatar", "Profile", new { model });
                }

                // reload the page with the user's input
                TempData[WCAlert.Error] = "Dependent could not be added!";
                //ModelState.AddModelError(string.Empty, "Could not create profile. Try again");
                return View(model);
            
        }
    }
}
