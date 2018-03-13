using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trasalum.Data;
using Trasalum.Models;
using Trasalum.Models.CohortViewModels;

namespace Trasalum.Controllers
{
    public class CohortController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CohortController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cohorts
        public async Task<IActionResult> Index()
        {
            //var applicationDbContext = _context.Cohort
            //.OrderBy(t => t.DemoDate);
            //.Include(t => t.Tech);

            //return View(await applicationDbContext.ToListAsync());
            CohortDetailedListViewModel model = new CohortDetailedListViewModel();
            model.CohortDetailedList = 
                _context.Cohort
                .Include("CohortStaff")
                .Include("CohortTech")
                .Select(cohort => new CohortDetailedList
                {
                    Cohort = cohort,
                    Instructors = cohort.CohortStaff.Select(cs => cs.Staff),
                    Tech = cohort.CohortTech.Select(ct => ct.Tech)
                });
            
            return View(model); 
        }

        // GET: Cohorts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CohortDetailedList model = new CohortDetailedList();

            model.Cohort = await _context.Cohort.Where(p => p.Id == id).SingleOrDefaultAsync();

            if (model.Cohort == null)
            {
                return NotFound();
            }
            
            return View(model);
            /*
            model.Instructors = await _context.CohortStaff.Include(cs => cs.Staff).Where(cs => cs.CohortId == model.Cohort.Id).Select(s => s.Staff).ToListAsync();

            if (model.Cohort == null)
            {
                return NotFound();
            }

            model.Tech = await _context.CohortTech.Include(cs => cs.Tech).Where(cs => cs.CohortId == model.Cohort.Id).Select(s => s.Tech).ToListAsync();

            if (model.Cohort == null)
            {
                return NotFound();
            }

            return View(model); */
        }

        // GET: Cohorts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cohorts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Night,Number,StartDate,DemoDate")] Cohort cohort)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cohort);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cohort);
        }

        // GET: Cohorts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cohort = await _context.Cohort.SingleOrDefaultAsync(m => m.Id == id);
            if (cohort == null)
            {
                return NotFound();
            }
            return View(cohort);
        }

        // POST: Cohorts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Night,Number,StartDate,DemoDate")] Cohort cohort)
        {
            if (id != cohort.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cohort);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CohortExists(cohort.Id))
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
            return View(cohort);
        }

        // GET: Cohorts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cohort = await _context.Cohort
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cohort == null)
            {
                return NotFound();
            }

            return View(cohort);
        }

        // POST: Cohorts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cohort = await _context.Cohort.SingleOrDefaultAsync(m => m.Id == id);
            _context.Cohort.Remove(cohort);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CohortExists(int id)
        {
            return _context.Cohort.Any(e => e.Id == id);
        }
    }
}
