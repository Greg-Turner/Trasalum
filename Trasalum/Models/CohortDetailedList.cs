using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class CohortDetailedList
    {
        public Cohort Cohort { get; set; }

        [Display(Name = "Instructors")]
        public IEnumerable<Staff> Instructors { get; set; }

        [Display(Name = "Technologies")]
        public IEnumerable<Tech> Tech { get; set; }
    }
}
