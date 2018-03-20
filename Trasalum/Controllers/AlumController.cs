using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trasalum.Data;
using Trasalum.Models;
using Trasalum.Models.TechViewModels;

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
                    alums = alums.OrderBy(a => a.Cohort.Id);
                    break;
                case "cohort_desc":
                    alums = alums.OrderByDescending(a => a.Cohort.Id);
                    break;
                default:
                    alums = alums.OrderBy(a => a.LastName);
                    break;
            }

            int pageSize = 7;
            return View(await PaginatedList<Alum>.CreateAsync(alums.AsNoTracking(), page ?? 1, pageSize));
        }

        // Adding viewmodel to display multiple Tech checkboxes
        private List<AssignedTechData> PopulateAlumTechData(Alum alum)
        {
            var allTechs = _context.Tech;
            var alumTechs = new HashSet<int>(alum.AlumTech.Select(a => a.TechId)); 
            var viewModel = new List<AssignedTechData>();
            foreach (var tech in allTechs)
            {
                viewModel.Add(new AssignedTechData
                {
                    TechId = tech.Id,
                    TechName = tech.Name,
                    Assigned = alumTechs.Contains(tech.Id)
                });
            }
            return viewModel;
        }

        // GET: Alum/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var alum = await _context.Alum
                .Include(a => a.Cohort)
                .Include(a => a.AlumTech).ThenInclude(at => at.Tech)
                .SingleOrDefaultAsync(m => m.Id == id);

            ViewData["ContactHistory"] = PopulateAlumHistoricalContacts(id);
            ViewData["AlumTechData"] = PopulateAlumTechData(_context.Alum.Where(a => a.Id == id).Single());
            return View(alum);
        }

        // Method to generate alum historical contacts for an alum
        private List<Contact> PopulateAlumHistoricalContacts(int id)
        {
            List<Contact> historicalContacts = _context.Contact.Where(c => c.AlumId == id).Include(c => c.Alum).Include(c => c.ContactType).Include(c => c.Note).Include(c => c.Staff).OrderByDescending(c => c.Date).ToList();

            return historicalContacts;
        }


        // GET: Alum/Create
        public IActionResult Create()
        {
            ViewData["CohortId"] = new SelectList(_context.Cohort, "Id", "Id");
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
            ViewData["CohortId"] = new SelectList(_context.Cohort, "Id", alum.CohortId);
            return View(alum);
        }

        // GET: Alum/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var alum = await _context.Alum
                .Include(a => a.Cohort)
                .Include(a => a.AlumTech).ThenInclude(at => at.Tech)
                .SingleOrDefaultAsync(m => m.Id == id);
            ViewData["CohortId"] = new SelectList(_context.Cohort, "Id", "Id");
            ViewData["ContactHistory"] = PopulateAlumHistoricalContacts(id);
            ViewData["AlumTechData"] = PopulateAlumTechData(_context.Alum.Where(a => a.Id == id).Single());
            return View(alum);
        }

        // POST: Alum/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, int[] selectedTechs, [Bind("Id,FirstName,LastName,CohortId,Address,City,State,ZipCode,Phone,Email,GitHub,LinkedIn,Slack")] Alum alum)
        {
            if (id != alum.Id)
            {
                return NotFound();
            }

            var alumToUpdate = await _context.Alum
                .Include(a => a.Cohort)
                .Include(a => a.AlumTech).ThenInclude(at => at.Tech)
                .SingleOrDefaultAsync(m => m.Id == id);

            List<string> cohortList = _context.Cohort.Select(c => c.Id).ToList();

             if (await TryUpdateModelAsync<Alum>(
                alumToUpdate,
                "",
                a => a.Id, a => a.FirstName, a => a.LastName, a => a.CohortId, a => a.Address, a => a.City, a => a.State, a => a.ZipCode, a => a.Phone, a => a.Email, a => a.GitHub, a => a.LinkedIn, a => a.Slack, a => a.AlumTech))
             { 
                UpdateAlumTechs(selectedTechs, alumToUpdate);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
                return RedirectToAction(nameof(Index));
             }
            ViewData["CohortList"] = cohortList;
            UpdateAlumTechs(selectedTechs, alumToUpdate);
            PopulateAlumTechData(alumToUpdate);
            return View(alumToUpdate);          
        }

        // Method to update AlumTechs
        private void UpdateAlumTechs(int[] selectedTechs, Alum alumToUpdate)
        {
            if (selectedTechs == null)
            {
                var unknown = (from t in _context.Tech
                               where t.Name.Equals("(Unknown)")
                               select t.Id).ToArray();
                selectedTechs = unknown;
            }

            var selectedTechsHS = new HashSet<int>(selectedTechs);
            var alumTechs = new HashSet<int>
                (alumToUpdate.AlumTech.Select(c => c.Tech.Id));
            foreach (var tech in _context.Tech)
            {
                if (selectedTechsHS.Contains(tech.Id))
                {
                    if (!alumTechs.Contains(tech.Id))
                    {
                        alumToUpdate.AlumTech.Add(new AlumTech { AlumId = alumToUpdate.Id, TechId = tech.Id });
                    }
                }
                else
                {

                    if (alumTechs.Contains(tech.Id))
                    {
                        AlumTech techToRemove = alumToUpdate.AlumTech.SingleOrDefault(c => c.TechId == tech.Id);
                        _context.Remove(techToRemove);
                    }
                }
            }
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
