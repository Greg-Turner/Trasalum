using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class CohortStaff
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public ApplicationUser Staff { get; set; }

        [Required]
        public int CohortId { get; set; }
        public Cohort Cohort { get; set; }
    }
}
