using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class EngagementType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Engagement Type")]
        public string Name { get; set; }

        //EngagementTypeId is a foreign key in the Engagement table, this collection is for lazy loading of the Engagements
        public virtual ICollection<Engagement> Engagement { get; set; }
    }
}
