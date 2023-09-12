using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.EntityLayer.Concrete
{
    public class StaffMeeting : BaseEntity
    {
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
    }
}
