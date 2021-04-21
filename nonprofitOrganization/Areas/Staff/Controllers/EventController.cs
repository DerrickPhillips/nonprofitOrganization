using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using nonprofitOrganization.Models;
using nonprofitOrganization.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nonprofitOrganization.Areas.Staff.Controllers
{
    // Code to only authorize this area for admin users DP.
    [Authorize(Roles = "Staff")]
    [Area("Staff")]

    public class EventController : Controller
    {

        //Code
        private NonProfitContext context { get; set; }

        public EventController(NonProfitContext ctx)
        {
            context = ctx;
        }

        [Route("{area}/{controller}/{action}/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("{area}/{controller}/{action}/")]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            return View("Edit", new Event());
        }

        [HttpGet]
        [Route("{area}/{controller}/{action}/")]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            Event events = context.Events.Find(id);
            return View("Edit", events);
        }

        [HttpPost]
        [Route("{area}/{controller}/{action}/")]
        public IActionResult Edit(Event events)
        {
            if (ModelState.IsValid)
            {
                if (events.EventID == 0)
                {
                    //Code to add CreatedDate
                    //events.CreatedDate = DateTime.Now;
                    context.Events.Add(events);
                }


                else
                    context.Events.Update(events);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (events.EventID == 0) ? "Add" : "Edit";
                ViewBag.Categories = context.Events.OrderBy(c => c.EventName).ToList();
                return View(events);
            }
        }

        //Code for the Delete view for HpptGet
        [HttpGet]
        [Route("{area}/{controller}/{action}/")]
        public IActionResult Delete(int id)
        {
            var events = context.Events.Find(id);
            return View(events);
        }

        //Code for the Delete view for HttpPost
        [HttpPost]
        [Route("{area}/{controller}/{action}/")]
        public IActionResult Delete(Event events)
        {
            context.Events.Remove(events);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
