using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class ContactType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Communication Method")]
        public string Name { get; set; }

        //ContactyTypeId is a foreign key in the Contact table, this collection is for lazy loading of the Contacts
        public virtual ICollection<Contact> Contact { get; set; }

    }
}
