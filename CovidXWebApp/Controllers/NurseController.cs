﻿using CovidXWebApp.Models;
using CovidXWebApp.Models.ViewModel;
using CovidXWebApp.Services.Interface;
using EFCore.EFCoreConfigurationMethods;
using EFCore.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Controllers
{
    public class NurseController : Controller

    {
        private readonly UserManager<EFCoreIdentityUser> _userManager;

        private readonly SignInManager<EFCoreIdentityUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly INurseServices _nurseServices;
        public NurseController(UserManager<EFCoreIdentityUser> userManager, SignInManager<EFCoreIdentityUser> signInManager, RoleManager<IdentityRole> roleManager, INurseServices nurseServices)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _nurseServices = nurseServices;
        }

        [HttpGet]
        public IActionResult NurseRegister()
        {
            return View();
        }
        /// <summary>
        /// Create a new user account to allow Authentication [with return URL]
        /// </summary>
        /// <param name="model">The user registration data</param>
        /// <param name="returnUrl">The link the user was trying to access</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> NurseRegister(RegistrationModel model, string returnUrl)
        {
            // verify that the model properties passed validation 
            if (ModelState.IsValid)
            {
                // verify if email is already registered
                var existingUser = await _userManager.FindByEmailAsync(model.Email);

                if (existingUser is not null)
                {
                    // reload the registration view with the user's input
                    ModelState.AddModelError(string.Empty, CovidAuthError.EMAILUSED);
                    return View(model);
                }

                // create a user object and specify the details
                var newUser = new EFCoreIdentityUser { Email = model.Email, UserName = model.Email };

                // create the user on the database
                var result = await _userManager.CreateAsync(newUser, model.Password);

                // was the user create successfully
                if (result.Succeeded)
                {
                    // does the patient role exist ?
                    var roleExists = await _roleManager.RoleExistsAsync(CovidXRoles.NURSE);
                    // attempt to add role
                    if (roleExists == false)
                    {
                        // if not, add the role
                        var role = new IdentityRole(CovidXRoles.NURSE);
                        var roleResult = await _roleManager.CreateAsync(role);

                        // could not create role
                        if (roleResult.Succeeded == false)
                        {
                            // remove user from system
                            var userToRemove = await _userManager.FindByEmailAsync(model.Email);
                            // error handling ?
                            /* var removeResult = */
                            await _userManager.DeleteAsync(userToRemove);

                            if (roleResult.Succeeded == false)
                            {
                                await _userManager.SetLockoutEnabledAsync(userToRemove, true);
                            }
                        }
                    }

                    // add user to role
                    var signinResult = await _userManager.AddToRoleAsync(newUser, CovidXRoles.NURSE);

                    // sign the user in if register
                    if (signinResult.Succeeded)
                    {
                        await _signInManager.SignInAsync(newUser, isPersistent: false);
                    }

                   

                    // redirect the user to the dashboard ?
                    return RedirectToAction("NurseCreate", "Nurse");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            // reload the registration view with the user's input
            ModelState.AddModelError(string.Empty, "Invalid Registration Attempt");
            return View(model);
        }

        [HttpGet]
        public IActionResult NurseCreate()
        {


            return View(new NurseCreateViewModel());
        }

        //POST: Patient/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NurseCreate(NurseCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                //// get user id value...
                ////var user = _userManager.GetUserIdAsync(User.Identity.Name);
                //var user = await _userManager.GetUserAsync(User);
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                // ...add that as a foreign key
                //model.UserID = user.Id;

                //Check if patient already exist
                var nurseExists = _nurseServices.NurseExists(user.Id);

                if (nurseExists == true)
                {
                    // reload the registration view with the user's input
                    TempData[WCAlert.Error] = "This nurse already exists in DB!";
                    ModelState.AddModelError("Profile Error", "This nurse already exists in DB. ");
                    return View(model);
                }

                //If patient does not exist..
                //Create new Patient object
                model.UserID = user.Id;

                var result = _nurseServices.AddNurse(model);

                if (result)
                {

                    //return View();
                    //Add alert
                    TempData[WCAlert.Success] = "Nurse Profile created successfully!";
                    return RedirectToAction("Dashboard", "Home");
                }

                //return RedirectToAction("ProfileAvatar", "Profile", new { model });
            }

            // reload the page with the user's input
            TempData[WCAlert.Success] = "Nurse Profile could not be created!";
            //ModelState.AddModelError(string.Empty, "Could not create profile. Try again");
            return View(model);

        }
    }
}
