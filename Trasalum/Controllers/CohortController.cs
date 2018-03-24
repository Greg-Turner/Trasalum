using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trasalum.Data;
using Trasalum.Models;
using Trasalum.Models.CohortViewModels;
using Trasalum.Models.StaffViewModels;
using Trasalum.Models.TechViewModels;

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
        public async Task<IActionResult> Index(string sortOrder)
        {
            CohortDetailedListViewModel model = new CohortDetailedListViewModel
            {
                CohortDetailedList = await
                _context.Cohort
                .Include("CohortStaff")
                .Include("CohortTech")
                .Select(cohort => new CohortDetailedList
                {
                    Cohort = cohort,
                    Instructors = cohort.CohortStaff.Select(cs => cs.Staff),
                    Tech = cohort.CohortTech.Select(ct => ct.Tech)
                }).ToListAsync()
            };

            return View(model);
        }
      
        // GET: Cohorts/Add
        public IActionResult Add()
        {
            var cohort = new Cohort();
            cohort.CohortStaff = new List<CohortStaff>();
            cohort.CohortTech = new List<CohortTech>();
            ViewData["Techs"] = PopulateAssignedTechData(cohort);
            ViewData["Staffs"] = PopulateAssignedStaffData(cohort);
            return View(cohort);
        }

        // POST: Cohorts/Add
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(string Id, DateTime StartDate, DateTime DemoDate,int[] selectedTechs, int[] selectedStaffs)
        {
            Cohort cohort = new Cohort();
            cohort.Id = Id;
            cohort.StartDate = StartDate;
            cohort.DemoDate = DemoDate;

            if (selectedTechs != null)
            {
                cohort.CohortTech = new List<CohortTech>();
                foreach (var tech in selectedTechs)
                {
                    var techToAdd = new CohortTech { CohortId = cohort.Id, TechId = tech };
                    cohort.CohortTech.Add(techToAdd);
                }
            } else
            {
                cohort.CohortTech = new List<CohortTech>();
            }
            if (selectedStaffs != null)
            {
                cohort.CohortStaff = new List<CohortStaff>();
                foreach (var staff in selectedStaffs)
                {
                    var staffToAdd = new CohortStaff { CohortId = cohort.Id, StaffId = staff };
                    cohort.CohortStaff.Add(staffToAdd);
                }
            }
            else
            {
                cohort.CohortStaff = new List<CohortStaff>();
            }
            

            if (ModelState.IsValid)
            {
                _context.Add(cohort);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Techs"] = PopulateAssignedTechData(cohort);
            ViewData["Staffs"] = PopulateAssignedTechData(cohort);
            return View(cohort);
        }

        // GET: Cohorts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            
            var cohort = await _context.Cohort
                .Include(i => i.CohortTech).ThenInclude(i => i.Tech).Include(i => i.CohortStaff).ThenInclude(i => i.Staff)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cohort == null)
            {
                return NotFound();
            }
            ViewData["Techs"] = PopulateAssignedTechData(cohort);
            ViewData["Staffs"] = PopulateAssignedStaffData(cohort);
            return View(cohort);
        }

        // Adding viewmodel to display multiple Tech checkboxes
        private List<AssignedTechData> PopulateAssignedTechData(Cohort cohort)
        {
            var allTechs = _context.Tech.OrderBy( t => t.Name);
            var cohortTechs = new HashSet<int>(cohort.CohortTech.Select(c => c.TechId)); 
            var viewModel = new List<AssignedTechData>();
            foreach (var tech in allTechs)
            {
                viewModel.Add(new AssignedTechData
                {
                    TechId = tech.Id,
                    TechName = tech.Name,
                    Assigned = cohortTechs.Contains(tech.Id)
                });
            }
            return viewModel;
        }

        // Adding viewmodel to display multiple Staff checkboxes
        private List<AssignedStaffData> PopulateAssignedStaffData(Cohort cohort)
        {
            var allStaffs = _context.Staff
                .Include(s => s.Department).OrderBy(s => s.Name);
            var cohortStaffs = new HashSet<int>(cohort.CohortStaff.Select(c => c.StaffId)); 
            var viewModel = new List<AssignedStaffData>();
            foreach (var staff in allStaffs)
            {
                viewModel.Add(new AssignedStaffData
                {
                    StaffId = staff.Id,
                    StaffName = staff.Name,
                    Assigned = cohortStaffs.Contains(staff.Id),
                    Department = staff.Department.Name
                });
            }
            return viewModel;
        }

        // POST: Cohorts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, int[] selectedTechs, int[] selectedStaffs, [Bind("Id,StartDate,DemoDate")] Cohort cohort)
        {
            if (id != cohort.Id)
            {
                return NotFound();
            }

            var cohortToUpdate = await _context.Cohort
                .Include(c => c.CohortStaff)
                    .ThenInclude(c => c.Staff)
                .Include(c => c.CohortTech)
                    .ThenInclude(c => c.Tech)
                .SingleOrDefaultAsync(m => m.Id == id);

            if (await TryUpdateModelAsync<Cohort>(
                cohortToUpdate,
                "",
                c => c.Id, c => c.StartDate, c => c.DemoDate, c => c.CohortStaff, c => c.CohortTech))
            { 
                UpdateCohortTechs(selectedTechs, cohortToUpdate);
                UpdateCohortStaffs(selectedStaffs, cohortToUpdate);
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
            UpdateCohortStaffs(selectedStaffs, cohortToUpdate);
            UpdateCohortTechs(selectedTechs, cohortToUpdate);
            PopulateAssignedTechData(cohortToUpdate);
            PopulateAssignedStaffData(cohortToUpdate);
            return View(cohortToUpdate);
        }

        // Method to update CohortTechs
        private void UpdateCohortTechs(int[] selectedTechs, Cohort cohortToUpdate)
        {
            if (selectedTechs == null)
            {
                var unknown = (from t in _context.Tech
                             where t.Name.Equals("(Unknown)")
                             select t.Id).ToArray();
                selectedTechs = unknown;
            }

            var selectedTechsHS = new HashSet<int>(selectedTechs);
            var cohortTechs = new HashSet<int>
                (cohortToUpdate.CohortTech.Select(c => c.Tech.Id));
            foreach (var tech in _context.Tech)
            {
                if (selectedTechsHS.Contains(tech.Id))
                {
                    if (!cohortTechs.Contains(tech.Id))
                    {
                        cohortToUpdate.CohortTech.Add(new CohortTech { CohortId = cohortToUpdate.Id, TechId = tech.Id });
                    }
                }
                else
                {

                    if (cohortTechs.Contains(tech.Id))
                    {
                        CohortTech techToRemove = cohortToUpdate.CohortTech.SingleOrDefault(c => c.TechId == tech.Id);
                        _context.Remove(techToRemove);
                    }
                }
            }
        }
        // Method to update CohortStaff
        private void UpdateCohortStaffs(int[] selectedStaff, Cohort cohortToUpdate)
        {
            if (selectedStaff == null)
            {
                var unknown = (from s in _context.Staff
                             where s.Name.Equals("(Not Yet Assigned)")
                             select s.Id).ToArray();
                selectedStaff = unknown;
            }

            var selectedStaffHS = new HashSet<int>(selectedStaff);
            var cohortStaffs = new HashSet<int>
                (cohortToUpdate.CohortStaff.Select(c => c.Staff.Id));
            foreach (var staff in _context.Staff)
            {
                if (selectedStaffHS.Contains(staff.Id))
                {
                    if (!cohortStaffs.Contains(staff.Id))
                    {
                        cohortToUpdate.CohortStaff.Add(new CohortStaff { CohortId = cohortToUpdate.Id, StaffId = staff.Id });
                    }
                }
                else
                {

                    if (cohortStaffs.Contains(staff.Id))
                    {
                        CohortStaff staffToRemove = cohortToUpdate.CohortStaff.SingleOrDefault(c => c.StaffId == staff.Id);
                        _context.Remove(staffToRemove);
                    }
                }
            }
        }

        private bool CohortExists(string id)
        {
            return _context.Cohort.Any(e => e.Id == id);
        }

        // GET: Cohorts/Delete/5 ***NOT BEING USED YET***
        /*
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
        */

        // POST: Cohorts/Delete/5 ***NOT BEING USED YET***
        /*
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cohort = await _context.Cohort.SingleOrDefaultAsync(m => m.Id == id);
            _context.Cohort.Remove(cohort);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */

        // GET: Cohorts/Details/5 ***NOT BEING USED YET***
        /*
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CohortDetailedList model = new CohortDetailedList
            {
                Cohort = await _context.Cohort.Where(c => c.Id == id).SingleOrDefaultAsync()
            };

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

            return View(model); 
        }
        */

    }
}
