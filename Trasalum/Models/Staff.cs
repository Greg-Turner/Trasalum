using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        //StaffId is a foreign key in the CohortStaff table, this collection is for lazy loading of the CohortStaff
        public virtual ICollection<CohortStaff> CohortStaff { get; set; }

        //StaffId is a foreign key in the StaffTech table, this collection is for lazy loading of the STaffTech
        public virtual ICollection<StaffTech> StaffTech { get; set; }
    }
}
