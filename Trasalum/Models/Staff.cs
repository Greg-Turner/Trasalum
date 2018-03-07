using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Trasalum.Models
{
    public class Staff : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //StaffId is a foreign key in the Contact table, this collection is for lazy loading of the Contacts
        public virtual ICollection<Contact> Contact { get; set; }

        //StaffId is a foreign key in the Engagement table, this collection is for lazy loading of the Engagements
        public virtual ICollection<Engagement> Engagement { get; set; }

        //StaffId is a foreign key in the CohortStaff table, this collection is for lazy loading of the CohortStaff
        public virtual ICollection<CohortStaff> CohortStaff { get; set; }
    }
}
