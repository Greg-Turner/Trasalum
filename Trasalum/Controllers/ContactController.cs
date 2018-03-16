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
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Contact
        public async Task<IActionResult> Index(int id)
        {
            var applicationDbContext = _context.Contact.Where(c => c.AlumId == id).Include(c => c.Alum).Include(c => c.ContactType).Include(c => c.Note).Include(c => c.Staff);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Contact/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.Alum)
                .Include(c => c.ContactType)
                .Include(c => c.Note)
                .Include(c => c.Staff)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contact/Create
        public IActionResult Create(int id)
        {
            var person = _context.Alum.Where(a => a.Id == id).Single();
            string alumName = person.FirstName + " " + person.LastName;
            var userId = User.Identity.GetUserId();
            var user = _context.ApplicationUser.Where(u => u.Id == userId).Single();
            string userName = user.FirstName + " " + user.LastName;
            var initiator = _context.Staff.Where(s => s.Name == userName).Single();
            string initiatorName = initiator.Name;
            DateTime suggestTime = DateTime.Now;

            ViewData["AlumName"] = alumName;
            ViewData["ContactMethod"] = new SelectList(_context.ContactType, "Id", "Name");
            //ViewData["NoteId"] = new SelectList(_context.Note, "Id", "Detail");
            ViewData["Initiator"] = initiatorName;
            ViewData["Date"] = suggestTime;
            return View();
        }

        // POST: Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Success,Date,AlumId,StaffId,ContactTypeId,NoteId")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumId"] = new SelectList(_context.Alum, "Id", "Address", contact.AlumId);
            ViewData["ContactTypeId"] = new SelectList(_context.ContactType, "Id", "Name", contact.ContactTypeId);
            ViewData["NoteId"] = new SelectList(_context.Note, "Id", "Detail", contact.NoteId);
            ViewData["StaffId"] = new SelectList(_context.Staff, "Id", "Name", contact.StaffId);
            return View(contact);
        }

        // GET: Contact/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.SingleOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewData["AlumId"] = new SelectList(_context.Alum, "Id", "Address", contact.AlumId);
            ViewData["ContactTypeId"] = new SelectList(_context.ContactType, "Id", "Name", contact.ContactTypeId);
            ViewData["NoteId"] = new SelectList(_context.Note, "Id", "Detail", contact.NoteId);
            ViewData["StaffId"] = new SelectList(_context.Staff, "Id", "Name", contact.StaffId);
            return View(contact);
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Success,Date,AlumId,StaffId,ContactTypeId,NoteId")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.Id))
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
            ViewData["AlumId"] = new SelectList(_context.Alum, "Id", "Address", contact.AlumId);
            ViewData["ContactTypeId"] = new SelectList(_context.ContactType, "Id", "Name", contact.ContactTypeId);
            ViewData["NoteId"] = new SelectList(_context.Note, "Id", "Detail", contact.NoteId);
            ViewData["StaffId"] = new SelectList(_context.Staff, "Id", "Name", contact.StaffId);
            return View(contact);
        }

        // GET: Contact/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.Alum)
                .Include(c => c.ContactType)
                .Include(c => c.Note)
                .Include(c => c.Staff)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contact.SingleOrDefaultAsync(m => m.Id == id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}
