using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models
{
    public class EngagementComments
    {
        public DateTime Date { get; set; }
        public string Organizer { get; set; }
        public string Description { get; set; }
        public IEnumerable<EngagementType> EngagementType { get; set; }
        public IEnumerable<Alum> Alum { get; set; }
        public IEnumerable<Meetup> Meetup { get; set; }
        public IEnumerable<Tech> Tech { get; set; }
        public string Comment { get; set; }
    }
}
