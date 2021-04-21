using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nonprofitOrganization.Models;
using nonprofitOrganization.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace nonprofitOrganization.Controllers
{
    public class DonationController : Controller
    {
        private NonProfitContext context { get; set; }
        private readonly UserManager<User> _userManager;

        public DonationController(NonProfitContext context, UserManager<User> userManager)
        {
            this.context = context;
             _userManager = userManager;
        }
       

        public async Task<IActionResult> IndexAsync()
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            var donations = context.Donations.Include(d => d.Donor).Include(d => d.DonationType).OrderBy(d => d.DateDonated).ToList();

            return View(await context.Donations.Where(g => g.Id == currentUserID).ToListAsync());
            //var donations = context.Donations.Include(d => d.Donor).Include(d => d.DonationType).OrderBy(d => d.DateDonated).ToList();
            //return View(donations);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DonationViewAsync()
        {
            return View(await context.Donations.Include(d => d.Donor).Include(d => d.DonationType).OrderBy(d => d.DateDonated).ToListAsync());

        }


        [HttpGet]
        public IActionResult Add(Donation donation)
        {
            ViewBag.Action = "Add";
            ViewBag.Type = context.DonationTypes.OrderBy(c => c.Type).ToList();
            return View("Add", new Donation());
        }

        [HttpPost]
        public IActionResult Save(Donation donation, int DonorID)
        {

            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (ModelState.IsValid)
            {

                donation.Id = currentUserID;

                if (donation.ValidCard == false)
                {
                    ModelState.AddModelError(string.Empty, "Make sure you have entered a valid " + donation.CardNetwork + " card number.");
                    ViewBag.Action = "Add";
                    ViewBag.Type = context.DonationTypes.OrderBy(c => c.Type).ToList();
                    return View("Add", donation);
                }

                if (donation.DonationID == 0)
                {

                    donation.DonorID = DonorID;
                    donation.DateDonated = DateTime.Now;
                    context.Donations.Add(donation);
                }
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Action = "Add";
                ViewBag.Type = context.DonationTypes.OrderBy(c => c.Type).ToList();
                return View("Add", donation);
            }
        }
    }
}
