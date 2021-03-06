using CovidXWebApp.Models;
using CovidXWebApp.Models.ViewModel;
using CovidXWebApp.API.Interface;
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
        private readonly IPatientAPI _patientAPI;

        public ProfileController(UserManager<EFCoreIdentityUser> userManager, IPatientAPI patientAPI)
        {
            _userManager = userManager;
            _patientAPI = patientAPI;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new PatientCreateViewModel()
            {
                Alert = HttpContext.Session.GetAndRemove<AlertModel>(nameof(AlertModel)) ?? default
            };
            return View(model);
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
                if (user is null)
                {
                    model.Alert = new AlertModel
                    {
                        AlertType = AlertType.Error,
                        Message = "Please login!"
                    };
                    return View(model);
                }
                //Check if patient already exist


                //If patient does not exist..
                //Create new Patient object
                model.UserID = user.Id;
                model.EmailAddress = user.Email;

                // create the database entry
                if (model.MedicalAidStatus == true)
                {
                    //If MedicalAid Switch Selected
                    //Changed MedicalAidStatus to true
                    
                    //ADD PATIENT
                   var success = _patientAPI.AddPatient(model);
                    if(success)
                    {
                        var alert = new AlertModel
                        {
                            AlertType = AlertType.Success,
                            Message = $"{model.FirstName} {model.LastName} added successfully!"
                        };

                        // store alert in session memory to show in different page
                        HttpContext.Session.Set<AlertModel>(nameof(AlertModel), model.Alert);
                        // set avatar and activate user
                        user.Avatar = model.Avatar;
                        user.IsActive = true;
                        await _userManager.UpdateAsync(user);
                        return RedirectToAction("Login", "Account", alert);
                    }
                }
                else if (model.MedicalAidStatus == false)
                {
                    //If MedicalAid Switch not selected
                    model.MedicalAidStatus = false;
                    var success = _patientAPI.AddPatient(model);

                    if (success)
                    {
                        var alert = new AlertModel
                        {
                            AlertType = AlertType.Success,
                            Message = $"{model.FirstName} {model.LastName} added successfully!"
                        };
                        HttpContext.Session.Set<AlertModel>(nameof(AlertModel), model.Alert);
                        // set avatar and activate user
                        user.Avatar = model.Avatar;
                        user.IsActive = true;
                        await _userManager.UpdateAsync(user);
                        return RedirectToAction("Login", "Account", alert);
                    }
                }

                

                //return View();
                
                //return RedirectToAction("ProfileAvatar", "Profile", new { model });
            }

            // reload the page with the user's input
            ModelState.AddModelError(string.Empty, "Could not create profile. Try again");
            return View(model);
        }

        [HttpGet]
        public IActionResult Dependent()
        {
            var model = new DependentCreateViewModel()
            {
                Alert = HttpContext.Session.GetAndRemove<AlertModel>(nameof(AlertModel)) ?? default
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Dependent(DependentCreateViewModel model)
        {
                if (ModelState.IsValid)
                {
                    // get user id value...
                    //var user = _userManager.GetUserIdAsync(User.Identity.Name);
                    var user = await _userManager.GetUserAsync(User);
                    //var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                    //Find patient by user ID
                    var patient = _patientAPI.FindPatientByUserID(user.Id);

                //If found  ...add that as a foreign key

                //model.MainMemberId = patient.PatientId;

                //If patient does not exist..

                //Create new Patient object
                model.MainMemberID = patient.PatientID;
                   


                    //If address is same as Main Member,
                    //populate those values from Main Member table
                    if (model.AddressSameasMainMember == true)
                    {
                        model.AddressLine1 = patient.AddressLine1;
                        model.AddressLine2 = patient.AddressLine2;
                        model.SuburbID = patient.SuburbID;
                    }

                    // create the database entry
                    if (model.MedicalAidStatus == true)
                    {
                        //If MedicalAid Switch Selected
                        //Changed MedicalAidStatus to true

                        //If MedicalAidSame as Main Member,
                        //get medical aid details from Patient Table
                        if (model.MedicalAidSameasMainMember == true)
                        {
                            model.MedicalAidPlanId = patient.MedicalAidPlanID;
                            model.MedicalAidNo = patient.MedicalAidNo;
                            model.DependencyCode = model.DependencyCode;
                        }
                       

                        //Add dependent
                        _patientAPI.AddDependent(model);


                    }
                    else if (model.MedicalAidStatus == false)
                    {
                        //If MedicalAid Switch not selected
                       
                        //ADD DEPENDENT
                        _patientAPI.AddDependent(model);


                    }

                     model.Alert = new AlertModel
                    {
                    AlertType = AlertType.Success,
                     Message = $"{model.FirstName} {model.LastName} added as dependent!"
                     };

                         // store alert in session memory to show in different page
                         HttpContext.Session.Set<AlertModel>(nameof(AlertModel), model.Alert);

                            //return View();
                            //Add alert
          
                            return RedirectToAction("ViewProfile", "Profile");
                    //return RedirectToAction("ProfileAvatar", "Profile", new { model });
                }

            // reload the page with the user's input
            model.Alert = new AlertModel
            {
                AlertType = AlertType.Error,
                Message = "Could not add dependent!"
            };

            // store alert in session memory to show in different page
            HttpContext.Session.Set<AlertModel>(nameof(AlertModel), model.Alert);
            //ModelState.AddModelError(string.Empty, "Could not create profile. Try again");
            return View(model);
            
        }


        [HttpGet]

        public IActionResult RequestTest()
        {
            var user1 = _userManager.FindByEmailAsync(User.Identity.Name).Result;

            ////find patient using USerID
            var patient = _patientAPI.FindPatientByUserID(user1.Id);
            //patient.PatientId = patient.PatientId;

            TestRequestViewModel vm = new TestRequestViewModel();


            vm.SuburbId = patient.SuburbID;


            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RequestTest(TestRequestViewModel model)
        {
            // no validation errors
            if (ModelState.IsValid)
            {
                // who is making the test request ?
                var user = await _userManager.GetUserAsync(User);
                var patient = _patientAPI.FindPatientByUserID(user.Id);


                // Assign PatientID 
                model.PatientId = patient.PatientID;

                // is this request for the patient ?
                if (model.testforMyself)
                {
                    // create a test request for the patient
                    _patientAPI.AddTestRequest(model);
                }

                // is this request for the dependant ?
                if (model.SelectedDependentIds?.Length > 0)
                {
                    // create a test request for the dependant(s)
                    foreach (var dependantID in model.SelectedDependentIds)
                    {
                        //Assign PatientID

                        // Assign dependentID 
                        model.DependentId = dependantID;
                        // create a test request for one depedant
                        _patientAPI.AddTestRequest(model);
                    }
                }
                model.Alert = new AlertModel
                {
                    AlertType = AlertType.Success,
                    Message = "Test Request has been made."
                };
                // store alert in session memory to show in different page
                HttpContext.Session.Set<AlertModel>(nameof(AlertModel), model.Alert);
                return RedirectToAction("PatientDashboard", "Home");
            }

            model.Alert = new AlertModel
            {
                AlertType = AlertType.Error,
                Message = "Test Request was unsuccessful!"
            };
            // store alert in session memory to show in different page
            HttpContext.Session.Set<AlertModel>(nameof(AlertModel), model.Alert);
            return View(model);
        }

        [HttpGet]

        public IActionResult ViewTestResults()
        {
            var model = new TestRequestViewModel()
            {
                Alert = HttpContext.Session.GetAndRemove<AlertModel>(nameof(AlertModel)) ?? default
            };
            return View(model);
        }

        [HttpGet]
         public IActionResult ViewProfile()
        {
            var model = new DependentCreateViewModel()
            {
                Alert = HttpContext.Session.GetAndRemove<AlertModel>(nameof(AlertModel)) ?? default
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CancelTest(TestRequestDetailModel model, int testRequestID, string userID)
        {
            // call the database service
            var result = _patientAPI.TestCancel(testRequestID, userID);

            if (result)
            {
                model.Alert = new AlertModel
                {
                    AlertType = AlertType.Success,
                    Message = "Test Request was cancelled"
                };
                return RedirectToAction("PatientDashboard", "Home");
            }

            model.Alert = new AlertModel
            {
                AlertType = AlertType.Error,
                Message = "Test Request could not be cancelled"
            };
            return RedirectToAction("PatientDashboard", "Home");
        }
    }
}
