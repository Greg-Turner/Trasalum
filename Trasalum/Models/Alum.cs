using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Alum
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Cohort#")]
        public string CohortId { get; set; }
        public Cohort Cohort { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Required]
        [Display(Name = "Phone #")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "GitHub Profile URL")]
        public string GitHub { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "LinkedIn Profile URL")]
        public string LinkedIn { get; set; }

        [Required]
        [Display(Name = "Slack Username")]
        public string Slack { get; set; }

        //AlumId is a foreign key in the Contact table, this collection is for lazy loading of the Contacts
        public virtual ICollection<Contact> Contact { get; set; }

        //AlumId is a foreign key in the EngagementAlum table, this collection is for lazy loading of the EngagementAlums
        public virtual ICollection<EngagementAlum> EngagementAlum { get; set; }

        //AlumId is a foreign key in the AlumTech table, this collection is for lazy loading of the AlumTechs
        public virtual ICollection<AlumTech> AlumTech { get; set; }

    }
}
