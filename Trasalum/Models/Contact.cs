﻿using System;
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
        [Display(Name = "Date of Contact")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm:tt}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Alum")]
        public int AlumId { get; set; }
        public Alum Alum { get; set; }

        [Required]
        [Display(Name = "Initiated By")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

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
