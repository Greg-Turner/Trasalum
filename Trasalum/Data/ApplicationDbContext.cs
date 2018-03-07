using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trasalum.Models;

namespace Trasalum.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Alum> Alum { get; set; }
        public DbSet<AlumTech> AlumTech { get; set; }
        public DbSet<Cohort> Cohort { get; set; }
        public DbSet<CohortStaff> CohortStaff { get; set; }
        public DbSet<CohortTech> CohortTech { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
        public DbSet<Engagement> Engagement { get; set; }
        public DbSet<EngagementAlum> EngagementAlum { get; set; }
        public DbSet<EngagementType> EngagementType { get; set; }
        public DbSet<Meetup> Meetup { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Tech> Tech { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
