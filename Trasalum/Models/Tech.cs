using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Tech
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? TechTypeId { get; set; }
        public TechType TechType { get; set; }

        //TechId is a foreign key in the Meetup table, this collection is for lazy loading of the Meetups
        public virtual ICollection<Meetup> Meetup { get; set; }

        //TechId is a foreign key in the CohortTech table, this collection is for lazy loading of the CohortTechs
        public virtual ICollection<CohortTech> CohortTechs { get; set; }

        //TechId is a foreign key in the AlumTech table, this collection is for lazy loading of the AlumTechs
        public virtual ICollection<AlumTech> AlumTech { get; set; }

        //TechId is a foreign key in the Engagement table, this collection is for lazy loading of the Engagements
        public virtual ICollection<Engagement> Engagement { get; set; }
    }
}
