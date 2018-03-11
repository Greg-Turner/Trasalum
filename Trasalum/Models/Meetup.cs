using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Meetup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; } = "Description";

        [Display(Name = "Technology Focus")]
        public int? TechId { get; set; }
        public Tech Tech { get; set; }

        //MeetupId is a foreign key in the Engagement table, this collection is for lazy loading of the Engagements
        public virtual ICollection<Engagement> Engagement { get; set; }
    }
}
