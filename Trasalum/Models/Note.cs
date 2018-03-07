using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Detail { get; set; }

        //NoteId is a foreign key in the Contact table, this collection is for lazy loading of the Contacts
        public virtual ICollection<Contact> Contact { get; set; }

        //NoteId is a foreign key in the Engagement table, this collection is for lazy loading of the Engagements
        public virtual ICollection<Engagement> Engagement { get; set; }
    }
}
