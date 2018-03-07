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

        //AppUserId is a foreign key in the Staff table, this collection is for lazy loading of the Staff
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
