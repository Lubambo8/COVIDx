using CovidXWebApp.Authentication;
using CovidXWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<CovidXUser> _userManager;

        private readonly SignInManager<CovidXUser> _signInManager;

        public AccountController(UserManager<CovidXUser> userManager, SignInManager<CovidXUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Create a new user account to allow Authentication [with return URL]
        /// </summary>
        /// <param name="model">The user registration data</param>
        /// <param name="returnUrl">The link the user was trying to access</param>
        /// <returns></returns>
        public IActionResult Register(RegistrationModel model, string returnUrl)
        {
            // verify that the model properties passed validation 
            if (ModelState.IsValid)
            {
                // verify if email is already registered
                var existingUser = _userManager.FindByEmailAsync(model.Email);

                if (existingUser is not null)
                {
                    // reload the registration view with the user's input
                    ModelState.AddModelError("Email Error", "This email is already in use. Please try to login or use a different email.");
                    return View(model);
                }

                // create a user object and specify the details
                var newUser = new CovidXUser { Email = model.Email, UserName = model.Email, Active = true, UserType = "Patient" };

                // create the user on the database
                var result = _userManager.CreateAsync(newUser, model.Password);

                // was the user create successfully
                if (result.IsCompletedSuccessfully)
                {
                    // is the string empty ?
                    bool isEmpty = string.IsNullOrWhiteSpace(returnUrl);

                    // is the string not empty?
                    bool urlProvided = (isEmpty == false);

                    // is the URL valid
                    bool isValidUrl = Url.IsLocalUrl(returnUrl);

                    // return the user to the previous page
                    if (urlProvided && isValidUrl)
                    {
                        // redirect the user to the previous page
                        return Redirect(returnUrl);
                    }
                    // redirect the user to a page
                    return RedirectToAction("Signin", "Account");
                }
            }
            // reload the registration view with the user's input
            return View(model);
        }

        public async Task<IActionResult> SignIn(SigninModel model)
        {
            if (ModelState.IsValid)
            {
                // attempt to find the user based on the Email
                var user = await _userManager.FindByEmailAsync(model.Email);

                // if the user was not found
                if (user is null)
                {
                    // reload the page with the user's input
                    return View(model);
                }

                // attempt to sign the user in
                var result = await _signInManager.PasswordSignInAsync(user, password: model.Password, isPersistent: model.RememberMe/* false */, lockoutOnFailure: false);

                // was the sign in successful
                if (result.Succeeded)
                {
                    // send the user to the dashboard page
                    return RedirectToAction("Index", "Home");
                }
            }
            // reload the page with the user's input
            return View(model);
        }
    }
}
