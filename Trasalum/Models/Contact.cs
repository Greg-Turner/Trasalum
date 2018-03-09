using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Successful Contact?")]
        public bool Success { get; set; }

        [Required]
        [Display(Name = "Date of Contact Attempt")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Alum")]
        public int AlumID { get; set; }
        public Alum Alum { get; set; }

        [Required]
        [Display(Name = "Contact Initiated By")]
        public ApplicationUser Initiator { get; set; }

        [Required]
        [Display(Name = "Communication Method")]
        public int ContactTypeId { get; set; }
        public ContactType ContactType { get; set; }

        [Required]
        [Display(Name = "Notes")]
        public int NoteId { get; set; }
        public Note Note { get; set; }

    }
}
