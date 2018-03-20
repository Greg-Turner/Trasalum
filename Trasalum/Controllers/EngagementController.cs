using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trasalum.Data;
using Trasalum.Models;

namespace Trasalum.Controllers
{
    public class EngagementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EngagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Engagement
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Engagement.Include(e => e.EngagementType).Include(e => e.Meetup).Include(e => e.Note).Include(e => e.Tech);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Engagement/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engagement = await _context.Engagement
                .Include(e => e.EngagementType)
                .Include(e => e.Meetup)
                .Include(e => e.Note)
                .Include(e => e.Tech)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (engagement == null)
            {
                return NotFound();
            }

            return View(engagement);
        }
        
        // GET: Engagement/Create
        public IActionResult Create()
        {
            var userId = User.Identity.GetUserId();
            var user = _context.ApplicationUser.Where(u => u.Id == userId).Single();
            string userName = user.FirstName + " " + user.LastName;

            ViewData["AlumList"] =
                    new SelectList((from a in _context.Alum.OrderBy(a => a.LastName).ToList()
                    select new
                    {
                        Id = a.Id,
                        FullName = a.LastName + ", " + a.FirstName
                    }),
                    "Id",
                    "FullName",
                    null);

            ViewData["Date"] = DateTime.Now;
            ViewData["Organizer"] = _context.Staff.Where(s => s.Name == userName).Single().Name;
            ViewData["EngagementType"] = new SelectList(_context.EngagementType, "Id", "Name");
            ViewData["Meetup"] = new SelectList(_context.Meetup, "Id", "Name");
            ViewData["Tech"] = new SelectList(_context.Tech, "Id", "Name");

            return View();
        }

        // POST: Engagement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Description,EngagementTypeId,TechId,MeetupId,NoteId")] Engagement engagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(engagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EngagementTypeId"] = new SelectList(_context.EngagementType, "Id", "Name", engagement.EngagementTypeId);
            ViewData["MeetupId"] = new SelectList(_context.Meetup, "Id", "Description", engagement.MeetupId);
            ViewData["NoteId"] = new SelectList(_context.Note, "Id", "Detail", engagement.NoteId);
            ViewData["TechId"] = new SelectList(_context.Tech, "Id", "Name", engagement.TechId);
            return View(engagement);
        }

        // GET: Engagement/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engagement = await _context.Engagement.SingleOrDefaultAsync(m => m.Id == id);
            if (engagement == null)
            {
                return NotFound();
            }
            ViewData["EngagementTypeId"] = new SelectList(_context.EngagementType, "Id", "Name", engagement.EngagementTypeId);
            ViewData["MeetupId"] = new SelectList(_context.Meetup, "Id", "Description", engagement.MeetupId);
            ViewData["NoteId"] = new SelectList(_context.Note, "Id", "Detail", engagement.NoteId);
            ViewData["TechId"] = new SelectList(_context.Tech, "Id", "Name", engagement.TechId);
            return View(engagement);
        }

        // POST: Engagement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Description,EngagementTypeId,TechId,MeetupId,NoteId")] Engagement engagement)
        {
            if (id != engagement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(engagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EngagementExists(engagement.Id))
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
            ViewData["EngagementTypeId"] = new SelectList(_context.EngagementType, "Id", "Name", engagement.EngagementTypeId);
            ViewData["MeetupId"] = new SelectList(_context.Meetup, "Id", "Description", engagement.MeetupId);
            ViewData["NoteId"] = new SelectList(_context.Note, "Id", "Detail", engagement.NoteId);
            ViewData["TechId"] = new SelectList(_context.Tech, "Id", "Name", engagement.TechId);
            return View(engagement);
        }

        // GET: Engagement/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engagement = await _context.Engagement
                .Include(e => e.EngagementType)
                .Include(e => e.Meetup)
                .Include(e => e.Note)
                .Include(e => e.Tech)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (engagement == null)
            {
                return NotFound();
            }

            return View(engagement);
        }

        // POST: Engagement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var engagement = await _context.Engagement.SingleOrDefaultAsync(m => m.Id == id);
            _context.Engagement.Remove(engagement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EngagementExists(int id)
        {
            return _context.Engagement.Any(e => e.Id == id);
        }
    }
}
