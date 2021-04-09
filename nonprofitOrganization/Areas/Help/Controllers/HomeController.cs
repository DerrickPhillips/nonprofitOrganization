using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nonprofitOrganization.Areas.Help.Controllers
{
    [Area("Help")]

    public class HomeController : Controller
    {
        [Route("{area}/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
