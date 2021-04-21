using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nonprofitOrganization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using nonprofitOrganization.Data;

namespace nonprofitOrganization.Controllers
{
    public class NewsController : Controller
    {

        private readonly NonProfitContext _context;

        public NewsController(NonProfitContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Administrator, Volunteer")]
        // GET: NewsAndEvents
        public async Task<IActionResult> Index()
        {
            return View(await _context.News.ToListAsync());
        }

        [Authorize(Roles = "Administrator, Volunteer")]
        // GET: NewsAndEvents/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsAndEvents = await _context.News
                .FirstOrDefaultAsync(m => m.NewsID == id);
            if (newsAndEvents == null)
            {
                return NotFound();
            }

            return View(newsAndEvents);
        }

        public async Task<IActionResult> SingleView(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsAndEvents = await _context.News
                .FirstOrDefaultAsync(m => m.NewsID == id);
            if (newsAndEvents == null)
            {
                return NotFound();
            }

            return View(newsAndEvents);
        }

        [Authorize(Roles = "Administrator, Volunteer")]
        // GET: NewsAndEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewsAndEvents/Create
        [Authorize(Roles = "Administrator, Volunteer")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DatePosted,Author,Title,Body")] News news)
        {
            news.DatePosted = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(news);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: NewsAndEvents/Edit/5
        [Authorize(Roles = "Administrator, Volunteer")]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsAndEvents = await _context.News.FindAsync(id);
            if (newsAndEvents == null)
            {
                return NotFound();
            }
            return View(newsAndEvents);
        }

        // POST: NewsAndEvents/Edit/5
        [Authorize(Roles = "Administrator, Volunteer")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,DatePosted,Author,Title,Body")] News news)
        {
            if (id != news.NewsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(news);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsAndEventsExists(news.NewsID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: NewsAndEvents/Delete/5
        [Authorize(Roles = "Administrator, Volunteer")]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsAndEvents = await _context.News
                .FirstOrDefaultAsync(m => m.NewsID == id);
            if (newsAndEvents == null)
            {
                return NotFound();
            }

            return View(newsAndEvents);
        }

        [Authorize(Roles = "Administrator, Volunteer")]
        // POST: NewsAndEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var newsAndEvents = await _context.News.FindAsync(id);
            _context.News.Remove(newsAndEvents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsAndEventsExists(long id)
        {
            return _context.News.Any(e => e.NewsID == id);
        }

        public async Task<IActionResult> RecentView()
        {
            return View(await _context.News.ToListAsync());
        }

    }
}
