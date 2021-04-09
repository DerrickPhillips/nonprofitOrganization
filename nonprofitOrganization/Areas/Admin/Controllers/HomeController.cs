using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace nonprofitOrganization.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]

    public class HomeController : Controller
    {
        [Route("{area}/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
