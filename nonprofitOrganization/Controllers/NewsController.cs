using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nonprofitOrganization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using nonprofitOrganization.Data;

namespace nonprofitOrganization.Models
{
    public class NewsController : Controller
    {

        private readonly NonProfitContext _context;

        public NewsController(NonProfitContext context)
        {
            _context = context;
        }


        [Authorize(Roles = "Admin, Staff")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.News.ToListAsync());
        }


        public async Task<IActionResult> SingleView(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
            .FirstOrDefaultAsync(m => m.NewsID == id);

            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }


        [Authorize(Roles = "Admin, Staff")]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Staff")]
        public async Task<IActionResult> Create([Bind("NewsID,DatePosted,NewsAuthor,NewsTitle,Body")] News news)
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


        [Authorize(Roles = "Admin, Staff")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Staff")]
        public async Task<IActionResult> Edit(int id, [Bind("NewsID,DatePosted,NewsAuthor,NewsTitle,Body")] News news)
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
                    if (!News(news.NewsID))
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


        [Authorize(Roles = "Admin, Staff")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
            .FirstOrDefaultAsync(m => m.NewsID == id);

            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin, Staff")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool News(int? id)
        {
            return _context.News.Any(e => e.NewsID == id);
        }

        public async Task<IActionResult> RecentView()
        {
            return View(await _context.News.ToListAsync());
        }

    }
}
