using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //DepartmentId is a foreign key in the Staff table, this collection is for lazy loading of the Staff
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
