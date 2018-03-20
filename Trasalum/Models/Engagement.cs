using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Engagement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; } = "Description";

        [Required]
        [Display(Name = "Type of Event")]
        public int EngagementTypeId { get; set; }
        public EngagementType EngagementType { get; set; }

        [Display(Name = "Technology Topic")]
        public int? TechId { get; set; }
        public Tech Tech { get; set; }

        [Display(Name = "Meetup Associated")]
        public int? MeetupId { get; set; }
        public Meetup Meetup { get; set; }

        [Required]
        [Display(Name = "Organizer")]
        public ApplicationUser Organizer { get; set; }

        [Display(Name = "Comments")]
        public int? NoteId { get; set; }
        public Note Note { get; set; }

        //EngagementId is a foreign key in the EngagementAlum table, this collection is for lazy loading of the EngagementAlums
        public virtual ICollection<EngagementAlum> EngagementAlum { get; set; }
    }
}
