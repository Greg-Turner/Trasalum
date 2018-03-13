using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Trasalum.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //ApplicationUserId is a foreign key in the Contact table, this collection is for lazy loading of the Contacts
        public virtual ICollection<Contact> Contact { get; set; }

        //ApplicationUserId is a foreign key in the Engagement table, this collection is for lazy loading of the Engagements
        public virtual ICollection<Engagement> Engagement { get; set; }

        //ApplicationUserId is a foreign key in the CohortStaff table, this collection is for lazy loading of the CohortStaff
        public virtual ICollection<CohortStaff> CohortStaff { get; set; }
    }
}
