using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class TechType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //TechId is a foreign key in the Tech table, this collection is for lazy loading of the Techs
        public virtual ICollection<Tech> Tech { get; set; }
    }
}
