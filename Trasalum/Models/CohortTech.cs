using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class CohortTech
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TechId { get; set; }
        public Tech Tech { get; set; }

        [Required]
        public int CohortId { get; set; }
        public Cohort Cohort { get; set; }
    }
}
