using CovidXWebApp.Models;
using EFCore;
using EFCore.EFCoreConfigurationMethods;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<EFCoreIdentityUser> _userManager;

        private readonly SignInManager<EFCoreIdentityUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<EFCoreIdentityUser> userManager, SignInManager<EFCoreIdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

        }

        [HttpGet]
        public IActionResult Register()
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
        public async Task<IActionResult> Register(RegistrationModel model, string returnUrl)
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
                    var roleExists = await _roleManager.RoleExistsAsync(CovidXRoles.PATIENT);
                    // attempt to add role
                    if (roleExists == false)
                    {
                        // if not, add the role
                        var role = new IdentityRole(CovidXRoles.PATIENT);
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
                    var signinResult = await _userManager.AddToRoleAsync(newUser, CovidXRoles.PATIENT);

                    // sign the user in if register
                    if (signinResult.Succeeded)
                    {
                        await _signInManager.SignInAsync(newUser, isPersistent: false);
                    }

                    // is the string empty ?
                    //bool isEmpty = string.IsNullOrWhiteSpace(returnUrl);

                    // is the string not empty?
                    //bool urlProvided = (isEmpty == false);

                    // is the URL valid
                    //bool isValidUrl = Url.IsLocalUrl(returnUrl);

                    // return the user to the previous page
                    //if (urlProvided && isValidUrl)
                    //{
                    //    // redirect the user to the previous page
                    //    return Redirect(returnUrl);
                    //}

                    // redirect the user to the dashboard ?
                    return RedirectToAction("Create", "Profile");
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
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(SigninModel model)
        {
            
            // did they provide a valid email and password?
            if (ModelState.IsValid)
            {
                // attempt to find the user based on the Email
                var user = await _userManager.FindByEmailAsync(model.Email);

                // if the user was found
                if (user is not null)
                {
                    // attempt to sign the user in
                    var result = await _signInManager.PasswordSignInAsync(user, password: model.Password, isPersistent: model.RememberMe, lockoutOnFailure: false);

                    // was the sign in successful
                    if (result.Succeeded)
                    {
                        // send the user to the dashboard page
                        return RedirectToAction("Dashboard", "Home");
                    }
                }
            }
            // reload the page with the user's input
            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            // sign the user out
            await _signInManager.SignOutAsync();

            // redirect to the sign in page
            return RedirectToAction("Index", "Home");
        }
    }
}
