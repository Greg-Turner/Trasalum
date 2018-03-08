﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Cohort
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cohort#")]
        public string Number { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "Demo Date")]
        [DataType(DataType.Date)]
        public DateTime DemoDate { get; set; }

        //CohortId is a foreign key in the Engagement table, this collection is for lazy loading of the Engagements
        public virtual ICollection<Engagement> Engagement { get; set; }

        //CohortId is a foreign key in the Alum table, this collection is for lazy loading of the Alums
        public virtual ICollection<Alum> Alum { get; set; }

        //CohortId is a foreign key in the CohortStaff table, this collection is for lazy loading of the CohortStaffs
        public virtual ICollection<CohortStaff> CohortStaff { get; set; }

        //CohortId is a foreign key in the CohortTech table, this collection is for lazy loading of the CohortTechs
        public virtual ICollection<CohortTech> CohortTech { get; set; }
    }
}
