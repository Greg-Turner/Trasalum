using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

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
        [Display(Name = "Main Phone #")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "Website URL")]
        public string Website { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "LinkedIn Profile URL")]
        public string LinkedIn { get; set; }

    }
}
