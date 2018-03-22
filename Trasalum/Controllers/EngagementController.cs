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
            var pastEvents = _context.Engagement.Where(e => e.Date < DateTime.Now).OrderByDescending(e => e.Date).Include(e => e.EngagementType).Include(e => e.Meetup).Include(e => e.Note).Include(e => e.Tech);

            var futureEvents = _context.Engagement.Where(e => e.Date >= DateTime.Now).OrderByDescending(e => e.Date).Include(e => e.EngagementType).Include(e => e.Meetup).Include(e => e.Note).Include(e => e.Tech);

            ViewData["PastEvents"] = pastEvents;
            ViewData["FutureEvents"] = futureEvents;
            return View();
        }

        // GET: Engagement/Details/5
        public async Task<IActionResult> Details(int? id)
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
            var alumSpeakerId = _context.EngagementAlum.Where(ea => ea.EngagementId == id).Single().AlumId;
            var alumSpeaker = _context.Alum.Where(a => a.Id == alumSpeakerId).Single();
            
            var currentSpeaker = "";
            if (alumSpeaker.LastName == "(NONE)")
                {
                    currentSpeaker = alumSpeaker.LastName;
                }
            else
                {
                    currentSpeaker = alumSpeaker.LastName + ", " + alumSpeaker.FirstName;
                }

            var currentStaff = _context.Staff.Where(s => s.Id == engagement.StaffId).Single().Name;

            EngagementComments currentEngagementComments = new EngagementComments()
            {
                Date = engagement.Date,
                Organizer = _context.Staff.Where(s => s.Id == engagement.StaffId).Single().Name,
                Description = engagement.Description,
                EngagementType = _context.EngagementType.Where(et => et.Id == engagement.EngagementTypeId),
                Comment = _context.Note.Where(n => n.Id == engagement.NoteId).Single().Detail
            };
            
            ViewData["CurrentAlum"] = currentSpeaker;
            ViewData["CurrentEngagementId"] = id;
            ViewData["CurrentEngagementType"] = _context.EngagementType.Where(et => et.Id == engagement.EngagementTypeId).Single().Name;
            ViewData["CurrentMeetup"] = _context.Meetup.Where(m => m.Id == engagement.MeetupId).Single().Name; 
            ViewData["CurrentTech"] = _context.Tech.Where(t => t.Id == engagement.TechId).Single().Name;
           
            return View(currentEngagementComments);
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
            ViewData["EngagementType"] = new SelectList(_context.EngagementType.OrderBy(et => et.Name), "Id", "Name");
            ViewData["Meetup"] = new SelectList(_context.Meetup.OrderBy(m => m.Name), "Id", "Name");
            ViewData["Tech"] = new SelectList(_context.Tech.OrderBy(t => t.Name), "Id", "Name");

            return View();
        }

        // POST: Engagement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DateTime Date, string Description, int EngagementType, int Tech, int Meetup, string Comment, string Organizer, int Alum)
        {
            

            if (ModelState.IsValid)
            {
               // Save new Note in Note table
                var noteToAdd = new Note { Detail = Comment };
                _context.Note.Add(noteToAdd);
                await _context.SaveChangesAsync();

                // Save new Engagement in Engagement table
                var engagementToAdd = new Engagement();
                engagementToAdd.Date = Date;
                engagementToAdd.Description = Description;
                engagementToAdd.EngagementTypeId = EngagementType;
                engagementToAdd.TechId = Tech;
                engagementToAdd.MeetupId = Meetup;
                engagementToAdd.StaffId = _context.Staff.Where(s => s.Name == Organizer).Single().Id;
                engagementToAdd.NoteId = noteToAdd.Id;
                _context.Engagement.Add(engagementToAdd);
                await _context.SaveChangesAsync();

                // Save new EngagementAlum in EngagementAlum table
                var engagementAlumToAdd = new EngagementAlum();
                engagementAlumToAdd.AlumId = Alum;
                engagementAlumToAdd.EngagementId = engagementToAdd.Id;
                _context.EngagementAlum.Add(engagementAlumToAdd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

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
            ViewData["EngagementType"] = new SelectList(_context.EngagementType.OrderBy(et => et.Name), "Id", "Name");
            ViewData["Meetup"] = new SelectList(_context.Meetup.OrderBy(m => m.Name), "Id", "Name");
            ViewData["Tech"] = new SelectList(_context.Tech.OrderBy(t => t.Name), "Id", "Name");
            return View();
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

            var alumSpeakerId = _context.EngagementAlum.Where(ea => ea.EngagementId == id).Single().AlumId;
            var alumSpeaker = _context.Alum.Where(a => a.Id == alumSpeakerId).Single();
            var currentSpeaker = "";
            if (alumSpeaker.LastName == "(NONE)")
            {
                currentSpeaker = alumSpeaker.LastName;
            } else
            {
                currentSpeaker = alumSpeaker.LastName + ", " + alumSpeaker.FirstName;
            }
            
            var currentStaff = _context.Staff.Where(s => s.Id == engagement.StaffId).Single().Name;

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
            ViewData["CurrentAlum"] = currentSpeaker;
            ViewData["CurrentOrganizer"] = currentStaff;
            ViewData["EngagementTypeId"] = new SelectList(_context.EngagementType, "Id", "Name", engagement.EngagementTypeId);
            ViewData["MeetupId"] = new SelectList(_context.Meetup, "Id", "Name", engagement.MeetupId);
            ViewData["NoteId"] = new SelectList(_context.Note, "Id", "Detail", engagement.NoteId);
            ViewData["TechId"] = new SelectList(_context.Tech, "Id", "Name", engagement.TechId);
            ViewData["OrganizerId"] = new SelectList(_context.Staff, "Id", "Name", engagement.StaffId);
            return View(engagement);
        }

        // POST: Engagement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DateTime Date, string Description, int EngagementType, int Tech, int Meetup, string Comment, string Organizer, int Alum)
        {
            var engagementToUpdate = _context.Engagement.Where(m => m.Id == id).Single();
            engagementToUpdate.Date = Date;
            engagementToUpdate.Description = Description;
            engagementToUpdate.EngagementTypeId = EngagementType;
            engagementToUpdate.TechId = Tech;
            engagementToUpdate.MeetupId = Meetup;
            engagementToUpdate.StaffId = _context.Staff.Where(s => s.Name == Organizer).Single().Id;


            var noteToUpdate = _context.Note.Where(n => n.Id == engagementToUpdate.Note.Id).Single();
            noteToUpdate.Detail = Comment;
            _context.Note.Update(noteToUpdate);

            var engagementAlumToUpdate = _context.EngagementAlum.Where(ea => ea.EngagementId == engagementToUpdate.Id).Single();
            engagementAlumToUpdate.AlumId = Alum;
            _context.EngagementAlum.Update(engagementAlumToUpdate);

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Engagement.Update(engagementToUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EngagementExists(engagementToUpdate.Id))
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
            ViewData["CurrentAlum"] = Alum;
            ViewData["CurrentOrganizer"] = Organizer;
            ViewData["EngagementTypeId"] = new SelectList(_context.EngagementType, "Id", "Name", engagementToUpdate.EngagementTypeId);
            ViewData["MeetupId"] = new SelectList(_context.Meetup, "Id", "Name", engagementToUpdate.MeetupId);
            ViewData["NoteId"] = new SelectList(_context.Note, "Id", "Detail", engagementToUpdate.NoteId);
            ViewData["TechId"] = new SelectList(_context.Tech, "Id", "Name", engagementToUpdate.TechId);
            ViewData["OrganizerId"] = new SelectList(_context.Staff, "Id", "Name", engagementToUpdate.StaffId);
            return View(engagementToUpdate);
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
            var noteIdToRemove = _context.Engagement.Where(e => e.Id == id).Single().NoteId;
            var noteToRemove = await _context.Note.SingleOrDefaultAsync(n => n.Id == noteIdToRemove);
            _context.Note.Remove(noteToRemove);
            await _context.SaveChangesAsync();

            var engagementAlumToRemove = _context.EngagementAlum.Where(ea => ea.EngagementId == id).Single();
            _context.EngagementAlum.Remove(engagementAlumToRemove);
            await _context.SaveChangesAsync();

            var engagementToRemove = await _context.Engagement.SingleOrDefaultAsync(m => m.Id == id);
            _context.Engagement.Remove(engagementToRemove);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        private bool EngagementExists(int id)
        {
            return _context.Engagement.Any(e => e.Id == id);
        }
    }
}
