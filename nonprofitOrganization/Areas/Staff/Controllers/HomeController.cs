using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nonprofitOrganization.Areas.Staff.Controllers
{
    // Code to only authorize this area for admin users DP.
    [Authorize(Roles = "Staff")]
    [Area("Staff")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
