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
    public class AlumController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlumController(ApplicationDbContext context)
        {
            _context = context;
        }

            // GET: Alum
            public async Task<IActionResult> Index(
                string sortOrder,
                string currentFilter,
                string searchString,
                int? page)
            {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CohortSortParm"] = sortOrder == "Cohort" ? "cohort_desc" : "Cohort";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var alums = from a in _context.Alum
                           select a;
            if (!String.IsNullOrEmpty(searchString))
            {
                alums = alums.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    alums = alums.OrderByDescending(a => a.LastName);
                    break;
                case "Cohort":
                    alums = alums.OrderBy(a => a.CohortId);
                    break;
                case "cohort_desc":
                    alums = alums.OrderByDescending(a => a.CohortId);
                    break;
                default:
                    alums = alums.OrderBy(a => a.LastName);
                    break;
            }

            int pageSize = 7;
            return View(await PaginatedList<Alum>.CreateAsync(alums.AsNoTracking(), page ?? 1, pageSize));
        }

        // GET: Alum/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alum = await _context.Alum
                .Include(a => a.Cohort)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (alum == null)
            {
                return NotFound();
            }

            return View(alum);
        }

        // GET: Alum/Create
        public IActionResult Create()
        {
            ViewData["CohortId"] = new SelectList(_context.Cohort, "Id", "Number");
            return View();
        }

        // POST: Alum/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,CohortId,Address,Address2,City,State,ZipCode,Phone,Email,GitHub,LinkedIn,Slack")] Alum alum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CohortId"] = new SelectList(_context.Cohort, "Id", "Number", alum.CohortId);
            return View(alum);
        }

        // GET: Alum/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alum = await _context.Alum.SingleOrDefaultAsync(m => m.Id == id);
            if (alum == null)
            {
                return NotFound();
            }
            ViewData["CohortId"] = new SelectList(_context.Cohort, "Id", "Number", alum.CohortId);
            return View(alum);
        }

        // POST: Alum/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,CohortId,Address,Address2,City,State,ZipCode,Phone,Email,GitHub,LinkedIn,Slack")] Alum alum)
        {
            if (id != alum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumExists(alum.Id))
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
            ViewData["CohortId"] = new SelectList(_context.Cohort, "Id", "Number", alum.CohortId);
            return View(alum);
        }

        // GET: Alum/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alum = await _context.Alum
                .Include(a => a.Cohort)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (alum == null)
            {
                return NotFound();
            }

            return View(alum);
        }

        // POST: Alum/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alum = await _context.Alum.SingleOrDefaultAsync(m => m.Id == id);
            _context.Alum.Remove(alum);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlumExists(int id)
        {
            return _context.Alum.Any(e => e.Id == id);
        }
    }
}
