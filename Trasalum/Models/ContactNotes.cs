using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class ContactNotes
    {
        public int AlumId { get; set; }
        public string AlumName { get; set; }
        public DateTime Date { get; set; }
        public string Initiator { get; set; }
        public IEnumerable<ContactType> ContactMethods { get; set; }
        public bool Success { get; set; }
        public string Notes { get; set; }
        public IEnumerable<Contact> ContactHistory { get; set; }
    }
}
