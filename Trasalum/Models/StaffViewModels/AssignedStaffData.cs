using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trasalum.Models.StaffViewModels
{
    public class AssignedStaffData
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public bool Assigned { get; set; }
        public string Department { get; set; }
    }
}
