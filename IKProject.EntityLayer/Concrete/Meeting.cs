using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.EntityLayer.Concrete
{
    public class Meeting : BaseEntity
    {
        public string MeetingTitle { get; set; }
        public DateTime MeetingDate { get; set; }
        public ICollection<Staff> StaffMembers { get; set; } = new List<Staff>();
    }
}
