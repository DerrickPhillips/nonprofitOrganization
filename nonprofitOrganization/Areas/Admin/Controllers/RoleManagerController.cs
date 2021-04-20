using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nonprofitOrganization.Areas.Admin.Controllers
{
    // Code to only authorize this area for admin users DP.
    [Authorize(Roles = "Admin")]
    [Area("Admin")]

    // Code for a controller class that can manage user roles DP.
    public class RoleManagerController : Controller
    {

        private  RoleManager<IdentityRole> _roleManager;
        public RoleManagerController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [Route("{area}/{controller}/{action}/")]
        public async Task<IActionResult> ManageRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        [HttpPost]
        [Route("{area}/{controller}/{action}/")]
        public async Task<IActionResult> AddRole(string roleName)
        {
            if (roleName != null)
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
            }
            return RedirectToAction("manageroles", "rolemanager", new { area = "admin" });
        }

    }
}
