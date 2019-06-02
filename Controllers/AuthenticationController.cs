﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

using ArtAuction.Models;
using ArtAuction.Models.Collections;
using ArtAuction.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace ArtAuction.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IUserCollection _users;
        private readonly IEditableCollection<Gallery> _galleries;

        public AuthenticationController(IUserCollection users, IEditableCollection<Gallery> galleries)
        {
            _users = users;
            _galleries = galleries;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user =  _users.FindUser(model.Email);
                if (user != null)
                {
                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("","Invalid login attempt.");
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _users.FindUser(model.Email);
                if (user == null)
                {
                    User newUser = model.RegisterUser();
                    if (newUser.IsRepresentative)
                    {
                        newUser.Role = "Representative";
                        Gallery gallery = _galleries.Objects.Find(gal => gal.Title == newUser.Gallery);
                        newUser.GalleryId = gallery.Id;
                        _users.AddUser(newUser);
                        gallery.HasRepresentatives = true;
                        if (gallery.Representatives == null)
                        {
                            gallery.Representatives = new List<User>();
                        }
                        gallery.Representatives.Add(newUser);
                        _galleries.UpdateObject(gallery);
                    }
                    
                    await Authenticate(newUser);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Account with this e-mail already exists!");
            }

            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Authentication");
        }

        private async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim("FullName", $"{user.FirstName} {user.LastName}"),
                //new Claim(ClaimTypes.Role, user.Role == "Admin" ? "Administrator" : "User"),
                new Claim(ClaimTypes.Role, user.Role),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));
        }

       /* private string _role(string role)
        {
            switch (role)
            {
                case "Admin":
                    return "Administrator";
                    break;
                case "Representative":

            }
        }*/
    }
}