using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using nonprofitOrganization.Models;

namespace nonprofitOrganization.Areas.Admin.Controllers
{
    // Code to only authorize this area for admin users DP.
    [Authorize(Roles = "Admin")]
    [Area("Admin")]

    public class HomeController : Controller
    {
        private UserManager<User> userManager;

        public HomeController(UserManager<User> usrManager)
        {
            userManager = usrManager;
        }

        //public ViewResult CreateStaff() => View();

        [Route("{area}/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{area}/funds")]
        public IActionResult Funds()
        {
            return View();
        }

        [HttpGet]
        [Route("{area}/createstaff")]
        public IActionResult CreateStaff()
        {
            return View();
        }

        [HttpPost]
        [Route("{area}/createstaff")]
        public async Task<IActionResult> CreateStaff(User user)
        {
            var hasher = new PasswordHasher<User>();
            if (ModelState.IsValid)
            {
                User identityUser = new User
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    NormalizedUserName = user.UserName.ToUpper(),
                    Email = user.Email,
                    NormalizedEmail = user.Email.ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, user.PasswordHash)
                };

                var result = await userManager.CreateAsync(identityUser);

                if (result.Succeeded)
                {
                    // Code that sets Staff role to user that admin creates DP.
                    userManager.AddToRoleAsync(identityUser, "Staff").Wait();
                    return RedirectToAction("CreateStaff");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(user);
        }
    }
}
