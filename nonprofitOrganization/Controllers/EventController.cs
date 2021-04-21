using Microsoft.AspNetCore.Mvc;
using nonprofitOrganization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using nonprofitOrganization.Data;

namespace nonprofitOrganization.Controllers
{
    public class EventController : Controller
    {
        //Code
        private NonProfitContext context { get; set; }

        public EventController(NonProfitContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            return View("Edit", new Event());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            Event events = context.Events.Find(id);
            return View("Edit", events);
        }

        [HttpPost]
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
        public IActionResult Delete(int id)
        {
            var events = context.Events.Find(id);
            return View(events);
        }

        //Code for the Delete view for HttpPost
        [HttpPost]
        public IActionResult Delete(Event events)
        {
            context.Events.Remove(events);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
