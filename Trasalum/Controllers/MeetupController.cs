using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trasalum.Data;
using Trasalum.Models;

namespace Trasalum.Controllers
{
    public class MeetupController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MeetupController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Meetup
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Meetup.Include(m => m.Tech).OrderBy(m => m.Name);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Meetup/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetup = await _context.Meetup
                .Include(m => m.Tech)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (meetup == null)
            {
                return NotFound();
            }

            return View(meetup);
        }

        // GET: Meetup/Create
        public IActionResult Create()
        {
            ViewData["TechId"] = new SelectList(_context.Tech, "Id", "Name");
            return View();
        }

        // POST: Meetup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,TechId")] Meetup meetup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meetup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TechId"] = new SelectList(_context.Tech, "Id", "Name", meetup.TechId);
            return View(meetup);
        }

        // GET: Meetup/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetup = await _context.Meetup.SingleOrDefaultAsync(m => m.Id == id);
            if (meetup == null)
            {
                return NotFound();
            }
            ViewData["TechId"] = new SelectList(_context.Tech, "Id", "Name", meetup.TechId);
            return View(meetup);
        }

        // POST: Meetup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,TechId")] Meetup meetup)
        {
            if (id != meetup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meetup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetupExists(meetup.Id))
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
            ViewData["TechId"] = new SelectList(_context.Tech, "Id", "Name", meetup.TechId);
            return View(meetup);
        }

        // GET: Meetup/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetup = await _context.Meetup
                .Include(m => m.Tech)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (meetup == null)
            {
                return NotFound();
            }

            return View(meetup);
        }

        // POST: Meetup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meetup = await _context.Meetup.SingleOrDefaultAsync(m => m.Id == id);
            _context.Meetup.Remove(meetup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetupExists(int id)
        {
            return _context.Meetup.Any(e => e.Id == id);
        }
    }
}
