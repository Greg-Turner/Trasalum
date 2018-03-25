using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trasalum.Models
{
    public class Cohort
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cohort#")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "Demo Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
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
