using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class EngagementAlum
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EngagementId { get; set; }
        public Engagement Engagement { get; set; }

        [Required]
        public int AlumId { get; set; }
        public Alum Alum { get; set; }
    }
}
