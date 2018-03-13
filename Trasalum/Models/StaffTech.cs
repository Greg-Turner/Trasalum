using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class StaffTech
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public int TechId { get; set; }
        public Tech Tech { get; set; }
    }
}
